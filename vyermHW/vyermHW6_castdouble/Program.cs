using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW6_castdouble
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number:");
			string userInput = Console.ReadLine();
			double userNumber = Convert.ToDouble(userInput);

			int checkNumber = (int)userNumber;
			if (checkNumber == userNumber)
			{
				Console.WriteLine("Your number is a whole number.");
			}
			else
			{
				Console.WriteLine("Your number is a real number.");
			}
			Console.ReadKey();
		}
	}
}
