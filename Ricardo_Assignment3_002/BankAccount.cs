using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricardo_Assignment3_002
{
	public class BankAccount
	{


		private String holder;
		protected Double balance;

		//Default constructor
		public BankAccount()
		{
		}

		//Constructor with parameter
		public BankAccount(String holder, Double balance)
		{

			this.holder = holder;
			this.balance = balance;
		}


		public String getHolder()
		{
			return holder;
		}

		public void setHolder(String holder)
		{
			this.holder = holder;
		}

		public Double getBalance()
		{
			return balance;
		}

		public void withdraw(double amount)
		{
			balance -= amount;
		}

		public void deposit(double amount)
		{
			balance += amount;
		}

		public override string ToString()
		{
			return "Holder Name: " + getHolder() + "  ==============> Balance: " + getBalance().ToString("C");
		}
	}
}
