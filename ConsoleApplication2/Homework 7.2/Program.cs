using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program to get maximum and minimum value of values in predefined array 

            int[] myArray = new int[] { 2, 17, 25, 32, 65, 43, 12, 7 };
            
            // Complicated solution:
            //int minValue = myArray[0];
            //foreach (int i in myArray)
            //{
            //    if (i <= minValue)
            //    {
            //        minValue = i;
            //    }
            //}
            //int maxValue = myArray[0];
            //foreach (int i in myArray)
            //{
            //    if (i >= maxValue)
            //    {
            //        maxValue = i;
            //    }
            //}
            //Console.WriteLine($"Minimum value is {minValue}; \r\n maximum value is {maxValue}.");
            //Console.ReadLine();

            //Simple solution:
            Console.WriteLine($"Minimum value is {myArray.Min()}; \r\n maximum value is {myArray.Max()}.");
            Console.ReadLine();
        }
    }
}
