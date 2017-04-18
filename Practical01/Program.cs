using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name?");
			string myName = Console.ReadLine();
			Console.Write("Username:" + myName);
			Console.ReadKey();
		}
	}
}
