using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinArrayValue
{
    class MaxMinArrayValue
    {
        static void Main(string[] args)
        {
            int[] definedArray = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };

            Console.WriteLine($"Min value is {definedArray.Min()}");
            Console.WriteLine($"Max value is {definedArray.Max()}");
            Console.ReadKey();

        }
    }
}
