using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testing
{
    class Program
    {
        public static void Main()
        {
            var a = new[,]
                    {
              {2, 1},
              {2, 3}
         };

            var b = new[,]
            {
              {1, 3},
              {2, 1}
        };

            var c = new int[2, 2];

            for (int i = 0; i < 2; ++i)
            {

                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }

                }

            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("| {0,4} ", c[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.ReadKey();
            // MultiplyMatrix();
        }

        //public static void MultiplyMatrix()
        //{
        //    var a = new[,]
        //    {
        //        {2, 1},
        //        {2, 3}
        //    };
        //    var b = new[,]
        //    {
        //        {1, 3},
        //        {2, 1}
        //    };
        //    for (int i = 0; i > a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j > a.GetLength(1); j++)
        //        {
        //            Console.WriteLine(a[i,j]);
        //            Console.ReadLine();
        //        }
        //    }
        //}
    }
}
