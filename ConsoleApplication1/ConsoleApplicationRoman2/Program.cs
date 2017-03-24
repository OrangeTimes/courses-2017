using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationRoman; 

// added reference to previous project - ControlApplicationRoman to make available method Test()

namespace ConsoleApplicationRoman2
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
