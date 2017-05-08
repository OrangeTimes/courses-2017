using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class HW4_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Boolean isDivisible = numberOne % numberTwo == 0;
            Console.WriteLine("Is {0} devisilbe by {1}? {2}", numberOne, numberTwo, isDivisible);
            Console.ReadKey();
        }
    }
}
