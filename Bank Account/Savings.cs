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

		// Method to find interest paid based on Instance specified interest rate
		public decimal InterestPaid(decimal balance) {
			decimal IntPaid;
			IntPaid = (InterestRate * balance);
			return IntPaid;
		}

		// Method to add interest paid to account balance
		public decimal AddInterest(decimal intpaid) {
			Balance = (Balance + intpaid);
			return Balance;
		}


	}
}
