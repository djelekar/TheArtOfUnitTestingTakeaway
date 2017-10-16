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
        [TestCase(100, 200, 300)]
        [TestCase(200, 300, 500)]
        public void InitialBalance_Deposit_NewBalanceCorrect_EvenBetter(int initialBalance, int deposit, int expectedBalance)
        {
            var account = CreateAccount();

            var actualBalance = account.Deposit(deposit);

            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
