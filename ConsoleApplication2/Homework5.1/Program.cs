using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Task 1. 1. Write a program to print out result if number entered by user is odd or even. 
            // If entered number is odd program should print: “Entered number %number% is odd” or “Entered number %number% is even” otherwise.

            Console.Write("Please type in number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string result = CheckNumber(userInput);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string CheckNumber(int userInput)
        {
            string resultMessage;
            if (userInput%2 == 0)
            {
                resultMessage = $"Entered number {userInput} is even";
            }
            else
            {
                resultMessage = $"Entered number {userInput} is odd";
            }
            return resultMessage;
        }
    }
}


