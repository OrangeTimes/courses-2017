using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to print all numbers from -1 to -100 using for loop construction. 
*/
namespace HW5_2
{
    class HW5_2
    {
        static void Main(string[] args)
        {
            int a;
            for (a = -1;  a >= -100; a--)
            {
                Console.WriteLine(a);
                Console.ReadKey();
            }
        }
    }
}
