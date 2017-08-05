using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to check if user input is divisible by some number also enter by the user, write the result to console. Example of input: 10 , 2 Output: true

            // ask user for input of values 1 & 2, convert user input to int

            Console.Write("Please enter value 1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter value 2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            
            //call method to show result if values are divisible and print result
            bool isDivisibleResult = IsDivisible(value1, value2);
            Console.WriteLine(isDivisibleResult);
            Console.ReadLine();
        }

        // method to calculate if values are divisible
        static bool IsDivisible(int value1, int value2)
        {
            bool isDivisibleResult = (value1 % value2 == 0);
            return isDivisibleResult;
        }
    }
}
