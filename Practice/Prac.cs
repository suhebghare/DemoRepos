using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice
{
	class Prac
	{
		static void Main(string[] args)
		{
			Line l = new Line(20);
			int j = 10;
			l.show(j);
			double len=l.getLength();
			Console.WriteLine("{0}",len);

			l.setLength(10);
			Console.ReadKey();

			
		}
	}

	class Line
	{
		private double length;   // Length of a line

		public Line(double len)
		{
			Console.WriteLine("Object is being created, length = " + len);
			length = len;
		}

		public void setLength(double len)
		{
			length = len;
		}

		public double getLength()
		{
			return length;
		}

		public void show(Object i)
			{
			Console.WriteLine(i);
			}
	}
}