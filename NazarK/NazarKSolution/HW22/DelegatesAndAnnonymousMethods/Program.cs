using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndAnnonymousMethods
{
	class Program
	{
		public delegate void MathDelegate(double x, double y);

		static void Main(string[] args)
		{
			MathDelegate myMathDelegate; // it is ok in examples but in real production code myMathDelegate is not the best name here
			myMathDelegate = Add;
			myMathDelegate += Subtract;
			myMathDelegate += Multiply;
			myMathDelegate += Divide;

			myMathDelegate(10, 5);
		}

		public static void Add(double x, double y)
		{
			Console.WriteLine(x + y);
		}

		public static void Subtract(double x, double y)
		{
			Console.WriteLine(x - y);
		}

		public static void Multiply(double x, double y)
		{
			Console.WriteLine(x * y);
		}

		public static void Divide(double x, double y)
		{
			Console.WriteLine(x / y);
		}
	}
}
