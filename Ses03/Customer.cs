using System;
using System.Collections.Generic;
namespace Ses03
{
	class Customer
	{
		public int Custid { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public double Bal { get; set; }

	}

	class Testcust
	{
		static void Main()
		{
			List<Customer> customers = new List<Customer>();
		Customer c1 = new Customer { Custid = 101, Name = "suheb", City = "Sural", Bal = 25000.00 };
		Customer c2 = new Customer { Custid = 102, Name = "Salim", City = "Chiplun", Bal = 50000.00 };

		customers.Add(c1);
		customers.Add(c2);

			//customers.addrange();

			foreach (Customer obj in customers)
				Console.WriteLine(obj.Custid + " " + obj.Name + " " + obj.City + " " + obj.Bal);
			Console.ReadLine();
	}
}
}
