using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class Generics2
	{
		public static void Main()
		{
			Math<int> obj = new Math<int>();
			obj.add(10, 20);
			obj.sub(20, 10);
			Console.ReadLine();
		}
	}

	//Generic Class
	class Math<T>
	{
		public void add(T a,T b)
		{
			dynamic x = a;
			dynamic y = b;
			Console.WriteLine("Addition is "+(x+y));
		}

		public void sub(T a, T b)
		{
			dynamic x = a;
			dynamic y = b;
			Console.WriteLine("Substraction is " + (x - y));
		}
	}
}
