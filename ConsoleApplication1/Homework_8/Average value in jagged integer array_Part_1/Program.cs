using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_value_in_jagged_integer_array_Part_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// declare jagged array
			int[][] jaggedArray = new int[][]
			{
				new int[] {5,6,-1,-10,23433},
				new int[] {8,34,678,2},
				new int[] {-4,6,546}
			};
			// declare variables - sum and count
			int sumOfJagggedArray = 0;
			int numberOfJaggedArray = 0;
			{
			// find length of jagged arrays
				for (int i = 0; i < jaggedArray.Length; i++) // !!! line should be aligned with previous statment
					for (int j = 0; j < jaggedArray[i].Length; j++)
					{
			// find sum of jagged arrays --> !!! this commnet should be aligned with previous statement
						sumOfJagggedArray += jaggedArray[i][j];
						numberOfJaggedArray++;
					}
			}
			// find average of jagged arrays
			int averageOfJaggedArray = sumOfJagggedArray / numberOfJaggedArray;
			Console.WriteLine($"The average of the jagged array is {averageOfJaggedArray}");
			Console.ReadKey();
		}
	}
}
