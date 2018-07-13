using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class MethodParam
	{
		static void Main(string[] args)
		{

			show(30, false, 20.0, "hello", 40);

			view(y: 20, z: 10, x: 30);

			print(10,50,20);

			show1("hi",1);

			Console.ReadKey();
		}

		static void show(int a, bool b, double c, string s, int x = 20)
		{
			Console.WriteLine("a ki value : " + a + "\nb ki value : " + b + "\nc ki value : " + c + "\nd ki value : " + s);
			Console.WriteLine("x ki value : " + x);
		}

		static void view(int x, int y, int z)
		{
			Console.WriteLine("\nx ki value : " + x + "\ny ki value : " + y + "\nz ki value : " + z);
		}

		static void print(int a, int b = 100, double c = 200)
		{
			Console.WriteLine("\na ki value : " + a + "\nb ki value : " + b + "\nc ki value : " + c);
		}

		static void show1(string s,params int[] arr)
		{
			Console.WriteLine("\n"+s);
			foreach(int i in arr)
			{
				Console.WriteLine(i);
			}
		}
	}
}
