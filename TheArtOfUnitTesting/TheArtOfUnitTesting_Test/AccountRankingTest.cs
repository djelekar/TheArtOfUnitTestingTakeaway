using NUnit.Framework;
using TheArtOfUnitTesting;

namespace TheArtOfUnitTesting_Test
{
    [TestFixture]
    public class AccountRankingTest
    {
        [TestCase(100)]
        public void Account_CalculateRanking_Correct(double expectedRanking)
        {
            var account = new Account();

            IAccountRanking accountRanking = new AlwaysMaximumFakeAccountRanking();

            var actualRanking = accountRanking.CalculateRanking(account);

            Assert.That(actualRanking, Is.EqualTo(expectedRanking));
        }
    }

    internal class AlwaysMaximumFakeAccountRanking : IAccountRanking
    {
        public double CalculateRanking(Account account)
        {
            return 100;
        }
    }
}
