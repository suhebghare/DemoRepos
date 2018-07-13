using System;
namespace Ses03
{
	class Class1
	{
		public int i = 20;
		public Class1()
		{
			Console.WriteLine("constructer of class 1");
		}

		public void test1()
		{
			Console.WriteLine("value of i : "+i);
		}
	}

	class Class2 : Class1
	{
		public int j = 30;
		public Class2()
		{
			Console.WriteLine("constructer of class 2");
		}

		public void test1()
		{
			Console.WriteLine("value of i : "+i+"\nvalue of j : "+j);
		}
	}

	class Class3 : Class2
	{
		Class3()
		{
			Console.WriteLine("constructer of class 3");
		}

		public void test1()
		{
			Console.WriteLine("value of i : " + i + "\nvalue of j : " + j);
		}

		public static void Main()
		{
			Class3 c1;
			c1 = new Class3();

			c1.test1();

			Console.ReadKey();
		}
	}

}
