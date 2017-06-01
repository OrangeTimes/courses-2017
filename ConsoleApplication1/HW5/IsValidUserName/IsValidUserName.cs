using System;

namespace IsValidUserName
{
    class IsValidUserName
    {
        static void Main(string[] args)
        {
            string errorMessage = "User Name is invalid. Should be more than 0 symbols and less than 50 symbols";
            string validUserName = "Thanks for providing valid User Name";

            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();

            while (userName.Length == 0 || userName.Length > 50)
            {
                Console.WriteLine(errorMessage);
                userName = Console.ReadLine();
            }

            Console.WriteLine(validUserName);
            Console.ReadKey();
        }
    }
}
