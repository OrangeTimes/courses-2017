using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomAnotherProject;


namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
			string myName = Console.ReadLine();
			Console.Write("Username:" + myName);
            Console.WriteLine();
            Console.WriteLine("What is your surname?");
            string mySurName = Console.ReadLine();
            Console.Write("Surname:" + mySurName);
            Console.ReadKey();
        }
        
    }
}
