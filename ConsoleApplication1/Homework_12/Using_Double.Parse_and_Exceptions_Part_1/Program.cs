using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Double.Parse_and_Exceptions_Part_1
// Write a program to check if a string is a valid number (double) using Double.Parse and show corresponding error to user.
// Try to recover from this exception by asking user for valid input one more time.
{
	class Program
	{
		static void Main(string[] args)
		{
			// using bool - the user gets the message till he enters an invalid value
			bool inputValueIsValid = false;
			do
			{
				Console.Write("Please specify the value: ");
				string inputValue = Console.ReadLine();
				try
				{
					//Double.Parse - converts a string representation of the number to double number
					Double.Parse(inputValue);
					inputValueIsValid = true;
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Error Message: Argument null");
				}
				catch (FormatException)
				{
					Console.WriteLine("Error Message: does not represent a number in a valid format");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Error Message: represents a number that is less than MinValue or greater than MaxValue");
				}
				catch (ArgumentException)
				{
					Console.WriteLine("Error Message: style is not a NumberStyles value or style includes the AllowHexSpecifier value");
				}
			}
			while (inputValueIsValid == false);
		}

	}
}