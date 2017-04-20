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
            Console.Write("Please enter value 1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter value 2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            
            bool isDivisibleResult = (value1 % value2 == 0);

            Console.WriteLine(isDivisibleResult);
            Console.ReadLine();
        }
    }
}
