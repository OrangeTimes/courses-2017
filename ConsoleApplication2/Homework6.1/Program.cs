using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program to get a double value from user. Determine if that number is whole or real number by outputting corresponding message (use casting).
            Console.Write("Please enter value: ");
            double userValue = Convert.ToDouble(Console.ReadLine());

            if (userValue == (int)userValue)
                {
                Console.WriteLine("This is real number.");
            }
            else
            {
                Console.WriteLine("This is decimal number.");
            }
            Console.ReadLine();
        }
    }
}
