using ChildProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling another assembly");
            TestClass.Test();
            Console.WriteLine("Success");
            Console.ReadKey();
        }
    }
}