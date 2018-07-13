using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			r.Acceptdetails();
			r.Display();

			
			
			Console.ReadLine();
		}
	}
	class Rectangle
	{
		// member variables , class varaible
		double length;
		double width;

		public void Acceptdetails()
		{
			length = 4.5;
			width = 3.5;
		}

		public double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("Length is: "+ length+"\t width is: "+width+"\t Area is: "+ GetArea());
			/*Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());*/
		}
	}
}
