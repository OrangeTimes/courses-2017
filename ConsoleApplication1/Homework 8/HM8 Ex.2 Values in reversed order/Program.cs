using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM8_Ex._2_Values_in_reversed_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myJaggedArray = {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
                new int[] { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
            };



            for (int i = myJaggedArray.Length - 1; i >= 0; i--)      // to iterate over jagged array in reverse
            {
                Console.WriteLine();
                for (int j = myJaggedArray[i].Length - 1; j >= 0; j--)
                {
                    Console.Write("\n" + myJaggedArray[i][j]);
                }
            }

            Console.ReadLine();

        }
    }
}

