using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to get average value of elements in jagged integer array
            int[][] myJaggedArray = { new int[] {1, 7, 8, 99, 23},
                                      new int[] {4, 6, 8} };
            int sumOfElements = 0;
            int numberOfElements = 0;

            for (int i = 0; i < myJaggedArray[i].Length; i++)
            {
                for (int j = 0; j < myJaggedArray[j].Length; j++])
                {
                    sumOfElements += myJaggedArray[i][j];
                    numberOfElements++;
                }
            }


        }
    }
}
