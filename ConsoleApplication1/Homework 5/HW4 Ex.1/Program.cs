using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitKey = "exit";

            while (Console.ReadLine() != exitKey)
               
            {
                Console.WriteLine("Please enter any number to check whether it is ODD or EVEN:");
                Console.WriteLine("After receiving result you can close the program by typing word \"exit\" and pressing Enter");

                int inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber % 2 == 0)
                {
                    Console.WriteLine("Your number is EVEN");
                }
                else
                {
                    Console.WriteLine("Your number is ODD");
                }

            }
        }
    }
}
