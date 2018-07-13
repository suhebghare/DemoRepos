using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData
{
	class Parameters
	{
		readonly int i;

		public Parameters()
		{
			i = 15;
		}

		public static void Main()
		{
			Parameters par = new Parameters();
		
			const int n=10 ;
			//n = 15;
			int n1 = 10, n2 , n3=20;
			Methods cal = new Methods();
			Console.WriteLine("Result of add method "+cal.Add(z: 10, y: 20, x: 30));
			Console.WriteLine("Result of calc method "+cal.calc(ref n1, out n2, ref n3));
			cal.PrintArr(2,25,35,45);
			Console.WriteLine("Result of Opt method " + cal.Opt(10,40));
			Console.ReadLine();
		}
	}

	class Methods
	{
		public int Add(int x, int y, int z)
		{
			return x + 2 * y - z;
		}

		public int calc(ref int x, out int y, ref int z)
		{
			y = x + z;
			return x + y - z + 10;
		}

		public void PrintArr(int size,params int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

		public int Opt(int x,int y=10,int z=5)
		{
			return x+y+z;
		}
	}
}
