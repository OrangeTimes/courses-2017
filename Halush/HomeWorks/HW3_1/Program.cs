using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double expression1 = -1 + 3 * 5;
            Console.WriteLine("The result of the expression \"-1 + 3 * 5\" is {0}.", expression1);
            double expression2 = (24 + 5) % 7;
            Console.WriteLine("The result of the expression \"(24 + 5) % 7\" is {0}.", expression2);
            double expression3 = 15 + -4 * 6 / 11;
            Console.WriteLine("The result of the expression \"15 + -4 * 6 / 1\" is {0}.", expression3);
            double expression4 = 2 + 10 / 6 * 1 - 7 % 2;
            Console.WriteLine("The result of the expression \"2 + 10 / 6 * 1 - 7 % 2\" is {0}.", expression4);
            Console.ReadKey();
        }
    }
}
