using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First way");
            int x = -1 + 3 * 5;
            Console.WriteLine("x = -1 + 3 * 5 = " + x);  // operator precedence: 1) * 2) Unary - 3) +
            // result = 14
            int y = (24 + 5) % 7;   //  operator precedence: 1) + (because of parentheses) 2) Remainder operator %
            Console.WriteLine("y = (24 + 5) % 7 = " + y);
            // result = 1
            float z = 15 + -4 * 6 / 11;   // operator precedence: 1) Unary - 2) * 3) / 4) +
            Console.WriteLine("z = 15 + -4 * 6 / 11 = " + z);
            // result = 13
            float c = 2 + 10 / 6 * 1 - 7 % 2; // operator precedence: 1) / 2) * 3) % 4) + 5) -
            Console.WriteLine("c = 2 + 10 / 6 * 1 - 7 % 2 = " + c);
            // result = 2
            Console.WriteLine();

            Console.WriteLine("CORRECT WAY OF DOING THIS");
            // reworked this way because in two statements is present division operator (/)

            // -1 + 3 * 5
            int firstNumber1 = -1;
            int secondNumber1 = 3;
            int thirdNumber1 = 5;
            int result1 = firstNumber1 + secondNumber1 * thirdNumber1;
            Console.WriteLine("result1 = -1 + 3 * 5 = " + result1);
            // result = 14

            // (24 + 5) % 7
            int firstNumber2 = 24;
            int secondNumber2 = 5;
            int thirdNumber2 = 7;
            int result2 = (firstNumber2 + secondNumber2) % thirdNumber2;
            Console.WriteLine("result2 = (24 + 5) % 7 = " + result2);
            // result = 1

            //  15 + -4 * 6 / 11
            float firstNumber3 = 15;
            float secondNumber3 = -4;
            float thirdNumber3 = 6;
            float forthNumber3 = 11;
            float result3 = firstNumber3 + secondNumber3 * thirdNumber3 / forthNumber3;
            Console.WriteLine("result3 = 15 + -4 * 6 / 11 = " + result3);
            // result = 12.81818

            //  2 + 10 / 6 * 1 - 7 % 2
            float firstNumber4 = 2;
            float secondNumber4 = 10;
            float thirdNumber4 = 6;
            float forthNumber4 = 1;
            float fifthNumber4 = 7;
            float sixthNumber4 = 2;
            float result4 = firstNumber4 + secondNumber4 / thirdNumber4 * forthNumber4 - fifthNumber4 % sixthNumber4;
            Console.WriteLine("result4 = 2 + 10 / 6 * 1 - 7 % 2 = " + result4);
            // result = 2.666667

            Console.ReadLine();

        }
    }
}
