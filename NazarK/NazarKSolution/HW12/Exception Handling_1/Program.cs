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
			bool isValidDouble;
			do
			{
				// Ask for a string 
				Console.Write("Enter a string to check if it's a Double: ");
				string userInput = Console.ReadLine();

				// Check if it as a valid Double
				isValidDouble = MyCustomTryParse(userInput);

				// Form and print the message based on if string was Double or not
				string validationMessage = isValidDouble ? "Input is a valid Double" : "Input is NOT a valid Double, try again.\n";
				Console.WriteLine(validationMessage);
			}
			while (!isValidDouble);
		}

		static bool MyCustomTryParse(string input)
		{
			try
			{
				// Try to parse string to Double
				Double.Parse(input);
			}
			// catch all kinds of exceptions and return false because it's not convertible
			catch (ArgumentNullException e)
			{
				Console.WriteLine(MyFancyErrorMessage(e));
				return false;
			}
			catch (FormatException e)
			{
				Console.WriteLine(MyFancyErrorMessage(e));
				return false;
			}
			catch (OverflowException e)
			{
				Console.WriteLine(MyFancyErrorMessage(e));
				return false;
			}
			// return true if there was no exceptions which means that it is convertible
			return true;
		}

		static string MyFancyErrorMessage(Exception e)
		{
			return "\n" + e.Message + "\n" + e.StackTrace + "\n";
		}
	}
}
