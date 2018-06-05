using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
	abstract class Account {

		public string AccountNumber { get; set; }
		public string AccountHolder { get; set; }
		public decimal Balance { get; protected set; } = 0.0m;


		// Default class constructor
		public Account() {

		}

		// Enhanced class constructor
		public Account(string accountid, string accountholder) {
			AccountNumber = accountid;
			AccountHolder = accountholder;
		}

		// withdrawa Method
		public void Withdraw(decimal withdraw) {
			if(withdraw <=0) {
				Console.WriteLine("Amount must be greater than 0");
				return;
			}

			if(withdraw > Balance) {
				Console.WriteLine("Amount must be less than Balance");
				return;
			}
			Balance -= withdraw;
		}

		// Deposit Method
		public void Deposit(decimal deposit) {
			if (deposit  <= 0) {
				Console.WriteLine("Amount must be greater than 0");
				return;
			}
			Balance += deposit;
		}

		public decimal GetBalance() {
			return decimal.Round(Balance, 2);
		}

	
		
	}
}
