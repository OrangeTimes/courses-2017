using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Sum_of_multiple_params
{
	class Program
	{
		// Write a C# program which supports calculation of sum for 2 doubles,
		// 2 integers, any number of integers and doubles passed in as
		// a parameters (Hint: use parameters to support multiple arguments)
		static void Main(string[] args)
		{
			int resultOfIntSum = sumValues(5, 7);
			double resultOfDoubleSum = sumValues(5.5465656, 7.56537567); // 

			int[] intArray = new int[] { 134, 2, 32, 44 };
			int resultOfIntArraySum = sumValues(intArray);

			double[] doubleArray = new double[] { 1.4344345, 4.45645656, 3.3534, 8.5734 };
			double resultOfDoubleArraySum = sumValues(doubleArray);
		}
		static int sumValues(int param1, int param2) // !!!Method name should be in PascallCase
		{
			int sum = param1 + param2; //calculate sum of two int
			return sum; 
		}
		static double sumValues(double param1, double param2) //!!! Method name should be in PascallCase
		{
			double sum = param1 + param2; // calculate sum of two double
			return sum; 
		}
		static int sumValues(params int[] intArray) //!!! Method name should be in PascallCase
		{
			int sum = 0;
			foreach (var number in intArray)
			{
				sum += number; // calculate sum of int array
			}
			return sum; 
		}
		static double sumValues(params double[] doubleArray) //!!! Method name should be in PascallCase
		{
			double sum = 0;
			foreach (var number in doubleArray)
			{
				sum += number; // calculate sum of double array
			}
			return sum; 
		}
	}
}