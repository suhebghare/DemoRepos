using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class OveloadingAndRiding
	{
		public int x, y, z;
		public OveloadingAndRiding()
		{
			Console.WriteLine("Parent class constructor");
			x = 10;
			y = 30;
			z = 50;
		}

		public void test()
		{
			Console.WriteLine("Test method of Oveloading class");
		}

		public void test(int x)
		{
			Console.WriteLine("Test method with parameter x = "+x);
		}

		public void test(string s)
		{
			Console.WriteLine("Test method with string parameter s = "+s);
		}

		public void test(String s, int i)
		{
			Console.WriteLine("Test method with String parameter s = "+s+" and i = "+i);
		}

		public virtual void test(int i, string s)
		{
			Console.WriteLine("Parent method for Overridding with parameters i = "+i+" and s = "+s);
		}
	}

	class child : OveloadingAndRiding
	{
		int p, q, r;
		public child()
		{
			Console.WriteLine("Child class constructor");
			p = 20;
			q = 40;
			r = 60;
		}

		public void test(int i, int j)
		{
			Console.WriteLine("Overloadet method in child class with i = "+i+" j = "+j);
		}

		public override void test(int i, string s)
		{
			base.test(3, "Salim");
			Console.WriteLine("child method of Overidded class with param i = "+i+" and s = "+s);
			base.test(4, "Safwan");
		}
	}

	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Program Started : ");
			child obj = new child();
			obj.test();
			obj.test(10);
			obj.test("suheb");
			obj.test(10, 20);
			obj.test("suheb", 1);
			obj.test(2, "ghare");
			Console.WriteLine("Program Ended : ");
			Console.ReadLine();
		}
	}
}
