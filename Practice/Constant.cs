using System;

namespace Practice
{
	 class Constant
	{
		public readonly int x;
		public readonly int y;
		public const int c1 = 5;
		public const int c2 = c1 + 5;
		

		public Constant(int p1, int p2)
		{
			x = p1;
			y = p2;
		}

		  public void show()
		{
			Console.WriteLine("x = "+x);
		}

		public Constant()
		{
			x = 20;
			
		}
		static void Main()
		{
			Constant mC = new Constant(11, 22);
			mC.show();
			Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
			Console.WriteLine("c1 = {0}, c2 = {1}",Constant.c1, Constant.c2);
			Console.ReadKey();
		}
	}
}
