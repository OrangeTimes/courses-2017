using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Print out all values in reversed order(starting from last element) in jagged or multidimensional array

            int [][] myJaggedArray = { new int[] { 4, 3, 5, 2 }, new int[] { 2, 5, 4, 9, 8, 5, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };

            for (int i = myJaggedArray.Length - 1; i >= 0; i--)
            {
                for (int j = myJaggedArray[i].Length - 1; j >= 0; j--)
                {
                    int number = myJaggedArray[i][j];
                    Console.Write(number);
                }
            }
            Console.ReadLine();          

        }
    }
}
