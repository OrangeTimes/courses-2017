using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //int Example1Result = -1 + 3 * 5;
            //int Example2Result = (24 + 5) % 7;
            //double Example3Result = 15 + -4 * 6 / 11;
            //double Example4Result = 2 + 10 / 6 * 1 - 7 % 2;

            //Console.WriteLine("Example1Result: " + Example1Result);
            //Console.WriteLine("Example2Result: " + Example2Result);
            //Console.WriteLine("Example3Result: " + Example3Result);
            //Console.WriteLine("Example4Result: " + Example4Result);
            //Console.ReadKey();

            //2.
            char again = 'y';
            while (again == 'y')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("Enter first digit:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter second digit:");
                b = Convert.ToDouble(Console.ReadLine());
				// todo it's better to use switch case here
				// todo this complexity is not nesessary since users enter just 2 numbers
				if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("{0} + {1} = {2}.", a, b, total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("{0} - {1} = {2}.", a, b, total);
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("{0} * {1} = {2}.", a, b, total);
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("{0} / {1} = {2}.", a, b, total);
                }
                else
                {
                    Console.WriteLine("Unknown operator.");
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
