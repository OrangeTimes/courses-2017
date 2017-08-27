using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles_triangle
{
    class Program
    {
        static void Main(string[] args)
        {


            IsoscelesTriangle(10);
            IsoscelesTriangle2(10);

            Console.ReadLine();
        }

        /*
        1. Write a program to create isosceles triangle in console by specifying its height.
        Value of height should be passed as command line parameter.
        Example for height of 4:
           *      
          ***     
         *****   
        *******
        */


        public static void IsoscelesTriangle(int height)
        {

            for (int i = 0; i < height; i++)         // to iterate over the entire triangle
            {
                Console.WriteLine();                 // for better visual presentation

                for (int j = height - i; j > 0; j--)  // Here spaces are drawn on the left side to center-allign the asterisks that will be produced by the second loop below
                    Console.Write(" ");

                for (int k = 0; k <= i; k++)         // Drawing asterisks and one space on the right side to center-allign the asterisks
                    Console.Write("*" + " ");

                Console.WriteLine();                 // for better visual presentation
            }
        }



        public static void IsoscelesTriangle2(int height)        // The second way to create isosceles triangle
        {                                                        // NOT SURE WHY IT LOOKS so INDENTED THOUGH  ???
            for (int i = 0; i < height; i++)
            {
                int count = 0;
                for (int k = 0; k <= i; k++)
                { count++; }

                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (count / 2)) + "}", new string('*', count)));

            }
        }

    }
}
