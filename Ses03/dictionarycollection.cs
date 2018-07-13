using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	class dictionarycollection
	{
		static void Main()
		{
			Dictionary<String, Object> dt = new Dictionary<string, object>();
			dt.Add("Eid",1010);
			dt.Add("Ename", "Suheb");
			dt.Add("job", "Manager");
			dt.Add("Salary", 25000.00);


			foreach(string key in dt.Keys)
				Console.WriteLine(key+" : "+dt[key]);

			Console.ReadLine();
		}
	}
}
