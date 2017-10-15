using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_with_Math_Operations
{
	class MathOperation
	// the methods above compute the basic math. operations.
	{
		public static double result;
		/// <summary>
		/// this static method add x to y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public static double Adding(double x, double y)
		{
			result = x + y;
			return result;
		}
		public static double Subtract(int x, int y)
		{
			result = x - y;
			return result;
		}
		public static double Multiply(int x, int y)
		{
			result = x * y;
			return result;
		}
		public static double Divide(double x, double y)
		{
			result = x / y;
			return result;
		}
	}
}

