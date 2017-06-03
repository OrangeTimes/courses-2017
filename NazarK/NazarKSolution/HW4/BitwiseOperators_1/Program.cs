using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter comma separated values for dividend and divisor: ");

			// Get inputs from user
			string userInput = Console.ReadLine();

			// Evaluate and print result
			bool isDivisible = DevideValuesInUserInput(userInput);
			Console.WriteLine($"Output: {isDivisible}");
		}

		// parse, devide and return result
		public static bool DevideValuesInUserInput(string userInput)
		{
			string[] parts = userInput.Split(',');
			int dividend = Convert.ToInt32(parts[0]);
			int divisor = Convert.ToInt32(parts[1]);
			bool isDivisible = dividend % divisor == 0;
			return isDivisible;
		}
	}
}