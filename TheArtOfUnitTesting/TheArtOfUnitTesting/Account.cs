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

        public Account()
        {
            _balance = 0;
        }

        public Account(int balance)
        {
            _balance = balance;
        }

        public int Deposit(int amount)
        {
            return _balance += amount;
        }
    }
}
