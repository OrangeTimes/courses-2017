using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADDITION
            int firstNumber;
            int secondNumber;
            Console.WriteLine("ADDITION. Please provide two numbers: " );
            Console.WriteLine("First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine(firstNumber +" + " + secondNumber + " = " + sum);
            Console.WriteLine("Press ENTER key to continue");
            Console.ReadLine();

            // SUBTRACTION
            int firstNumber2;
            int secondNumber2;
            Console.WriteLine("SUBTRACTION. Please provide two numbers: ");
            Console.WriteLine("First Number: ");
            firstNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            secondNumber2 = Convert.ToInt32(Console.ReadLine());
            int sub = firstNumber2 - secondNumber2;
            Console.WriteLine(firstNumber2 + " - " + secondNumber2 + " = " + sub);
            Console.WriteLine("Press ENTER key to continue");
            Console.ReadLine();

            // MULTIPLICATION
            int firstNumber3;
            int secondNumber3;
            Console.WriteLine("MULTIPLICATION. Please provide two numbers: ");
            Console.WriteLine("First Number: ");
            firstNumber3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            secondNumber3 = Convert.ToInt32(Console.ReadLine());
            int mult = firstNumber3 * secondNumber3;
            Console.WriteLine(firstNumber3 + " * " + secondNumber3 + " = " + mult);
            Console.WriteLine("Press ENTER key to continue");
            Console.ReadLine();

            // DIVISION
            int firstNumber4;
            int secondNumber4;
            Console.WriteLine("DIVISION. Please provide two numbers: ");
            Console.WriteLine("First Number: ");
            firstNumber4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            secondNumber4 = Convert.ToInt32(Console.ReadLine());
            int div = firstNumber4 / secondNumber4;
            int rem = firstNumber4 % secondNumber4;
            Console.WriteLine(firstNumber4 + " / " + secondNumber4 + " = " + div);
            Console.WriteLine("Division remainder: " + rem);
            Console.WriteLine("Press ENTER key to CLOSE CONSOLE");
            Console.ReadLine();
        }
    }
}
