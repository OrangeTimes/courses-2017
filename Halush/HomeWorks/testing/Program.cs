using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace testing
{
    class Program
    {
        public static void Main()
        {
            int n = 6;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1 + i; j++)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    if (j > n - i)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

