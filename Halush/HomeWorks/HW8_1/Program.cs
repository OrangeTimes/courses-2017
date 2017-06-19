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

        static double AverageValueOfArrays (int[][] array)
        {
            double sumOfElements = 0;
            double amountOfElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sumOfElements += array[i][j];
                }
                amountOfElements += array[i].Length;
            }
            double averageValue = sumOfElements / amountOfElements;
            return averageValue;
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray = {
               new int[] {1, 2, 3},
               new int[] {4, 5},
               new int[] {6, 7, 8, 9, 10},
               new int[] {11, 12}
            };
            Console.WriteLine(AverageValueOfArrays(jaggedArray));
            Console.ReadKey();
        }
    }
}