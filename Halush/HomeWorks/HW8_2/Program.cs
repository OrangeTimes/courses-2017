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
            int[,] multiArray = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int dimension1 = multiArray.GetLength(0) - 1;      //Get the first dimension lenght 
            int dimension2 = multiArray.GetLength(1) - 1;      //Get the second dimension lenght
            for (int i = dimension1; i >= 0; i--)              //Iterate through the first dimension in reverse order
            {
                for (int j = dimension2; j >= 0; j--)          //Iterate through the second dimension in reverse order
                {
                    Console.WriteLine(multiArray[i, j]);
                    Console.ReadKey();
                }
            }
        }
    }
}