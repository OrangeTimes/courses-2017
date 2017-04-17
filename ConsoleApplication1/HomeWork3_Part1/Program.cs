using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = -1 + 3 * 5;
            int b = (24 + 5) % 7;
            int c = 15 + -4 * 6 / 11;
            int d = 2 + 10 / 6 * 1 - 7 % 2;

            Console.WriteLine("Here are the outcomes: a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
            Console.ReadLine();
            // todo: line 13 is not needed
        }
    }
}
