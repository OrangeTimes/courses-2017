using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task2. Write a program to print all numbers from -1 to -100 using for loop construction.

			// todo: this should be done using for loop
            int i = -100;
            while (i <= -1)
                {
                Console.WriteLine($"{i}", i++);
                    }

			// todo check formatting.
            Console.ReadLine();
        }
    }
}
