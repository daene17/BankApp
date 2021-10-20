using System;
using System.Collections.Generic;

namespace BankAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.name = "Bank of .NET";

            // create an account with initial balance $5000.00
            CheckingAccount account1 = new CheckingAccount("John Doe", 5000.00);
            // add the account to the bank
            List<Account> accountList = new List<Account>();
            accountList.Add(account1);
            bank.accounts = accountList;

            bank.accounts[0].deposit(2500.00);
            // initial balance is 5000.00, after deposit should be 7500.00
            Console.WriteLine(bank.accounts[0].balance);
            //Account account2 = new Account("Dane Boe", 1000.00);
        }
    }
}
