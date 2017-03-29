using System;
using Project_1;
using Newtonsoft.Json;

namespace Project_2
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
