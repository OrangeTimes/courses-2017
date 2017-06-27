using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values_in_jagged_or_multidimensional_array_Part_2
{
	class Program
	{
		static void Main(string[] args)
		// Print out all values in reversed order(starting from last element) in jagged or multidimensional array
		{
			int[][] jaggedArray = new int[][]
			{
				new int [] {5,6,-1,-10,23433},
				new int [] {8,34,678,2},
				new int [] {-4,6,546}
			};

			for (int i = jaggedArray.Length - 1; i >= 0; i--)
			{
				for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
				{
					Console.WriteLine(jaggedArray[i][j]);
				}
			}
			Console.ReadKey();
		}
	}
}

