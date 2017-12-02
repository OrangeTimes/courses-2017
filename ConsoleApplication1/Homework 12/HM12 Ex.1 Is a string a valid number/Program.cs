using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM12_Ex._1_Is_a_string_a_valid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckString();
            Console.ReadLine();

        }

        /*
        1. Write a program to check if a string is a valid number (double) using Double.Parse and show corresponding error to user. 
        Try to recover from this exception by asking user for valid input one more time
        */

        /// <summary>
        /// Checking if input string is a valid number (double) using Double.Parse and show corresponding error to user
        /// </summary>
        /// <returns>Double value</returns>
        public static double CheckString()
        {
            double myDouble;
            Console.WriteLine("Please enter string to convert it to double: ");
            try
            {
                myDouble = Double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);  // Converting to double, added System.Globalization.NumberStyles.AllowDecimalPoint as without it method converts incorrectly (e.g. 12,12 to 1212)
                Console.WriteLine("Successfully converted to: " + $"{myDouble}");                                  // Printing out double value 
                return myDouble; 
            }
            catch (Exception)                                                           // Here I catch all exceptions as in the end I would re-throw it
            {
                try                                                                     // another nested try-catch to ensure user has one more chance to enter correct string
                {
                    Console.WriteLine("You have entered incorrect string to convert." + $"\n" + "Please try once more to enter VALID string for convertion: ");
                    myDouble = Double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint);
                    Console.WriteLine("Successfully converted to: " + $"{myDouble}"); // todo: code in both try blockes can be extracted to single new method to avoid code duplication
                    return myDouble;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry, no more tries"+ $"\n");
                    Console.WriteLine(ex.ToString());                                    // printing out exception to console
                    throw;                                                               // rethrowing the exception
                }
            }
            
        }
    }
}
