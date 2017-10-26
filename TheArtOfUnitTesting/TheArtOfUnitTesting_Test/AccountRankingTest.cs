using NUnit.Framework;
using TheArtOfUnitTesting;

namespace TheArtOfUnitTesting_Test
{
    [TestFixture]
    public class AccountRankingTest
    {
        [Test]
        public void AccountWithPositiveHistory_CalculateRanking_RankingIsPositive()
        {
            var accountRanking = new AccountRanking();
            var fakeAccount = new AlwaysPositiveHistoryFakeAccount();

            var actualRanking = accountRanking.CalculateRanking(fakeAccount);

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
