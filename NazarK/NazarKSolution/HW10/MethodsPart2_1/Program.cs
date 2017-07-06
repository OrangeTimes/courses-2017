using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_1
{
	class Program
	{
		// Write a C# program which supports calculation of sum for 2 doubles,
		// 2 integers, any number of integers and doubles passed in as
		// a parameters (Hint: use params to support multiple arguments)
		static void Main(string[] args)
		{
			Console.Write("Sum of 5, 10 results in: ");
			Console.WriteLine(Sum(5, 10));

			Console.Write("Sum of 4.5, 15.5 results in: ");
			Console.WriteLine(Sum(4.5, 15.5));

			Console.Write("Sum of 1, 2, 3, 4, 5, 6, 0 results in: ");
			Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 0));

			Console.Write("Sum of 1.05, 2.06, 3.07, 4.08, 5.09, 0.1 results in: ");
			Console.WriteLine(Sum(1.05, 2.06, 3.07, 4.08, 5.09, 0.1));
		}

		static double Sum(double firstNum, double secondNum)
		{
			return firstNum + secondNum;
		}

		static int Sum(int firstNum, int secondNum)
		{
			return firstNum + secondNum;
		}

		static int Sum(params int[] args)
		{
			int sum = 0;
			foreach (int num in args)
			{
				sum += num;
			}
			return sum;
		}

		static double Sum(params double[] args)
		{
			double sum = 0;
			foreach (double num in args)
			{
				sum += num;
			}
			return sum;
		}
	}
}
