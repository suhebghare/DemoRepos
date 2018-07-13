using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ses03 
{
   class Student : IComparable<Student>
	{
		
		public int sid { get; set; }
		public string name { get; set; }
		public int sclass { get; set; }
		public double marks { get; set; }

		public int CompareTo(Student other)
		{
			if (this.sid > other.sid)
				return 1;
			else if (this.sid < other.sid)
				return -1;
			else
				return 0;
		}
	}

	class cstd : IComparer<Student>
	{
		public int Compare(Student x, Student y)
		{
			if (x.marks > y.marks)
				return 1;
			else if (x.marks < y.marks)
				return -1;
			else
				return 0;
		}
	}

	class teststd
	{
		public static int comparenames(Student s1, Student s2)
		{
			return s1.name.CompareTo(s2.name);
		}

		public static void Main()
		{
			Student c1 = new Student { sid = 103, name = "suheb", sclass = 10, marks = 25.00 };
			Student c2 = new Student { sid = 101, name = "salim", sclass = 10, marks = 50.00 };
			Student c3 = new Student { sid = 104, name = "Ghare", sclass = 10, marks = 60.00 };
			Student c4 = new Student { sid = 102, name = "Isamil", sclass = 10, marks = 70.00 };

			List<Student> std = new List<Student>() { c1, c2, c3, c4 };

			Student st = new Student();

			//cstd obj = new cstd();
			//std.Sort(obj);

			//Comparison<Student> ob1 = new Comparison<Student>(comparenames);
			//std.Sort(ob1);
			//std.Sort(comparenames);


			//Lambda expression
			std.Sort((s1,s2)=>s1.name.CompareTo(s2.name));

			foreach (Student s in std)
				Console.WriteLine(s.sid + " " + s.name + " " + s.sclass + " " + s.marks);



			Console.ReadLine();
		}
	}
}
