using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vyermHW1;

namespace vyermHW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling another assembly");
            TestClass.Test();
            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}
