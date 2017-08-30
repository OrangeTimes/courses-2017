using System;

namespace Exception_Handling_1
{
	// Write a program to check if a string is a valid number(double) using Double.
	// Parse and show corresponding error to user.
	// Try to recover from this exception by asking user for valid input one more time
	class Program
	{
		static void Main(string[] args)
		{
			// Ask user for input until it's valid
			bool isValidDouble = false;
			do
			{
				// Ask for a string 
				Console.Write("Enter a string to check if it's a Double: ");
				string userInput = Console.ReadLine();

				// Check if it as a valid Double
				try
				{
					// Try to parse string to Double
					Double.Parse(userInput);
					isValidDouble = true;
				}
				// catch all kinds of exceptions and return false because it's not convertible
				catch (ArgumentNullException e)
				{
					Console.WriteLine(MyFancyErrorMessage(e));
				}
				catch (FormatException e)
				{
					Console.WriteLine(MyFancyErrorMessage(e));
				}
				catch (OverflowException e)
				{
					Console.WriteLine(MyFancyErrorMessage(e));
				}

				// Form and print the message based on if string was Double or not
				string validationMessage = isValidDouble ? "Input is a valid Double" : "Input is NOT a valid Double, try again.\n";
				Console.WriteLine(validationMessage);
			}
			while (!isValidDouble);
		}

		static string MyFancyErrorMessage(Exception e)
		{
			return "\n" + e.Message + "\n" + e.StackTrace + "\n";
		}
	}
}
