using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class Destruct
	{
		public Destruct()
		{
			Console.WriteLine("Constructor");
		}

		~Destruct()
		{
			Console.WriteLine("Destructor");
		}
		
	}

	class MainClass
	{
		static void Main()
		{
			Destruct obj = new Destruct();
			Console.ReadKey();
		}
	}
}
