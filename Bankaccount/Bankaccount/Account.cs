﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bankaccount
{
   abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }
        public Account(string accName, String accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void Deposit (double amount)
        {
            Balance += amount;
            Console.WriteLine("account credited by {0}. Current balance: {1}", amount,Balance);
        }
        public void ShowInfo()
        {
            Console.WriteLine("\tAccount Name:" + AccName);
            Console.WriteLine("\tAccount Number:" + AccNo);
            Console.WriteLine("\tCurrent Balance:" + Balance);
            Console.WriteLine();
        }
        public abstract void Withdraw(double amount);
        public abstract void Transfer(Account acc, double amount);
    }
}
