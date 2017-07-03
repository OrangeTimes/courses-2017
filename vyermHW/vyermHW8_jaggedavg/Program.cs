using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW8_jaggedavg
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] MyJaggedArray = { new int[] { 1, 2, 3 }, new int[] { 9, 8, 7, 6, 5, 4 } };
			int SumOfjaggedArray = 0;
			int AvgLengthOfEl = 0;

			foreach (int[] SubArray in MyJaggedArray)
			{
				AvgLengthOfEl += SubArray.Length;
				foreach (var value in SubArray)
				{
					SumOfjaggedArray += value;
				}
			}
			Console.WriteLine(SumOfjaggedArray / AvgLengthOfEl);
			Console.ReadKey();
		}
	}
}
