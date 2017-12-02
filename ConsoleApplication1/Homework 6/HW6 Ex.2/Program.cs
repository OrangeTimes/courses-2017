using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program what supports multiple casting abilities for entered value by user. 
            After entering a value, you should ask about target type. 
            Supported target types: are “byte, short, integer, long”. 
            If entered target type is supported your program should display result of the cast or unsupported target type message otherwise.*/

            string exitKey = "exit";
        
                while (Console.ReadLine() != exitKey)

                {
                    Console.WriteLine("Enter any number for conversion");
                    string userInput = Console.ReadLine();

                    Console.WriteLine("Enter cast type - byte, short, integer or long:");
                    string castType = Console.ReadLine();

                    switch (castType)
                    {
                        case "byte":
                            try { Console.WriteLine(Convert.ToByte(userInput)); }  // Sorry for using Exception handling, couldn't resist - now it works smoothly though
                            catch (OverflowException) { goto default; } // todo: goto should be avoided
                            break;

                        case "short":
                            try { Console.WriteLine(Convert.ToInt16(userInput)); }
                            catch (OverflowException) { goto default; }
                            break;

                        case "integer":
                            try { Console.WriteLine(Convert.ToInt32(userInput)); }
                            catch (OverflowException) { goto default; }
                            break;

                        case "long":
                            Console.WriteLine(Convert.ToInt64(userInput));
                            break;

                        default:
                            Console.WriteLine("Unsupported target type");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("If you want to proceed press Enter");
                    Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");
                }
            // todo : redundant space here
        }
    }
}
