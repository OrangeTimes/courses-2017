using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program what supports multiple casting abilities for entered value by user. 
            // After entering a value, you should ask about target type. 
            // Supported target types: are “byte, short, integer, long”. 
            // If entered target type is supported your program should display result of the cast or unsupported target type message otherwise. 
            // Example of user input and output:
            // 100
            // integer 
            //100

            //100.3
            //double 
            //Unsupported target type

            Console.Write("Please enter value: ");
            decimal userValue = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter the desired value type: ");
            string desiredValueType = Console.ReadLine();
            byte byteValue = (byte)userValue;
            short shortValue = (short)userValue;
            int integerValue = (int)userValue;
            long longValue = (long)userValue;

            switch (desiredValueType)
            {
                case "byte":
                    {
                        Console.WriteLine($"{byteValue}");
                        break;
                    }
                case "short":
                    {
                        Console.WriteLine($"{shortValue}");
                        break;
                    }
                case "integer":
                    {
                        Console.WriteLine($"{integerValue}");
                        break;
                    }
                case "long":
                    {
                        Console.WriteLine($"{longValue}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unsupported target type.");
                        break;
                    }
            }
            Console.ReadLine();

        }
    }
}
