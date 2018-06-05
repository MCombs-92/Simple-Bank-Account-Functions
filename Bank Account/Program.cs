using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
	class Program {
		static void Main(string[] args) {

			// Initial Savings account instance creation
			Savings MySavings = new Savings("00001234", 0.05m);
			MySavings.AccountNumber = "00004321";
			MySavings.AccountHolder = "Mitchell Combs";

			//Initial Checking account creation
			Checking MyChecking = new Checking("0004321", "Mitchell Combs");
			MyChecking.Deposit(1000);
			MyChecking.WriteCheck("denise", 100);
			Console.WriteLine($"Current Checking balance is {MyChecking.Balance}");


			// Initial deposits and withdrawals for method testing
			MySavings.Deposit(1500.00m);
			MySavings.Deposit(3500.00m);
			MySavings.Withdraw(2250.00m);
			MySavings.Deposit(12500.00m);
			MySavings.Withdraw(3277);
			Console.WriteLine($"Current Savings balance is {MySavings.Balance}");

			// Testing method to show total interest paid for the month
			MySavings.InterestPaid(MySavings.Balance);
			Console.WriteLine($"Monthly interest paid is {MySavings.InterestPaid(MySavings.Balance)}");

			// Testing balance + monthly interest paid
			MySavings.AddInterest(MySavings.InterestPaid(MySavings.Balance));
			Console.WriteLine($"Savings Balance after interest is {MySavings.Balance}");

			List<Account> Accounts = new List<Account> { MySavings, MyChecking };
			decimal TotalAllAccounts = 0;
			foreach( Account accounts in Accounts) {
				TotalAllAccounts += accounts.Balance;
			}

			Console.WriteLine($"Total balance of all accounts is {TotalAllAccounts}");
			

			
		}
	}
}
