using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Displaying passed in args:");
			GetValue(args);
			Console.ReadKey();
		}

		private static void GetValue(string[] args)
		{
			int x = 0;
			foreach (string arg in args)
			{
				Console.WriteLine("Value of arg:" + arg);
			}
		}
	}
}
