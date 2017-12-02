using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a class that will do basic math operation. Make sure the class is static
*/
namespace HW15_1
{
    static class MathOperations
    {
        static public int a = 25;
        static public int b = 5;

        static public void Addition()
        {
            double result = a + b;
            Console.WriteLine(result);
        }

        static public void Subtraction()
        {
            int result = a - b;
            Console.WriteLine(result);
        }

        static public void Division()
        {
            double result = a / b;
            Console.WriteLine(result);
        }

        static public void Multiplication()
        {
            double result = a * b;
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 2 default value. What would you like to do with them?");
            Console.WriteLine("Please choose within '+' or '-' or '/' or '*'");
            string usersInput = Console.ReadLine();
            switch (usersInput)
            {
                case "+":
                    MathOperations.Addition(); // todo: you should 2 numbers to those methods as well
                    break;
                case "-":
                    MathOperations.Subtraction();
                    break;
                case "/":
                    MathOperations.Division();
                    break;
                case "*":
                    MathOperations.Multiplication();
                    break;
                default:
                    Console.WriteLine("You have entered an incorrect value. Please try again.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
