using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Write a program to create isosceles triangle in console by specifying its height
a.Value of height should be passed as command line parameter
Example for height of 4:         
   *           
  ***         
 *****       
*******
*/

namespace HW11_1
{
    class Program
    {
        public static void Main(string []args)
        {

			// todo there is a more readable solution using more mathematical approach
			// 1 row - 1 asterix (1*2 -1)
			// 2 row - 3 asterixs (2*2 -1)
			// 3 row - 5 asterixs (3*2 -1)
			// so by knowing rows number you can predictably generate a single row using such approach.
			//Write command line parameter into variable
			int triangleHeight = 0;
            foreach (string a in args)
            {
                triangleHeight = Convert.ToInt32(a);
            }
            //Iterate through each row
            for (int i = 1; i <= triangleHeight; i++)
            {
                //Iterate through each value in a row
                for (int j = 1; j <= triangleHeight - 1 + i; j++)
                {
                    //Write spaces before asterisks
                    if (j <= triangleHeight - i)
                    {
                        Console.Write(" ");
                    }
                    //Write asterisks
                    if (j > triangleHeight - i)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
