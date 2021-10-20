using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppProject
{
    public class CheckingAccount : Account
    {

        public CheckingAccount(string accountOwner, double accountBalance) : base(accountOwner, accountBalance)
        {
            owner = accountOwner;
            balance = accountBalance;
        }
    }
}
