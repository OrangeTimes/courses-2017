using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program what supports multiple casting abilities for entered value by user.
After entering a value, you should ask about target type. 
Supported target types: are “byte, short, integer, long”. 
If entered target type is supported your program should display result of the cast or unsupported target type message otherwise.

Example of user input and output:
100
integer
100

100.3
double
Unsupported target type
*/

namespace HW6_2
{
    class HW6_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
            string userValue = Console.ReadLine();
            bool isValueProper = Double.TryParse(userValue, out double convertToDouble);     //Verify that user's value can be successfully converted
			// todo: isValueProper == false) is redundant here you can use isValueProper
			while (isValueProper == false)                                                   //Until user's value is incorrect ask him to enter a value again
            {
				Console.WriteLine("Please enter correct value:");
                userValue = Console.ReadLine();
                isValueProper = Double.TryParse(userValue, out convertToDouble);
            }                                                                                //If user enetered a correct value ask him for a type he wants to get
            Console.WriteLine("What is your target type? Please enter type within byte, short, integer, long:");
            string targetType = Console.ReadLine();
            switch (targetType)                                                              //List of types user can choose 
            {
                case "byte":
                    {
                        sbyte byteValue = (sbyte)convertToDouble;
                        Console.WriteLine("Your value after converting to byte is {0}", byteValue);
                        Console.ReadKey();
                        break;
                    }
                case "short":
                    {
                        short shortValue = (short)convertToDouble;
                        Console.WriteLine("Your value after converting to short is {0}", shortValue);
                        Console.ReadKey();
                        break;
                    }
                case "integer":
                    {
                        int intValue = (int)convertToDouble;
                        Console.WriteLine("Your value after converting to integer is {0}", intValue);
                        Console.ReadKey();
                        break;
                    }
                case "long":
                    {
                        long longValue = (long)convertToDouble;
                        Console.WriteLine("Your value after converting to long is {0}", longValue);
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The {0} type is not supported", targetType);
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
}
