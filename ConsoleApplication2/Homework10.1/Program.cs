using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1.	Write a C# program which supports calculation of sum for 2 doubles, 2 integers, 
            //any number of integers and doubles passed in as a parameters 
            //(Hint: use params to support multiple arguments)

            //double
            Console.Write("please enter double value 1: ");
            double doubleVal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter double value 2: ");
            double doubleVal2 = Convert.ToDouble(Console.ReadLine());

            double doubleRes = CalculateSum(doubleVal1, doubleVal2);
            Console.WriteLine(doubleRes);
            Console.ReadLine();

            // int
            Console.Write("please enter int value 1: ");
            int intVal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter int value 2: ");
            int intVal2 = Convert.ToInt32(Console.ReadLine());

            int intRes = CalculateSum(intVal1, intVal2);
            Console.WriteLine(intRes);
            Console.ReadLine();

            //any number of doubles
            double[] myDoubleArray = new double[] { 1.1, 2.1, 3, 4 };
            double doubleSum = CalculateSum(myDoubleArray);
            Console.WriteLine(doubleSum);
            Console.ReadLine();

            //any number of ints
            int[] myIntArray = new int[] {1, 2, 3, 4};
            int intSum = CalculateSum(myIntArray);
            Console.WriteLine(intSum);
            Console.ReadLine();
			// todo you need a total of 4 methods. 2 values and multiple values for double and for int

        }

        static double CalculateSum(params double[] doubleArray)
        {
            double sum = 0;
            foreach (var number in doubleArray)
            {
                sum += number;
            }
            return sum;
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var number in intArray)
            {
                sum += number;
            }
            return sum;
        }
		// todo: redundant whitespace here
    }
}