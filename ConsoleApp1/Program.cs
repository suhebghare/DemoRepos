using System;
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			float f1 = 12345678.001f;
			Console.WriteLine(f1.ToString());
			Console.ReadLine();
			Console.WriteLine("Hello World \n");
			int x = 10, y = 20;
			byte b1 = 2;
			float f = 14.01234567f;
			double d = 60.01234567890;
			decimal dec = 128.012345m;
			bool s = true;

			Console.WriteLine("X = {0} \ty = {1} \tb = {2} \tf = {3} \td = {4} \ts = {5} \tdec = {6}", x, y, b1, f, d, s, dec);

			short a;
			int b;
			double c;
			a = 10;
			b = 20;
			c = a + b;
			Console.WriteLine("a = {0}, b = {1}, c = {2} \n", a, b, c);
			
			Animal dog = new Animal();
			dog.PrintAnimal();

			Console.ReadKey();
		}
	}

	public class Animal
	{
		int hight;
		int weight;
		string name;

		public Animal()
		{
			hight = 20;
			weight = 50;
			name = "dog";
		}

		public void PrintAnimal()
		{
			Console.WriteLine("Animal name is : {0} \nHight is : {1} \nWeight is : {2}", name, hight, weight);
			Human sac = new Human();
			sac.PrintHuman();
		}
	}

	class Human
	{
		string name;
		string add;
		int sal;
		char sex;

		public Human()
		{
			name = "Sahil Pathan";
			add = "Shrigonda";
			sex = 'M';
			sal = 150000;
		}

		public void PrintHuman()
		{
			Console.WriteLine("\nHuman name is : {0} \nAddress is : {1} \nSalary is : {2} \nSex is : {3}", name, add, sal, sex);
		}
	}
}