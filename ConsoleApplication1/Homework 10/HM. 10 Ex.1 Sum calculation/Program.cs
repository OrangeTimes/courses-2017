using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM._10_Ex._1_Sum_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = CalculateSum(23, 444, 54, 67);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        /*
        1. Write a C# program which supports calculation of sum for 2 doubles, 2 integers, any number of integers and doubles passed in as a parameters 
        (Hint: use params to support multiple arguments)
        */

        /// <summary>
        /// Sums all passed values
        /// </summary>
        /// <param name="vals"></param>
        /// <returns>Sum of all values</returns>
  
        public static double CalculateSum(params double [] vals)  //The params keyword lets you specify a method parameter that takes an argument where the number of arguments is variable.
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
    }
}
