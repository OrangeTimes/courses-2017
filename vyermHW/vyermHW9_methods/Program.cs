using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW9_methods
{
	class Program
	{
		static void ArrayMethodReverse(object[,] arrays)
		{
			for (int row = arrays.GetLength(0) - 1; row >= 0; row--)
			{
				for (int col = arrays.GetLength(1) - 1; col >= 0; col--)
				{
					Console.WriteLine(arrays[row,col]);
				}
			}
		}

		static void ArrayMethodAverage(object[] arrays)
		{
			int SumOfArray = 0;
			int AvgLength = 0;

			foreach (int[] SubArray in arrays)
			{
				AvgLength += SubArray.Length;
				foreach (var value in SubArray)
				{
					SumOfArray += value;
				}
			}
			Console.WriteLine(SumOfArray / AvgLength);
		}

		static void Main(string[] args)
		{
			object[,] MyMultiArray = { { 1, 2, 3, 4, 5 }, { 11, 22, 33, 44, 55 }, { 111, 222, 333, 444, 555 }, { 1111, 2222, 3333, 4444, 5555 } };
			ArrayMethodReverse(MyMultiArray);

			int[][] MyJaggedArray = { new int[] { 1, 2, 3 }, new int[] { 9, 8, 7, 6, 5, 4 } };
			ArrayMethodAverage(MyJaggedArray);

			Console.ReadKey();
		}
	}
}