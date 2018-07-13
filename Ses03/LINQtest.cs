using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class LINQtest
	{
		public static void Main()
		{
			int[] arr = { 22, 21, 45, 85, 78, 26, 8, 98, 85, 15, 56 };

			ArrayList l = new ArrayList();
			l.Add(20);
			l.Add(30);
			l.Add(250);

			//var bl = from j in l where l >= 20 select j;

			var brr = from i in arr where i > 40 orderby i descending select i;

			foreach(int a in brr)
				Console.WriteLine(a+" ");

			Console.ReadLine();
		}
	}
}
