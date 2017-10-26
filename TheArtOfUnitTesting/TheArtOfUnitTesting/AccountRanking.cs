using System.Linq;
using Newtonsoft.Json.Linq;

namespace TheArtOfUnitTesting
{
    public class AccountRanking
    {
        public IAccount Account { get; set; }

        public AccountRanking()
        {
            
        }

        public AccountRanking(IAccount account)
        {
            Account = account;
        }

        public double CalculateRanking(IAccount account)
        {
            var history = account.ImportAccountHistory();

            var ranking = DoSomeMath(history);

            return ranking;
        }

        public double CalculateRanking()
        {
            var history = Account.ImportAccountHistory();

            var ranking = DoSomeMath(history);

            return ranking;
        }

        private static double DoSomeMath(string history)
        {
            var array = JArray.Parse(history);

            var ranking = array.Average(jToken => (int)(JValue)jToken);

            return ranking;
        }
    }
}
