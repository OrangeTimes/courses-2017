using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a C# program which supports calculation of sum for 2 doubles, 
2 integers,
any number of integers and doubles passed in as a parameters (Hint: use params to support multiple arguments) 
*/

namespace HW10_1
{
    class Program
    {
        //Calculation of sum for 2 doubles
        static void GetSumOf2Doubles(double a, double b)
        {
            double sumOf2Doubles = a + b;
            Console.WriteLine(sumOf2Doubles);
            Console.ReadKey();
        }
        //Calculation of sum for 2 integers
        static void GetSumOf2Integers(int a, int b)
        {
            int sumOf2Integers = a + b;
            Console.WriteLine(sumOf2Integers);
            Console.ReadKey();
        }
        //Calculation of any number of integers and doubles passed in as a parameters
        static void GetSumOfMultipleArguments(params double [] doubles)
        {
            int sumOfParams = 0;
            foreach (int i in doubles)
            {
                sumOfParams += i;
            }
            Console.WriteLine(sumOfParams);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
