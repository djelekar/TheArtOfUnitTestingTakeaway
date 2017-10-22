using System.Net;

namespace TheArtOfUnitTesting
{
    public class AccountRanking : IAccountRanking
    {
        public double CalculateRanking(Account account)
        {
            var accountRankingClient = new WebClient();
            //return accountRankingClient.CalculateRanking();
            return 0;
        }
    }
}
