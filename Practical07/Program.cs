using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07
{
	class Program
	{
		static void Main(string[] args)
		{
			//MultiDimensional();
			int[][] jaggedArray = new[]
			{
				new[] {1},
				new[] {3, 4, 5},
				new[] {3, 4, 9, 10, 20},
				new[] {3, 4, 9, 10, 20, 789, 4567705},
			};

			foreach (int[] i in jaggedArray)
			{
				foreach (int j in i)
				{
					Console.WriteLine(j);
				}
			}

			for (int i = 0; i < jaggedArray.Length; i++)
			{
				for (int j = 0; j < jaggedArray[i].Length; j++)
				{
					Console.WriteLine(jaggedArray[i][j]);
				}
			}

			Console.ReadKey();

		}

		private static void MultiDimensional()
		{
			int[,] multiDimensional = new int[,]
			{
				{54, 5, 4},
				{10, 7, 9},
				{3, 5, 10}
			};

			//foreach (int i in multiDimensional)
			//{
			//	Console.WriteLine(i);
			//}
			int dimensionCount = multiDimensional.Rank;
			for (int i = 0; i < multiDimensional.GetLength(0); i++)
			{
				for (int j = 0; j < multiDimensional.GetLength(1); j++)
				{
					Console.WriteLine(multiDimensional[i, j]);
				}
			}

			Console.WriteLine("Length:");
			Console.WriteLine(multiDimensional.Length);
			Console.ReadKey();
		}
	}
}
