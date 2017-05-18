using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 3. 3. Write a program that will read user name and will check if it is a valid one (has more than 0 symbols and less than 50 symbols). 
            // If the input is invalid it should write an error message and prompt for user name again until user enters a valid name.

            Console.Write("Type in username: ");
            string username = Console.ReadLine();
            int usernameLength = username.Length;

            while (usernameLength == 0 || usernameLength > 50)
            {
                Console.WriteLine("Please try again:");                
                username = Console.ReadLine();
                usernameLength = username.Length;                
            }
            Console.WriteLine("Thank You!");
            Console.ReadLine();
        }
    }
}
