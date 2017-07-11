using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW10_sumdoublesints
{
	class Program
	{
		static int TotalSum(params int[] mult)
		{
			int sum = 0;
			foreach (int i in mult)
			{
				sum += i;
			}
			return sum;
		}

		static double TotalSum(params double[] mult)
		{
			double sum = 0;
			foreach (double i in mult)
			{
				sum += i;
			}
			return sum;
		}

		// Above methods easily support calculation of sum for 2 doubles/integers. But in case separate methods are needed, here they are:
		static int TotalSum(int param1, int param2)
		{
			return param1 + param2;
		}

		static double TotalSum(double param1, double param2)
		{
			return param1 + param2;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(TotalSum(5,10,15,20));
			Console.WriteLine(TotalSum(1.3, 1.7));
			Console.ReadKey();
		}
	}
}