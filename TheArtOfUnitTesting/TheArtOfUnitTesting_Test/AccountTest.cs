using NUnit.Framework;
using TheArtOfUnitTesting;

namespace TheArtOfUnitTesting_Test
{
    [TestFixture]
    public class AccountTest
    {
        // bad
        [Test]
        public void InitialBalance_Deposit200_BalanceIs200_Bad()
        {
            var account = new Account();

            Assert.AreEqual(200, account.Deposit(200));
        }

        // better
        [Test]
        public void InitialBalance_Deposit200_BalanceIs200_Better()
        {
            var account = new Account();

            var actualBalance = account.Deposit(200);

            Assert.AreEqual(200, actualBalance);
        }

        // good
        [TestCase(100, 200, 300)]
        [TestCase(200, 300, 500)]
        public void InitialBalance_Deposit_NewBalanceCorrect_Good(int initialBalance, int deposit, int expectedBalance)
        {
            var account = new Account(initialBalance);

            var actualBalance = account.Deposit(deposit);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        private static Account CreateAccount()
        {
            return new Account();
        }

        // even better
        [TestCase(200, 200)]
        [TestCase(300, 300)]
        public void InitialBalance_Deposit_NewBalanceCorrect_EvenBetter(int deposit, int expectedBalance)
        {
            var account = CreateAccount();

            var actualBalance = account.Deposit(deposit);

            Assert.AreEqual(expectedBalance, actualBalance);
        }

        // builder impl
        [TestCase(100, 400, 200, 300)]
        [TestCase(200, 400, 300, 200)]
        public void InitialBalance_Deposit_NewBalanceCorrect_Builder(int initialBalance, int limit, int deposit, int expectedBalance)
        {
            var account = new AccountBuilder()
                                .WithInitialBalance(initialBalance)
                                .WithLimit(limit)
                                .Build();

            var actualBalance = account.Deposit(deposit);

            Assert.That(actualBalance, Is.EqualTo(expectedBalance));
        }

        // bad
        [TestCase(100, 400, 200, 300)]
        [TestCase(200, 400, 300, 200)]
        public void InitialBalance_Deposit_NewBalanceCorrect_Bad(int initialBalance, int limit, int deposit, int expectedBalance)
        {
            var account = new AccountBuilder()
                .WithInitialBalance(initialBalance)
                .WithLimit(limit)
                .Build();

            Assert.That(initialBalance, Is.EqualTo(account.Balance));

            var actualBalance = account.Deposit(deposit);

            Assert.That(actualBalance, Is.EqualTo(expectedBalance));
        }
    }

    internal class AccountBuilder
    {
        private int _balance;
        private int _limit = int.MaxValue;

        public AccountBuilder WithInitialBalance(int initialBalance)
        {
            _balance = initialBalance;
            return this;
        }

        public AccountBuilder WithLimit(int limit)
        {
            _limit = limit;
            return this;
        }

        public Account Build()
        {
            return new Account(_balance, _limit);
        }
    }
}
