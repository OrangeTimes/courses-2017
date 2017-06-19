using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Print out all values in reversed order(starting from last element) in jagged or multidimensional array 
 */

namespace HW8_2
{
    class Program
    {
        static int GetValuesFromMultyDimensionalArray(int[,] dimensionalArray)
        {

            int dimension1 = dimensionalArray.GetLength(0) - 1;
            int dimension2 = dimensionalArray.GetLength(1) - 1;
            int arraysValues = 0;
            for (int i = dimension1; i >= 0; i--)
            {
                for (int j = dimension2; j >= 0; j--)
                {
                    arraysValues = dimensionalArray[i, j];
                    Console.WriteLine(arraysValues);
                }
            }
            return arraysValues;
        }
        static int GetValuesFromJaggedArray(int[][] jagArray)
        {
            int arraysValues = 0;
            for (int i = jagArray.Length - 1; i >= 0; i--)
            {

                for (int j = jagArray[i].Length - 1; j >= 0; j--)
                {
                    arraysValues = jagArray[i][j];
                    Console.WriteLine(arraysValues);
                }
            }
            return arraysValues;
        }
        static void Main(string[] args)
        {
            int[,] multyDimensionalArray =
            {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 }
            };
            Console.WriteLine(GetValuesFromMultyDimensionalArray(multyDimensionalArray));
            Console.ReadKey();
            int[][] jaggedArray =
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7},
                new int[] {8, 9, 10, 11}
            };
            Console.WriteLine(GetValuesFromJaggedArray(jaggedArray));
            Console.ReadKey();
        }
    }
}