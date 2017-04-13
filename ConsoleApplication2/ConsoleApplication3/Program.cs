using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b = 3;
            int c = 5;

            int expressionResult1 = a + b * c;
            Console.WriteLine($"{a} + {b} * {c} = {expressionResult1}");
            Console.ReadKey();

            int d = 24;
            int e = 7;

            int expressionResult2 = (d + c) % e;
            Console.WriteLine($"({d} + {c}) % {e} = {expressionResult2}");
            Console.ReadKey();

            int f = 15;
            int g = -4;
            int h = 6;
            int i = 11;

            int expressionResult3 = f + g * h / i;
            Console.WriteLine($"{f} + {g} * {h} / {i} = {expressionResult3}");
            Console.ReadKey();

            int j = 2;
            int k = 10;
            int l = 1;

            int expressionResult4 = j + k / h * l - e % j;
            Console.WriteLine($"{j} + {k} / {h} * {l} - {e} % {j} = {expressionResult4}");
            Console.ReadKey();
        }
    }
}
