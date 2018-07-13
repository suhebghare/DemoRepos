using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03
{
	public class Emp
	{
		public int id { get; set; }
		public string name { get; set; }
		public string job { get; set; }
		public double salary { get; set; }
	}

	public class org:IEnumerable
	{
		List<Emp> emps = new List<Emp>();
		public void Add(Emp emp)
		{
			emps.Add(emp);
		}

		public IEnumerator GetEnumerator()
		{
			return emps.GetEnumerator();

		}
	}

	class testemp
	{
		static void Main()
		{
			//List<Emp> emp = new List<Emp>();
			org emp = new org();
			emp.Add(new Emp { id = 101, name = "raju", job = "manager", salary = 25000 });
			emp.Add(new Emp { id = 102, name = "mahesh", job = "clerk", salary = 15000 });
			emp.Add(new Emp { id = 103, name = "suresh", job = "manager", salary = 50000 });
			emp.Add(new Emp { id = 104, name = "ramesh", job = "manager", salary = 35000 });


			foreach (Emp o in emp)
				Console.WriteLine(o.id + " " + o.name + " " + o.job + " "+o.salary);

			Console.ReadLine();
		}
	}
}
