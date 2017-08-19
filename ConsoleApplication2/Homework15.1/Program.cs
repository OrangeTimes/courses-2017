using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a class that will do basic math operation. Make sure the class is static 
            double val1 = 12;
            double val2 = 6;

            // call methods from static class
            double resultAdding = Calculator.Add(val1, val2);
            double resultSubstracting = Calculator.Substract(val1, val2);
            double resultMultiplying = Calculator.Multiply(val1, val2);
            double resultDividing = Calculator.Divide(val1, val2);

            // print results
            Console.WriteLine($"Result of adding is {resultAdding}," +
                              $"\n\r Result of substracting is {resultSubstracting}," +
                              $"\n\r Result of multiplying is {resultMultiplying}," +
                              $"\n\r Result of dividing is {resultDividing}");
            Console.ReadLine();
        }
    }
}
