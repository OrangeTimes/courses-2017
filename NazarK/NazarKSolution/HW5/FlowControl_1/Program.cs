using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// get user input
			Console.Write("Enter a number you want to evaluate: ");
			int number = Convert.ToInt32(Console.ReadLine());

			// evaluate input
			CheckIfNumIsEven(number);
		}

		public static void CheckIfNumIsEven(int number)
		{
			if (number % 2 == 0)
			{
				Console.WriteLine($"Entered number {number} is even\n");
			}
			else
			{
				Console.WriteLine($"Entered number {number} is odd\n");
			}
		}
	}
}