using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppProject
{
    public class InvestmentAccount : Account
    {
        public String type { get; set; }
        public InvestmentAccount(string accountOwner, double accountBalance, string accountType) : base(accountOwner, accountBalance)
        {
            owner = accountOwner;
            balance = accountBalance;
            type = accountType;
        }


        public override void withdraw(double amount)
        {
            if (type == "individual" && amount > 500.00)
            {
                Console.WriteLine("This Account has a withdrawal limit of 500 dollars, please try again later");
            }
            else
            {
                balance -= amount;
            }

        }
    }
}
