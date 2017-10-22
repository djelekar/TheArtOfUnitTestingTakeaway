using NUnit.Framework;
using TheArtOfUnitTesting;

namespace TheArtOfUnitTesting_Test
{
    [TestFixture]
    public class AccountRankingTest
    {
        [TestCase(100)]
        public void TestMethod1(double expectedRanking)
        {
            IAccountRanking accountRanking = new AccountRanking();

            var actualRanking = accountRanking.CalculateRanking();

            Assert.That(actualRanking, Is.EqualTo(expectedRanking));
        }
    }
}
