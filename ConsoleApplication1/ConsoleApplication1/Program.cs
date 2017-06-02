using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationRoman2
{
	class Program
	{
		static void Main(string[] args)
		{
            // hello
            // ryaremko
            Console.WriteLine("What is your name");
            long MyName = Convert.ToUInt32(Console.ReadLine());
            // you solution doesn't compile because of errors. You shouldn't submit code to repository in non compilable state
            // Roman: corrected this 
            // Note: This wasn't in scope of any HW, just was practicing ...
            Console.Write("username" + MyName);
            Console.ReadKey();
            


		}
	}
}
