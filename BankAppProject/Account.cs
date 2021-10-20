using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppProject
{
    public class Account
    {

        public string owner { get; set; }
        public double balance { get; set; }

        public Account(string accountOwner, double accountBalance)
        {
            owner = accountOwner;
            balance = accountBalance;
        }

        public double transferAmount { get; set; }

        public void deposit(double amount)
        {
            balance += amount;
        }
        public virtual void withdraw(double amount)
        {
            balance -= amount;
        }
        public void transfer(double amount)
        {
            transferAmount = amount;
        }
    }
}

