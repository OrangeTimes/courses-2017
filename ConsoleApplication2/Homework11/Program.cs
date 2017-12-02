using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	 Write a program to create isosceles triangle in console by specifying its height 
            //a.Value of height should be passed as command line parameter
            //Example for height of 4:
 /*             *
               ***
              *****
             *******    */

             // ask for triangle height
           Console.Write("Please specify height of triangle: ");
           int height = Convert.ToInt32(Console.ReadLine());
 
            //print rows // todoadd whitespace between // and comment text
            for (int rowNumber = 1; rowNumber <= height; rowNumber++)
            {
                Console.WriteLine(BuildTriangle(height, rowNumber));
            }
            Console.ReadLine();
        }

        static string BuildTriangle(int height, int rowNumber)
        {
            int numberOfDots = rowNumber * 2 - 1;
            int numberOfSpaces = height - rowNumber;
            
            // create instance of stringbuilder to append characters in string
            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.Append(' ', numberOfSpaces);
            myStringBuilder.Append('*', numberOfDots);

            return myStringBuilder.ToString();
        }
         
    }
}
