 using System;
 using System.Collections;
 using System.Collections.Generic;
namespace Ses03
{
	class CollectionClass
	{
		 public static void Main()
		{
			//ArrayList al = new ArrayList(10);
			//Console.WriteLine(al.Capacity);

			//al.Add(100);
			//al.Add(200);
			//al.Add(300);
			//al.Add(400);
			//al.Add(500);

			//foreach(object o in al)
			//	Console.Write(o+" ");

			//al.Insert(1, 250);
			//Console.WriteLine();
			//foreach (object o in al)
			//	Console.Write(o + " ");

			//Hashtable ht = new Hashtable();
			//ht.Add("Eno",1001);
			//ht.Add("Ename", "Suheb Ghare");

			//Console.WriteLine(ht["Ename"]);

			//foreach (object key in ht.Keys) 
			//Console.WriteLine(key);

			//foreach (object key in ht.Values)
			//	 Console.WriteLine(key);


			List<int> li = new List<int>();

			li.Add(10);
			li.Add(20);
			li.Add(30);

			foreach (object o in li)
				Console.Write(o + " ");

			Console.ReadLine();

		}
	}
}
