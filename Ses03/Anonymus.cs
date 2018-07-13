using System;

namespace Ses03
{
	public delegate void dtest();
	public delegate void dtest1();
	public delegate void dtest2();
	class Anonymus
	{
		public static void test()
		{
			Console.WriteLine("Hello suheb :");
		}

		static void Main()
		{
			dtest obj = new dtest(test);
			obj();
			MyClass2 o = new MyClass2();

			dtest1 obj1 = o.test1;
			obj1 += o.test2;

			obj1();
			//obj2();
			Console.ReadLine();
		}
	}

	public class MyClass2
	{
		public void test1()
		{
			Console.WriteLine("Method 1");
		}

		public void test2()
		{
			Console.WriteLine("Method 2");
		}
	}
}
