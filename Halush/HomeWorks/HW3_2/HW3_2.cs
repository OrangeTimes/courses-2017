using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class HW3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", numberOne, numberTwo, numberOne + numberTwo);
            Console.WriteLine("{0}-{1}={2}", numberOne, numberTwo, numberOne - numberTwo);
            Console.WriteLine("{0}*{1}={2}", numberOne, numberTwo, numberOne * numberTwo);
            Console.WriteLine("{0}/{1}={2}", numberOne, numberTwo, numberOne / numberTwo);
            Console.WriteLine("{0}%{1}={2}", numberOne, numberTwo, numberOne % numberTwo);
            Console.ReadKey();
        }
    }
}
