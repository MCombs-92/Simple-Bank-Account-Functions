using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
	class Checking : Account {

		public int NextCheckNbr { get; set; } = 1;

		public void  WriteCheck(string payee, decimal amount) {
			int CheckNbr = NextCheckNbr++;
			Withdraw(amount);
		}

		public Checking(string accountid, string accountholder) : base(accountid, accountholder) {

		}

	}
}
