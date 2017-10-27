using Moq;
using NUnit.Framework;
using TheArtOfUnitTesting;

namespace TheArtOfUnitTesting_Test
{
    [TestFixture]
    public class AccountRankingTest
    {
        [Test]
        public void AccountWithPositiveHistory_CalculateRanking_RankingIsPositive_ParameterInjection()
        {
            var accountRanking = new AccountRanking();
            var fakeAccount = new AlwaysPositiveHistoryFakeAccount();

            var actualRanking = accountRanking.CalculateRanking(fakeAccount);

            Assert.That(actualRanking, Is.GreaterThan(0));
        }

        [Test]
        public void AccountWithPositiveHistory_CalculateRanking_RankingIsPositive_ConstructorInjection()
        {
            var fakeAccount = new AlwaysPositiveHistoryFakeAccount();
            var accountRanking = new AccountRanking(fakeAccount);

            var actualRanking = accountRanking.CalculateRanking();

            Assert.That(actualRanking, Is.GreaterThan(0));
        }

        [Test]
        public void AccountWithPositiveHistory_CalculateRanking_RankingIsPositive_SetterInjection()
        {
            var fakeAccount = new AlwaysPositiveHistoryFakeAccount();
            var accountRanking = new AccountRanking();

            accountRanking.Account = fakeAccount;

            var actualRanking = accountRanking.CalculateRanking();

            Assert.That(actualRanking, Is.GreaterThan(0));
        }

        [Test]
        public void AccountWithPositiveHistory_CalculateRanking_RankingIsPositive_Moq()
        {
            var fakeAccount = new Mock<IAccount>();
            fakeAccount.Setup(x => x.ImportAccountHistory()).Returns("[0, 100, 500, 300, 800, 500, 700, 1000]");

            var accountRanking = new AccountRanking {Account = fakeAccount.Object};

            var actualRanking = accountRanking.CalculateRanking();

            Assert.That(actualRanking, Is.GreaterThan(0));
        }

        internal class AlwaysPositiveHistoryFakeAccount : IAccount
        {
            public string ImportAccountHistory()
            {
                return "[0, 100, 500, 300, 800, 500, 700, 1000]";
            }
        }
    }
}
