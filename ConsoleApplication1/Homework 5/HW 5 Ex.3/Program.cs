using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a username: "); // here I check for positive case - when user enters correct username from the first time
            string userName = Console.ReadLine();

            int nameLength = userName.Length;

            while (nameLength == 0 || nameLength > 50)        // here I check for negative case - when user enters incorrect username
            {
                Console.WriteLine("Your username is invalid. Please try again: ");    // and keep him in the loop until he enters correct one
                userName = Console.ReadLine();
                nameLength = userName.Length;
            }
            Console.WriteLine("Your username is correct");
            Console.ReadLine();

        }
    }
}
