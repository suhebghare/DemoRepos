using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class Cons
	{
		int x;
		public Cons()
		{
			Console.WriteLine("Default constructor called..");
		}

		public Cons(int i)
		{
			x = i;
			Console.WriteLine("Parametrized constructor called : " + i);
		}

		public Cons(Cons obj)
		{
			x = obj.x;
			Console.WriteLine("copy constructer is called.." + x);
		}
		static Cons()
		{
			Console.WriteLine("static constructor is called..");
		}
	}
	class abc { 


		static void Main(string[] args)
		{
			Cons obj1 = new Cons();
			Cons obj2 = new Cons(10);
			Cons obj3 = new Cons(obj2);
			Console.ReadKey();
		}
	}
}
