using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM8_Ex._1_Avarage_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagger = {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30}
            };

            int count = 0;
            int sum = 0;

            for (int i = 0; i < jagger.Length; i++)      // to iterate over jagged array
            {
                for (int j = 0; j < jagger[i].Length; j++)
                {
                    count++;                             // to find count of elements in jagged array
                    sum += jagger[i][j];                 // to find sum of elements in jagged array
                }
            }

            double avarage = sum / count;


            Console.WriteLine("\n" + "Avarage number in Jagged array is: " + avarage);


            Console.ReadLine();



        }
    }
}
