using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW5_even_odd
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your number:");
			int userNumber = Convert.ToInt32(Console.ReadLine());

			if (userNumber % 2 == 0)
			{
				Console.WriteLine("Entered number {0} is even", userNumber);
			}
			else
			{
				Console.WriteLine("Entered number {0} is odd", userNumber);
			}

			Console.ReadKey();
		}
	}
}
