using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
                string exitKey = "exit";

                while (Console.ReadLine() != exitKey)  // Although not needed, but added this to be able to check several numbers (and not just one), 
                                                       // and also added exitKey to exit from the application by typing "exit"

                {
                    Console.WriteLine("Please enter any number to check whether it is ODD or EVEN:");

                    int inputNumber = Convert.ToInt32(Console.ReadLine());

                    if (inputNumber % 2 == 0)         // here it checks for numbers to be ODD or EVEN
                    {
                        Console.WriteLine("Your number is EVEN");
                    }
                    else
                    {
                        Console.WriteLine("Your number is ODD");
                    }
                Console.WriteLine();
                Console.WriteLine("If you want to proceed press Enter");
                Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");

            }
            }
        }
    }

