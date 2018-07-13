using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class SampleClass
	{
		public int x;
		public readonly int y = 25;   // Initialize a readonly field
		public readonly int z;

		public SampleClass()
		{
			z = 24;   // Initialize a readonly instance field
		}

		public SampleClass(int p1, int p2, int p3)
		{
			x = p1;
			y = p2;
			z = p3;
		}
	

		static void Main()
		{
		SampleClass p1 = new SampleClass(11, 21, 32);   // OK
		Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
		SampleClass p2 = new SampleClass();
		p2.x = 55;   // OK
		Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);
		Console.ReadKey();
		}
	}
}
