using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Write a program to get maximum and minimum value of values in predefined array
*/



namespace HW7_2
{
    class HW7_2
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = {1,2,10,4,5};
            Console.WriteLine("Maximum value in this array is {0}", arrayOfNumbers.Max());
            Console.WriteLine("Minimum value in this array is {0}", arrayOfNumbers.Min());
            Console.ReadKey();
        }
    }
}
