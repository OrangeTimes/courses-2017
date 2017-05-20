using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndArrays
{
	class Program
	{
		public enum PostalDeliveryMethod
		{
			// to avoid problem with zero index put first item = 1
			byRailway = 1,
			byPlane,
			bySea,
			byCar,
			byHyperLoop
		}
		static void Main(string[] args)
		{
			// Task 1. You are developing postal delivery application
			// write a program to get info of delivery method
			// and display it using enums. (User input can be provided as number)
			Console.Write("Please enter number of delivery method that you chose (from 1 to 5): ");

			// get user input
			string input = Console.ReadLine();

			// cast user input to enum
			PostalDeliveryMethod userDeliveryMethod = (PostalDeliveryMethod)Convert.ToInt32(input);
			Console.WriteLine($"You chose: {userDeliveryMethod}");


			// Task 2.Write a program to get maximum and minimum value of values in predefined array
			int[] predefinedArray  = new int[]{26, 47, 8, 23, -69, 0, 82, 16, -7};

			// find max value
			int max = predefinedArray[0];
			foreach (int number in predefinedArray)
			{
				if (number > max)
				{
					max = number;
				}
			}
			Console.WriteLine($"Maximum number is: {max}");

			// find min value
			int min = predefinedArray[0];
			foreach (int number in predefinedArray)
			{
				if (number < min)
				{
					min = number;
				}
			}
			Console.WriteLine($"Minimum number is: {min}");


			// Task 3.Write each char in predefined string in new line in console
			// (treat string as a char array it supports it out of the box).
			string predefinedString = "HelloWorld";

			// split string to parts
			char[] parts = predefinedString.ToCharArray();

			// print string parts vertically
			foreach (char character in parts)
			{
				Console.WriteLine(character);
			}
		}
	}
}