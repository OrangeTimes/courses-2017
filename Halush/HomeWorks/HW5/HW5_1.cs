using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program to print out result if number entered by user is odd or even. 
If entered number is odd program should print: “Entered number %number% is odd” or “Entered number %number% is even” otherwise. 
odd - непарний
*/
namespace HW5
{
    class HW5_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
			// todo: use next formatting. Curly brace should begin from new line
			// {
			//
			// }
            // Halush Oleh: fixed
            if (userNumber % 2 != 0)
            {
                Console.WriteLine("Entered number {0} is odd", userNumber);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entered number {0} is even", userNumber);
                Console.ReadKey();
            }
            
        }
    }
}
