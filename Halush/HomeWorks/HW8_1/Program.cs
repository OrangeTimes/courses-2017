using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a C# program to get average value of elements in jagged integer array 
*/

namespace HW8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo it is recommnded to aa space in array declaration like {1, 2, 3},
            // Halush Oleh: fixed
            // Jagged array declarationa and initialization
            int[][] jaggedArray = {                                 
               new int[] {1, 2, 3},
               new int[] {4, 5},
               new int[] {6, 7, 8, 9, 10},
               new int[] {11, 12}
            };
            double sumOfElements = 0;
            double amountOfElements = 0;
            // Iterating through each each array of arrays
            for (int i = 0; i < jaggedArray.Length; i++)           
            {
                // Iterating through each element of each array of arrays
                for (int j = 0; j < jaggedArray[i].Length; j++)      
                {
                    // Counting sum of elements
                    sumOfElements += jaggedArray[i][j];            
                }
                // Counting amount of elements in each array of arrays
                amountOfElements += jaggedArray[i].Length;           
            }
            Console.WriteLine("Sum of Elements: {0}", sumOfElements);
            Console.WriteLine("Amount of elements: {0}", amountOfElements);
            Console.WriteLine("Average value of elements: {0}", sumOfElements / amountOfElements);
            Console.ReadKey();
        }
    }
}