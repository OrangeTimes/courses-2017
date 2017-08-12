using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Write a program to check if a string is a valid number (double) using Double.
            // Parse and show corresponding error to user.
            // Try to recover from this exception by asking user for valid input one more time

            // ask for user input
            Console.Write("Please enter value: ");
            string userInput = Console.ReadLine();

            // declare and initiate bool variable
            bool stringIsValid = false;

            // chek if input is a valid double using loop
            while (stringIsValid == false)
            {
                stringIsValid = CheckIfValid(userInput);

                //if input is invalid ask for input again
                if (stringIsValid == false)
                {
                    Console.Write("Please enter value again: ");
                    userInput = Console.ReadLine();
                }
            //if input is valid - print 'Thanks'
            }
            if (stringIsValid == true)
            {
                Console.WriteLine("Thanks");
                Console.ReadLine();
            }
        }

        static bool CheckIfValid(string userInput)
        {
            try
            {
                if (userInput == "")
                {
                    throw new ArgumentException("Response is required.");
                }
                Convert.ToDouble(userInput);
            }
            catch (ArgumentException responseRequiredException)
            {
                Console.WriteLine(responseRequiredException.ToString());
                return false;
            }
            catch (FormatException invalidFormatException)
            {
                Console.WriteLine(invalidFormatException.ToString());
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
