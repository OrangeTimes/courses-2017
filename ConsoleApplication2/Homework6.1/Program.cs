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

            //get value from user
            Console.Write("Please enter value: ");
            double userValue = Convert.ToDouble(Console.ReadLine());

            //call method to check if value is real or decimal and print result
            string result = CheckValue(userValue);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string CheckValue(double userInput)
        {
            string messageResult;
            if (userInput == (int)userInput)
            {
               messageResult = "This is real number.";
            }
            else
            {
                messageResult = "This is decimal number.";
            }
            return messageResult;
        }
    }
}
