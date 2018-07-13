using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class Generics1
	{
		public static void Main()
		{
			Generics1 obj = new Generics1();
			Console.WriteLine(obj.Compare<int>(10, 10));
			Console.WriteLine(obj.Compare<char>('a', 'a'));
			Console.WriteLine(obj.Compare<string>("Suheb", "suheb"));
			Console.ReadLine();
			{

			}
		}

		//Generic method
		public bool Compare<T>(T a,T b)
		{
			if (a.Equals(b))
				return true;
			return false;
		}
	}
}
