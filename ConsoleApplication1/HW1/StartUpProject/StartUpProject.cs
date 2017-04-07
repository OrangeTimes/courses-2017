using System;
using ChildProject;

namespace StartUpProject
{
    class StartUpProject
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
//Need to add refference "using ConsoleApp1;"
//Need to add NewtonSoft.Json into app