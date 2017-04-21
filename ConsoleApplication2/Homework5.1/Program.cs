using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. 1. Write a program to print out result if number entered by user is odd or even. 
            // If entered number is odd program should print: “Entered number %number% is odd” or “Entered number %number% is even” otherwise.

            Console.Write("Please type in number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if ((userInput % 2) == 0)
            {
                Console.WriteLine($"Entered number {userInput} is even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Entered number {userInput} is odd");
                Console.ReadLine();
            }
        }
    }
}


