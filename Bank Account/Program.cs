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
			MySavings.Balance = 0.00m;


			// Initial deposits and withdrawals for method testing
			MySavings.Deposit(1500.00m);
			MySavings.Deposit(3500.00m);
			MySavings.Withdraw(2250.00m);
			MySavings.Deposit(12500.00m);
			MySavings.Withdraw(3277);
			Console.WriteLine($"Current balance is {MySavings.Balance}");

			// Testing method to show total interest paid for the month
			MySavings.InterestPaid(MySavings.Balance);
			Console.WriteLine($"Monthly interest paid is {MySavings.InterestPaid(MySavings.Balance)}");

			// Testing balance + monthly interest paid
			MySavings.AddInterest(MySavings.InterestPaid(MySavings.Balance));
			Console.WriteLine(MySavings.Balance);

			
		}
	}
}
