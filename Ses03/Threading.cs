using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class Threading
	{
		public static void Test1()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Test 1 : "+i);
			}

		}
		public static void Test2()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Test 2 : " + i);
			}
		}

		public static void Test3()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Test 3 : " + i);
			}
		}

		public static void Main()
		{

		}
	}
}
