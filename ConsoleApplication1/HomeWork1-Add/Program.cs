using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling another assembly");
            HomeWork1.TestClass.Test();
            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}
