using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# program to print out results of the following operations. 
            //Investigate why you received such results, using the operator precedence:  
            //•-1 + 3 * 5  •(24+5) % 7  •15 + -4*6 / 11  •2 + 10 / 6 * 1 - 7 % 2  

            //call methods to calculate results and print them

            int expressionResult1 = CalculateExpression1();
            Console.WriteLine($"a + b * c = {expressionResult1}");
            
            int expressionResult2 = CalculateExpression2();
            Console.WriteLine($"d + c % e = {expressionResult2}");

            int expressionResult3 = CalculateExpression3();
            Console.WriteLine($"f + g * h / i = {expressionResult3}");

            int expressionResult4 = CalculateExpression4();
            Console.WriteLine($"j + k / h * l - e % j = {expressionResult4}");
            Console.ReadLine();

        }
        //add methods to calculate expressions results
        static int CalculateExpression1(int a = -1, int b = 3, int c = 5)
        {
            int expressionResult1 = a + b * c;
            return expressionResult1;
        }

        static int CalculateExpression2(int c = 5, int d = 24, int e = 7)
        {
            int expressionResult2 = d + c % e;
            return expressionResult2;
        }

        static int CalculateExpression3(int f = 15, int g = -4, int h = 6, int i = 11)
        {
            int expressionResult3 = f + g * h / i;
            return expressionResult3;
        }

        static int CalculateExpression4(int e = 7, int h = 6, int j = 2, int k = 10, int l = 1)
        {
            int expressionResult4 = j + k / h * l - e % j;
            return expressionResult4;
        }
        

    }
}
