using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			// get user input
			int firstNumber = GetFirstNumber();
			int secondNumber = GetSecondNumber();

			// Show results of math operations
			ShowResultsOfMathOperations(firstNumber, secondNumber);
		}

		private static void ShowResultsOfMathOperations(int firstNumber, int secondNumber)
		{
			Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
			Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
			Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
			Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
			Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
		}

		private static int GetSecondNumber()
		{
			Console.Write("Please enter second number (bigger than 0): ");
			int secondNumber = Convert.ToInt32(Console.ReadLine());
			return secondNumber;
		}

		private static int GetFirstNumber()
		{
			// todo: This is a valid statement, but it is not recommnded to us it as a code convention rule. Move declarations as close to assignment as possible
			Console.Write("Please enter first number: ");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			return firstNumber;
		}
	}
}
