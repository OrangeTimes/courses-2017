using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_15_Ex._1_Basic_math_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            1. Write a class that will do basic math operation. 
               Make sure the class is static
            */

            MathOperations.Add(600, 10, 6, 5);
            Console.WriteLine("Add result = " + MathOperations.result);

            MathOperations.Subtract(600, 10, 6, 5);
            Console.WriteLine("Subtract result = " + MathOperations.result);

            MathOperations.Divide(600, 10, 6, 5);
            Console.WriteLine("Divide result = " + MathOperations.result);

            MathOperations.Multiply(600, 10, 6, 5);
            Console.WriteLine("Multiply result = " + MathOperations.result);

            Console.ReadLine();

        }
    }
}
