using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program to get a double value from user. 
Determine if that number is whole or real number by outputting corresponding message (use casting).
*/

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
			
            string userValue = Console.ReadLine();
            // Verify that user's value can be successfully converted
            bool isValueCorrect = Double.TryParse(userValue, out double convertedValue);
            // Until user's value is incorrect ask to enter the value again
            while (!isValueCorrect)                                              
            {
                Console.WriteLine("You entered an incorrect value.");
                Console.WriteLine("Please enter your number:");
                userValue = Console.ReadLine();
                isValueCorrect = Double.TryParse(userValue, out convertedValue);
            }
            // next code block declaration is redundant {}
            // Halush Oleh: fixed
            // When user entered a correct value determine if it is a whole or a real by containing a ","                                                                
            if (userValue.IndexOf(",") >= 0)
                {
                    Console.WriteLine("Your number {0} is real", convertedValue);
                }
                else
                {
                    Console.WriteLine("Your number {0} is whole", convertedValue);
                }
            Console.ReadKey();
        }
    }
}
