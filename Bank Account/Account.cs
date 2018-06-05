using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
	class Account {

		public string AccountNumber { get; set; }
		public string AccountHolder { get; set; }
		public decimal Balance { get; set; }

		public Account() {

		}

		public Account(string accountid, string accountholder, decimal balance) {
			AccountNumber = accountid;
			AccountHolder = accountholder;
			Balance = balance;
		}


		public decimal Withdraw(decimal withdraw) {
			Balance -= withdraw;
			return Balance;
		}

		public decimal Deposit(decimal deposit) {
			Balance += deposit;
			return Balance;
		}

	
		
	}
}
