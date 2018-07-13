using System;
namespace Ses03
{
	class Logical
	{
		public static void Main()
		{
			Logical obj = new Logical();
			int No;

			do
			{
				Console.WriteLine("Enter which program do you want to excecute:");

				Console.WriteLine("1.Armstrong number");
				Console.WriteLine("2.Reverse number");
				Console.WriteLine("3.Palindrome number");
				Console.WriteLine("4.Prime number");
				Console.WriteLine("5.fibonacci Series:");
				Console.WriteLine("6.Prime series");
				No = Convert.ToInt32(Console.ReadLine());
				switch (No)
				{
					case 1:
						obj.Armstrong();
						break;
					case 2:
						obj.Reverse();
						break;
					case 3:
						obj.Palindrome();
						break;
					case 4:
						obj.Prime();
						break;
					default:
						Console.WriteLine("Wrong input");
						break;
				}
			}
			while (No <= 4);

			Console.ReadLine();
		}

		public void Armstrong()
		{
			int temp=0,rem;
			Console.WriteLine("Enter a number : ");
			int n = Convert.ToInt32(Console.ReadLine());
			int s = n;
			while (n > 0)
			{
				rem = n % 10;
				temp = temp + (rem * rem * rem);
				n = n / 10;
			}
			Console.WriteLine(temp);
			if(temp==s)
			{
				Console.WriteLine("Entered number "+s+" is Armstrong number");
			}
			else
			{
				Console.WriteLine("Entered number " + s + " is not Armstrong number");
			}
		}

		public void Reverse()
		{
			int temp = 0, rem;
			Console.WriteLine("Enter a number : ");
			int n = Convert.ToInt32(Console.ReadLine());
			while (n > 0)
			{
				rem = n % 10;
				temp = (temp*10) + rem;
				n = n / 10;
			}
			Console.WriteLine("Reverse Numer of "+n+" is "+temp);
			
		}

		public void Palindrome()
		{
			int temp = 0, rem;
			Console.WriteLine("Enter a number : ");
			int n = Convert.ToInt32(Console.ReadLine());
			int s = n;
			while (n > 0)
			{
				rem = n % 10;
				temp = (temp * 10) + rem;
				n = n / 10;
			}
			Console.WriteLine(temp);
			if (temp == s)
			{
				Console.WriteLine("Entered number " + s + " is Palindrome number");
			}
			else
			{
				Console.WriteLine("Entered number " + s + " is not Palindrome number");
			}
		}

		public void Prime()
		{
			Console.WriteLine("Enter a number : ");
			int n = Convert.ToInt32(Console.ReadLine());
			int f = 0;
			for (int i = 2; i < n/2; i++)
			{
				if (n / i == 0)
					f = 1;
				break;
			}
			if (f == 0)
			{
				Console.WriteLine("Entered number " + n + " is Prime number");
			}
			else
			{
				Console.WriteLine("Entered number " + n + " is not Prime number");
			}
		}
	}
}
