using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW3_countoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result 1: -1 + 3 * 5 = {0}", -1 + 3 * 5); //first is multiplying, then adding
            // todo: add whitespace beetween comment sign // and text comment
            // In general it is reccomended to place coment before statement, since having long statement is not good practice.
            Console.WriteLine("Result 2: (24 + 5) % 7 = {0}", (24 + 5) % 7); //added values in brackets, divided by 7 - results in 4, and remainder is 1. result is the remainder
            Console.WriteLine("Result 3: 15 + -4 * 6 / 11 = {0}", 15 + -4 * 6 / 11); //first multiplying and dividing > results in -2 (we count only even number, without decimals); finally we add 15 to -2
            Console.WriteLine("Result 4: 2 + 10 / 6 * 1 - 7 % 2 = {0}", 2 + 10 / 6 * 1 - 7 % 2); // divide 10 by 6 is one (even number only), multiply by one > remains 1. Then 7 % 2 is one (remainder after division). 2 + 1 - 1 = 2.
            Console.ReadKey();
        }
    }
}
