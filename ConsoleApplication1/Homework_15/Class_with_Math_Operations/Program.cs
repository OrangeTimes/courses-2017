using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_with_Math_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			MathOperation.Adding(56.56, 67.123);
			Console.WriteLine($"Result of Adding: {MathOperation.result}");

			MathOperation.Subtract(56, 67);
			Console.WriteLine($"Result of Subtract: {MathOperation.result}");

			MathOperation.Multiply(56, 67);
			Console.WriteLine($"Result of Multiply: {MathOperation.result}");

			MathOperation.Divide(56.25, 67);
			Console.WriteLine($"Result of Divide: {MathOperation.result}");
			Console.ReadLine();
		}
	}
}
