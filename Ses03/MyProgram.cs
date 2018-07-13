using System;

namespace Ses03
{
	class MyProgram
	{
		static void Main()
		{
			//int x = 90;
			//int y = 40;
			//int z = x + y;
			//Console.WriteLine("Addition of "+x+" and "+y+" is "+z);

			string[] empname = new string[5];
			int[] sal = new int[5];

			Console.WriteLine("Enter your employee name and salary");
			for(int i=0;i<5;i++)
			{
				empname[i]=Console.ReadLine();
				sal[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("\nEntered Employee data is : ");
			for(int i=0; i<5; i++)
			{
				Console.WriteLine("Employee name is : "+empname[i]+" And his salary is : "+sal[i]);
			}

			Console.WriteLine("\nSorted salaries are");
			int temp;
			string temp1;
			for(int i=0; i<5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (sal[i]>sal[j])
					{
						temp = sal[i];
						sal[i] = sal[j];
						sal[j] = temp;
						temp1 = empname[i];
						empname[i] = empname[j];
						empname[j] = temp1;
					}
				}
			}
			
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Employee " + empname[i] + " with salary : " + sal[i]);
			}


			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Why you have entered "+x+" value?");
			Console.ReadLine();
		}
	}
}
