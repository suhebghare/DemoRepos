using System;

namespace Ses03
{
	class ExtensionMethod
	{
		public void test1()
		{
			Console.WriteLine("Method 1");
		}
		public void test2()
		{
			Console.WriteLine("Method 2");
		}

	}

	public class testExtension
	{
		static void Main()
		{
			ExtensionMethod obj = new ExtensionMethod();
			obj.test1(); obj.test2(); obj.test3();
			string str = "mY wOrLd MY RUleS";
			str = str.proper();
			Console.WriteLine(str);
			Console.ReadLine();
		}
	}

	static class exten
	{

		//Method binding
		public static void test3(this ExtensionMethod E)
		{
			Console.WriteLine("Method 3");
		}

		public static string proper(this string s)
		{
			if(s.Trim().Length > 0)
			{
				string temp = null;
				s = s.ToLower();
				string[] s1 = s.Split(' ');

				foreach(string str in s1)
				{
					char[] c = str.ToCharArray();
					c[0] = char.ToUpper(c[0]);

					if (temp == null)
						temp = new string(c);
					else
						temp += " " +new string(c);
				}
				return temp;
			}
			return s;
		}
	}
}
