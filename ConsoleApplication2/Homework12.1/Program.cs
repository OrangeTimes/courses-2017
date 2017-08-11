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

            Console.Write("Please enter value: ");
            string userInput = Console.ReadLine();

            bool stringIsValid;

            do
            {
                stringIsValid = CheckIfValid(userInput);

                if (stringIsValid == true)
                {
                    Console.WriteLine("Thanks");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Please enter value again: ");
                    userInput = Console.ReadLine();
                    stringIsValid = CheckIfValid(userInput);
                }

            } while (stringIsValid == false);


        }

        static bool CheckIfValid(string userInput)
        {
            try
            {
                if (userInput == "")
                {
                    throw new System.ArgumentException("Response is required.");
                }
                Convert.ToDouble(userInput);
            }
            catch (System.ArgumentException responseRequiredException)
            {
                Console.WriteLine(responseRequiredException.ToString());
                Console.ReadLine();
                return false;
            }
            catch (System.FormatException invalidFormatException)
            {
                Console.WriteLine(invalidFormatException.ToString());
                Console.ReadLine();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return false;
            }
            return true;
        }
    }
}
