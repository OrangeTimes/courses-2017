using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            string enteredByUser = Console.ReadLine();
            int number = Convert.ToInt32(enteredByUser);
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entered number is odd");
                Console.ReadKey();
            }
            







        }
    }
}
