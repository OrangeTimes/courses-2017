using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ConsoleApplication2
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
