using System;

namespace Homework_5_Part_2
{
	class Program
	{
		static void Main(string[] args)
		// Write a program to print all numbers from -1 to -100 using for loop construction.
		{
			int i; // it's better to declare i variable in for body
			for (i = -1; i >= -100; i--)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}
