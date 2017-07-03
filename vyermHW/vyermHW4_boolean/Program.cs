using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW4_boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number:");
            int userNumberOne = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the next number that is smaller that previous:");
            int userNumberTwo = System.Convert.ToInt32(Console.ReadLine());

            int remainderPresence = userNumberOne % userNumberTwo;
            bool isDivisible;
            isDivisible = remainderPresence < 1;

            Console.WriteLine("Numbers provided are divisible:");
            Console.WriteLine(isDivisible);
            Console.ReadKey();
        }
    }
}
