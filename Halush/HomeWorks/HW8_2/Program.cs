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
        static void Main(string[] args)
        {
            // todo comments should be aligned with other code vertically. Put commnets in empty line as a rule of thumb
            // Halush Oleh: fixed
            // Multidimensional array
            int[,] multiArray = 
            {
                { 1, 2, 3, 4 }, 
                { 5, 6, 7, 8 }, 
                { 9, 10, 11, 12 }, 
                { 13, 14, 15, 16 }
            };
            // Get the first dimension lenght 
            int dimension1 = multiArray.GetLength(0) - 1;
            // Get the second dimension lenght
            int dimension2 = multiArray.GetLength(1) - 1;
            // Iterate through the first dimension in reverse order
            for (int i = dimension1; i >= 0; i--)
            {
                // Iterate through the first dimension in reverse order
                for (int j = dimension2; j >= 0; j--)         
                {
                    Console.WriteLine(multiArray[i, j]);       // todo redundant space below // Halush Oleh: fixed
                }
            }
            Console.ReadKey();


            // Jagged array
            /*
            int[][] jaggedArray = 
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7},
                new int[] {8, 9, 10, 11}
            };
            for (int i = jaggedArray.Length -1; i >= 0; i--)
            {

                for (int j = jaggedArray[i].Length -1; j >= 0; j--)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
            Console.ReadKey();
            */
        }
    }
}