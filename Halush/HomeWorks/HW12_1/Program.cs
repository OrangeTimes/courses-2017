using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to check if a string is a valid number (double) using Double.Parse and show corresponding error to user.
Try to recover from this exception by asking user for valid input one more time
*/

namespace HW12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter 'double' type value:");
                double usersInput = double.Parse(Console.ReadLine());
                Console.WriteLine("You have entered {0}", usersInput);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You have entered an incorrect value that doesn't match 'double' type.");
                Console.WriteLine("Please enter 'double' type value:");
                double usersInput = double.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
