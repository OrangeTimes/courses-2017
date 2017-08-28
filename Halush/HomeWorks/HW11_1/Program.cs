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
