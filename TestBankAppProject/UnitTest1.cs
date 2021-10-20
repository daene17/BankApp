using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAppProject;
using System.Collections.Generic;

namespace TestBankAppProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deposit()
        {
            //Initialize a Bank
            Bank bank = new Bank();
            bank.name = "Bank of .NET";

            // create an account with initial balance $5000.00
            CheckingAccount account1 = new CheckingAccount("John Doe", 5000.00);
            // add the account to the bank
            List<Account> accountList = new List<Account>();
            accountList.Add(account1);
            bank.accounts = accountList;

            //deposit money to the account
            bank.accounts[0].deposit(2500.00);

            // initial balance is 5000.00, after deposit should be 7500.00
            Assert.AreEqual(7500.00, bank.accounts[0].balance);


        }

        [TestMethod]
        public void WithDrawal()
        {
            Bank bank = new Bank();
            bank.name = "Bank of .NET";


            CheckingAccount account1 = new CheckingAccount("John Doe", 5000.00);

            List<Account> accountList = new List<Account>();
            accountList.Add(account1);
            bank.accounts = accountList;

            //withdraw money from the account
            bank.accounts[0].withdraw(1000.00);

            // initial balance is 5000.00, after deposit should be 4000.00
            Assert.AreEqual(4000.00, bank.accounts[0].balance);
        }

        [TestMethod]
        public void Transfer()
        {
            Bank bank = new Bank();
            bank.name = "Bank of .NET";


            CheckingAccount account1 = new CheckingAccount("John Doe", 5000.00);
            InvestmentAccount account2 = new InvestmentAccount("Dane Boe", 1000.00, "corporate");

            //create two bank accounts 
            List<Account> accountList = new List<Account>();
            accountList.Add(account1);
            accountList.Add(account2);
            bank.accounts = accountList;


            //transfer money from account1 to account2
            bank.transferToAccount(account1, account2, 2500.00);


            // initial balance of account 2 is $1000.00 after the transfer should be $3500.00
            Assert.AreEqual(3500.00, bank.accounts[1].balance);


        }
        [TestMethod]
        public void IndividualInvestmentAccountWithdrawalLimit()
        {
            Bank bank = new Bank();
            bank.name = "Bank of .NET";



            InvestmentAccount account1 = new InvestmentAccount("Dane Boe", 1000.00, "individual");

            //withdraw money from the account
            List<Account> accountList = new List<Account>();
            accountList.Add(account1);
            bank.accounts = accountList;

            bank.accounts[0].withdraw(501.00);

            // the balance should remain 1000.00 and a message should be printed to the console stating that you have gone over the withdrawal limit
            Assert.AreEqual(1000.00, bank.accounts[0].balance);

            //the new balance should be 500.00 as the withdrawal limit has not been exceeded
            bank.accounts[0].withdraw(500.00);
            Assert.AreEqual(500.00, bank.accounts[0].balance);
        }
    }

}
