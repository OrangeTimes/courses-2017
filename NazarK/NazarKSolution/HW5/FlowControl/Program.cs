using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
	class Program
	{
		static void Main(string[] args)
		{
			// Task 1
			Console.Write("Enter a number you want to evaluate: ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.WriteLine($"Entered number {number} is even\n");
			}
			else
			{
				Console.WriteLine($"Entered number {number} is odd\n");
			}

			// Task 2
			for (int i = -1; i >= -100; i--)
			{
				Console.WriteLine(i);
			}

			// Task 3
			bool isValidName = false;
			string errorMessage = "User name is not valid.\nShould have more than 0 and less than 50 symbols.";

			while (!isValidName)
			{
				Console.Write("\nEnter a user name: ");
				string name = Console.ReadLine();

				if (name.Length > 0 && name.Length < 50)
				{
					isValidName = true;
				}
				else
				{
					Console.WriteLine(errorMessage);
				}
			}
		}
	}
}