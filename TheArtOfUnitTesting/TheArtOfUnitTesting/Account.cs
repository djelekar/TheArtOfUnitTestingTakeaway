using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfUnitTesting
{
    public class Account
    {
        public int Balance { get; private set; }
        public int Limit { get; private set; }  = int.MaxValue;

        public Account()
        {
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
    }
}
