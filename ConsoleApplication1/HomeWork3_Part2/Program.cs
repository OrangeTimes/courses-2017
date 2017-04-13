using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int num1;
            int num2;
            int num3;
            int num4;

            //Adding numbers typed by the user.

            Console.WriteLine("Let's do some adding:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            num1 = a + b;
            Console.WriteLine(a + " + " + b + " = " + "{0}", num1);
            Console.WriteLine("U got your numbers. Now press enter to go next");
            Console.ReadLine();
            Console.Clear();

            //Subtracting numbers typed by the user.
            Console.WriteLine("Let's do some subtracting:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            num2 = a - b;
            Console.WriteLine(a + " - " + b + " = " + "{0}", num2);
            Console.WriteLine("U got your numbers. Now press enter to go next");
            Console.ReadLine();
            Console.Clear();

            //Multiplying  numbers typed by the user.
            Console.WriteLine("Let's do some multiplying:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            num3 = a * b;
            Console.WriteLine(a + " * " + b + " = " + "{0}", num3);
            Console.WriteLine("U got your numbers. Now press enter to go next");
            Console.ReadLine();
            Console.Clear();

            //Dividing numbers typed by the user.
            Console.WriteLine("Let's do some dividing:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            num4 = a / b;
            Console.WriteLine(a + " / " + b + " = " + "{0}", num4);
            Console.WriteLine("U got your numbers. Now press enter to go next");
            Console.ReadLine();
            Console.Clear();

            //Displaying all nums
            Console.WriteLine("Your results from all previous equations: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.ReadLine();
        }
    }
}
