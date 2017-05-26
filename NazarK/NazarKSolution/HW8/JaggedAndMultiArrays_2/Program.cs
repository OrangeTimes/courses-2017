using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedAndMultiArrays_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// predefined jagged array
			int[][] jaggedArray = new int[][]{
				new int[]{1},
				new int[]{2, 3},
				new int[]{4, 5, 6},
				new int[]{7, 8, 9, 10},
				new int[]{11, 12, 13, -14, -15, -16}
			};

			for (int i = jaggedArray.Length - 1; i >= 0; i--)
			{
				for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
				{
					Console.WriteLine(jaggedArray[i][j]);
				}
			}
		}
	}
}
