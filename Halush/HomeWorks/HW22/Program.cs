using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create 4 anonymous methods that perform add/subtract/multiply/divide operation and log the result to console, and have a void return type. 
Create a delegate to store all the anonymous method and later invoke it with concrete numbers
*/

namespace HW22
{
    public delegate double Calculations(int a, int b);

    public class Program
    {
        public static void Main()
        {
            int firstNumber = 2;
            int secondNumber = 5;
            Calculations add = delegate (int a, int b) { return a + b; };
            Calculations substract = delegate (int a, int b) { return a - b; };
            Calculations multiply = delegate (int a, int b) { return a * b; };
            Calculations divide = delegate (int a, int b) { return a / b; };
            Console.WriteLine("Result of addition: {0}", add(firstNumber, secondNumber));
            Console.WriteLine("Result of substruction: {0}", substract(firstNumber, secondNumber));
            Console.WriteLine("Result of multyplycation: {0}", multiply(firstNumber, secondNumber));
            Console.WriteLine("Result of division: {0}", divide(firstNumber, secondNumber));
            Console.ReadKey();
        }
    }
}
