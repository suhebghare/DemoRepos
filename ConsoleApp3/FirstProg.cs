using System;

namespace ConsoleApp3
{

	//Data Types
	class Program
	{
		public Program()
		{

		}
		static void Main(string[] args)
		{
			//Ma obj = new Ma();
			//obj.print();

			var name = "Roshan";

			VarMa a = new VarMa();
			a.x = 10;
			a.y = 20;
			Console.WriteLine(a.x+" "+a.y);

			VarMa b = new VarMa(a);
			Console.WriteLine(b.x+" "+b.y);
			Console.ReadLine();
		}
	}

	class Ma
	{
		byte a;
		sbyte b;
		int c;
		uint d;
		short e;
		ushort f;
		long g;
		ulong h;
		float i;
		double j;
		decimal k;
		bool l;
		char m;

		public void print()
		{
			Console.WriteLine(a + " " + b + " " + c + " " + d + " "+e+" "+f+" "+g+" "+h+" "+i+" " +j+
				" "+k+" "+l+" "+m);
			Console.ReadLine();
		}
	}

	class VarMa
	{
		public int x;
		public float y;

		public VarMa()
		{
		}

		public VarMa(VarMa abc)
		{
			this.x = abc.x;
			this.y = abc.y;
		}
	}

	class st
	{
		public static int x;
		public int y;

	}
}
