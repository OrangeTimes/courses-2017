using System;

namespace Homework_4_Part_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Write a program to check if user input is divisible by some number also enter by the user, write the result to console.
			// Example of input: 10 , 2
			// Output: true
			Console.WriteLine("Input first number:");
			int input1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input second number:");
			int input2 = Convert.ToInt32(Console.ReadLine());
			bool isDivisible = false;

			// todo it's better to move this code to isDivisible
			if (input1 % input2 == 0)
			{
				isDivisible = true;
			}
			Console.WriteLine($"Number is divisible: {isDivisible}");
			Console.ReadLine();
		}
	}
}