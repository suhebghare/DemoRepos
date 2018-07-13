using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData
{
	class Acc
	{
		public static void Main()
		{
			Console.WriteLine("Program started");

		}
	}

	class Parent
	{
		public int a1;
		protected int a2;
		private int a3;
		internal int a4;
		protected internal int a5;

		public void method()
		{
			Parent p = new Parent();
			Console.WriteLine(p.GetHashCode());
		}
	}

	class Child : Parent
	{
		public Child()
		{
			
		}
		void method()
		{

		}
	}

	class Random : Child
	{

		public Random():base()
		{

		}
		void method()
		{

		}
	}
}
