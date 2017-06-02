using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program to get a double value from user. 
            Determine if that number is whole or real number by outputting corresponding message (use casting).*/


            string exitKey = "exit";

            while (Console.ReadLine() != exitKey)

            {
                Console.WriteLine("Please enter any double number :");

                double inputNumber = Convert.ToDouble(Console.ReadLine());  // receiving double
                if (inputNumber == 0)                                       // checking for "0", as it is both WHOLE and REAL
                {
                    Console.WriteLine("Your number is both WHOLE and REAL");
                }

                else if (inputNumber == (int)inputNumber & inputNumber > 0) // checking for WHOLE number
                {
                    Console.WriteLine("Your number is WHOLE");
                }
                else
                {
                    Console.WriteLine("Your number is REAL");               // "else" flow displays that this is a REAL number
                }
                Console.WriteLine();
                Console.WriteLine("If you want to proceed press Enter");
                Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");
            }
        }
    }
}
