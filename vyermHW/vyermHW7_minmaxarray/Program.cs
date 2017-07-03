using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW7_minmaxarray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ArrayOfNumbers = { 50, 40, 30, 20, 10, 60, 70, 80, 90, 89 };

			// Option 1.
			int minValue = ArrayOfNumbers[0];
			int maxValue = ArrayOfNumbers[0];
			for (int i = 1; i < ArrayOfNumbers.Length; i++)
			{
				if (minValue > ArrayOfNumbers[i])
				{
					minValue = ArrayOfNumbers[i];
				}

				if (maxValue < ArrayOfNumbers[i])
				{
					maxValue = ArrayOfNumbers[i];
				}
			}

			Console.WriteLine("The Minimum number in your array is {0}", minValue);
			Console.WriteLine("The Maximum number in your array is {0}", maxValue);

			// Option 2.
			Console.WriteLine("The Maximum number in your array is {0}", ArrayOfNumbers.Max());
			Console.WriteLine("The Minimun number in your array is {0}", ArrayOfNumbers.Min());
			Console.ReadKey();
		}
	}
}
