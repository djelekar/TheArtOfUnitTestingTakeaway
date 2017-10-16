using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArtOfUnitTesting
{
    public class Account
    {
        private int _balance;
        private readonly int _limit = int.MaxValue;

        public Account()
        {
            _balance = 0;
        }

        public Account(int balance)
        {
            _balance = balance;
        }

        public Account(int balance, int limit)
        {
            _balance = balance;
            _limit = limit;
        }

        public int Deposit(int amount)
        {
            if (_balance + amount <= _limit)
                return _balance += amount;

            return _balance;
        }
    }
}
