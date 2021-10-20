using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppProject
{
    public class Bank
    {
        public String name { get; set; }
        public List<Account> accounts;

        public void transferToAccount(Account account1, Account account2, double amount)
        {

            account1.transfer(amount);
            account2.balance += account1.transferAmount;
        }
    }
}
