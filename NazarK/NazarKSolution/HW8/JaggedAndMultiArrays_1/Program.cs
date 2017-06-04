using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedAndMultiArrays_1
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

			// sum and count of all elements in array
			int sum = GetSumOfElementsUsingForLoop(jaggedArray);
			int count = GetCountOfElementsUsingForLoop(jaggedArray);

			// get average of numbers in array using For Loop
			GetAverage(sum, count);

			// sum and count of all elements in array
			sum = GetSumOfElementsUsingForEachLoop(jaggedArray);
			count = GetCountOfElementsUsingForEachLoop(jaggedArray);

			// get average of numbers in array using For Each Loop
			GetAverage(sum, count);
		}

		private static void GetAverage(int sum, int count)
		{
			int average = sum / count;
			Console.WriteLine($"Average of all items in jagged array is: {average}");
		}

		public static int GetSumOfElementsUsingForLoop(int[][] jaggedArray)
		{
			int sum = 0;
			for (int i = 0; i < jaggedArray.Length; i++)
			{
				for (int j = 0; j < jaggedArray[i].Length; j++)
				{
					sum += jaggedArray[i][j];
				}
			}
			return sum;
		}

		public static int GetSumOfElementsUsingForEachLoop(int[][] jaggedArray)
		{
			int sum = 0;
			foreach (int[] array in jaggedArray)
			{
				foreach (int number in array)
				{
					sum += number;
				}
			}
			return sum;
		}

		public static int GetCountOfElementsUsingForLoop(int[][] jaggedArray)
		{
			int count = 0;
			for (int i = 0; i < jaggedArray.Length; i++)
			{
				for (int j = 0; j < jaggedArray[i].Length; j++)
				{
					count++;
				}
			}
			return count;
		}

		public static int GetCountOfElementsUsingForEachLoop(int[][] jaggedArray)
		{
			int count = 0;
			foreach (int[] array in jaggedArray)
			{
				foreach (int number in array)
				{
					count++;
				}
			}
			return count;
		}
	}
}
