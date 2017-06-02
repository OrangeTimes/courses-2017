using System;


namespace Homework_5_Part_1
{
	class Program
	{
		static void Main(string[] args)

		// todo as a rule of thumb put comment over the method declaration (static void Main(string[] args)) and not between method declaration and method body
		// Write a program to print out result if number entered by user is odd or even.If entered number is odd program should print: 
		// “Entered number %number% is odd” or “Entered number %number% is even” otherwise.
		{
			Console.WriteLine("Input the number you would like to check: ");
			int enteredNumber = Convert.ToInt32(Console.ReadLine());
			// Should be verified the next condition: if the number is divisible by 2 with the remainder 0 then the number is even. 
			// Otherwise, if not divisible by 2, then the number will be odd.
			if (enteredNumber % 2 == 0)
			{
				Console.WriteLine($"Entered number {enteredNumber} is Even");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine($"Entered Number {enteredNumber} is Odd");
				Console.ReadLine();
			}
		}
	}
}
