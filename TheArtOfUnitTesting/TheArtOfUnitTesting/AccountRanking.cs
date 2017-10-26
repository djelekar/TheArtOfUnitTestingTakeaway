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

        private double DoSomeMath(string history)
        {
            throw new System.NotImplementedException();
        }
    }
}
