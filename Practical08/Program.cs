using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical08
{
	public enum ExponentType
	{
		UseExponent,
		NotUseExponent
	}

	class Program
	{
		static void Main(string[] args)
		{
			double result = Substract(1, 2);
			MethodA();
		}

		public static double Substract(double number1, double number2, ExponentType exponentType)
		{
			return number1 - number2;
		}

		public static double Substract(double number1, double number2)
		{
			return number1 - number2;
		}

		public static int Substract(int number1, int number2)
		{
			return number1 - number2;
		}

		public static long Substract(long number1, long number2)
		{
			return number1 - number2;
		}

		public double Substract(double number1)
		{
			return number1;
		}

		public static void MethodA()
		{
			MethodB();
		}

		public static void MethodB()
		{
			MethodC();
		}

		public static void MethodC()
		{
			int x = 0;
		}
	}
}
