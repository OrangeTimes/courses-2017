using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW7_char
{
	class Program
	{
		static void Main(string[] args)
		{
			string MyCustomString = "Hello, World!";
			char[] MyCustomArray = MyCustomString.ToCharArray();
			foreach (char letter in MyCustomArray)
			{
				Console.WriteLine(letter);
			}
			Console.ReadKey();
		}
	}
}
