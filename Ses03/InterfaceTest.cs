using System;

namespace Ses03
{
	class InterfaceTest: Maths
	{
		public void add(int a,int b)
		{
			Console.WriteLine(a + b);
		}

		public void sub(int a, int b)
		{
			Console.WriteLine(a-b);
		}

		static void Main()
		{
			InterfaceTest it = new InterfaceTest();
			Console.WriteLine("Enter 2 numbers to add \na = ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("b = ");
			int b = Convert.ToInt32(Console.ReadLine());
			it.add(a, b);

			Console.WriteLine("Enter 2 numbers to substract \na = ");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("b = ");
			int d = Convert.ToInt32(Console.ReadLine());
			it.sub(c, d);

			Console.ReadLine();
		}
	}

	interface Maths
	{
		void add(int a, int b);
		void sub(int a, int b);
	}
}
