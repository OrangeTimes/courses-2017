using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndArrays_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// predefined array
			int[] predefinedArray = new int[] { 26, 47, 8, 23, -69, 0, 82, 16, -7 };

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
		}
	}
}
