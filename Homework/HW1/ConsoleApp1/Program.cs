using System;

namespace ConsoleApp1
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