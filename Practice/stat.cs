using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	 static class stat
	{
		static int k = 10;
		public static void show()
		{
			//public static int i = 10;
			Console.WriteLine("In show of stat...");
		}
		
		static void Main(string[] args)
		{
			stat.show();
			view();
			k = 50;
			view();
			Console.ReadKey();
		}

		public static void view()
		{
			 int j = 20;
			Console.WriteLine("k = "+k);
		}
	}
}
