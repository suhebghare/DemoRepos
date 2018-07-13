using System;

namespace Ses03
{
	class Class4
	{
		int i, j;
		static int x, y;
		static Class4()
		{
			x = 20;
			Console.WriteLine("In static constructor");
		}
		public Class4()
		{
			i = 40;
			Console.WriteLine("In Default constructor");
		}

		public void display()
		{
			Console.WriteLine("value of i="+i+" j="+j+" x="+x+" y="+y);
		}
	}

	class MyClass
	{
		public static void Main()
		{
			Class4 obj = new Class4();
				obj.display();

			Console.ReadLine();
		}
	}
}

namespace sec04
{
	class def
	{
		void demo()
		{
			Console.WriteLine("hi there");
		}

	}
}
