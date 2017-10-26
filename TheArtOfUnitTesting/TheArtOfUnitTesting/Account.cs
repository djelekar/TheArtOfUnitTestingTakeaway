namespace TheArtOfUnitTesting
{
    public class Account
    {
        public static int Id;

        public int Balance { get; private set; }
        public int Limit { get; }  = int.MaxValue;

        private readonly int _myId;

        public Account()
        {
            _myId = Id++;
            Balance = 0;
        }

        public Account(int balance)
        {
            Balance = balance;
        }

        public Account(int balance, int limit)
        {
            Balance = balance;
            Limit = limit;
        }

        public int Deposit(int amount)
        {
            if (Balance + amount <= Limit)
                return Balance += amount;

            return Balance;
        }

        public string ImportAccountHistory()
        {
            var history = System.IO.File.ReadAllLines(@"c:\accountHistoryStore.json");

            return history[_myId];
        }
    }
}
