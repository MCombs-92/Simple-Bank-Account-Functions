using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
	class Savings : Account {
		public string SavingsId { get; set; }
		public decimal InterestRate { get; set; }


		//construct
		public Savings(string savingsId,decimal interestrate) {
			SavingsId = savingsId;
			InterestRate = interestrate;
		}


		public decimal InterestPaid(decimal balance) {
			decimal IntPaid;
			IntPaid = (InterestRate * balance);
			return IntPaid;
		}

		public decimal AddInterest(decimal intpaid) {
			Balance = (Balance + intpaid);
			return Balance;
		}


	}
}
