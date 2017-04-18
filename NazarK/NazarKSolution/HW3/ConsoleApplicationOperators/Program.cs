using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(-1 + 3 * 5);
            //Console.WriteLine((24 + 5) % 7);
            //Console.WriteLine(15 + -4 * 6 / 11);
            //Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);

            // todo: This is a valid statement, but it is not recommnded to us it as a code convention rule. Move declarations as close to assignment as possible
            Console.Write("Please enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number (bigger than 0): ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // Show results on math operations
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
        }
    }
}
