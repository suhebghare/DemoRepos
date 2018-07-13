using System;
using System.Collections.Generic;
using System.Linq;
namespace Ses03
{
	class Generic3
	{
		public static void Main()
		{
			//mts obj = new mts();
			//Console.WriteLine(obj.test1<float>(30, 20));

			Bank tran = new Bank(1000);
			Console.WriteLine("Your initial balance is "+tran._Amount);
			Console.WriteLine("Enter amout that you want to withdraw");
			int amt = int.Parse(Console.ReadLine());
			tran.Withdraw(amt);
			Console.WriteLine("Your current balance is " + tran._Amount);
			Console.WriteLine("Enter amout that you want to Deposite");
			amt = int.Parse(Console.ReadLine());
			tran.deposite(amt);
			Console.WriteLine("Your current balance is "+tran._Amount);
			Console.ReadLine();
		}
	}

	class Bank
	{
		int Amount;

		public Bank(int amt)
		{
			Amount = amt;
		}

		public int _Amount
			{
			get
			{
				return Amount;
			}
		}

		public void Withdraw(int amt)
		{
			Amount -= amt;
		}

		public void deposite(int amt)
		{
			Amount += amt;
		}
	}

	class mts
	{
		public dynamic test1<T>(int a, T b)
		{
			dynamic x = a;
			dynamic y = b;
			return x - 10;
		}

	}
}
