using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Imagine a situation that you are not allowed to use public constructor to create new class
            // (you only have a private one). 
            //Use instead static method to do so.

            double cashSum = 200;
            double salary = 1000;

            Cash myCash = Cash.Create(salary, cashSum);
            Console.WriteLine($"object - {myCash.ToString()}");
            Console.ReadLine();
        }
    }
}
