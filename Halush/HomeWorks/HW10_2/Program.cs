using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program which manages books amount. 
You will need init it with starting amount of books. 
And write 2 methods which can increase and decrease this amount. 
(use ref or out to implement this functionality) 
 */

namespace HW10_2
{
    class Program
    {
        //This method increase the amount of books on user's value
        static int IncreaseAmountOfBooks( ref int a)
        {
            Console.WriteLine("Please enter a number you want to increase the amount of books:");
            string usersInput =  Console.ReadLine();
            bool IsUsersInputANumber = Int32.TryParse(usersInput, out int usersNumber);
            while (!IsUsersInputANumber)
            {
                Console.WriteLine("Please enter a number:");
                usersInput = Console.ReadLine();
                IsUsersInputANumber = Int32.TryParse(usersInput, out usersNumber);
            }
            a = a + usersNumber;
            Console.WriteLine("Amount of books after increase is: {0}",a);
            Console.ReadKey();
            return a;
        }
        //This method decrease the amount of books on user's value
        static int DecreaseAmountOfBooks(ref int a)
        {
            Console.WriteLine("Please enter a number you want to decrease the amount of books:");
            string usersInput = Console.ReadLine();
            bool isUsersInputANumber = Int32.TryParse(usersInput, out int usersNumber);
            while (!isUsersInputANumber)
            {
                Console.WriteLine("Please enter a number:");
                usersInput = Console.ReadLine();
                isUsersInputANumber = Int32.TryParse(usersInput, out usersNumber);
            }
            if (usersNumber > a)
            {
                Console.WriteLine("You have only {0} books, you can't decrease them on {1}", a, usersNumber);
                Console.ReadKey();
            }
            else
            {
                a = a - usersNumber;
                Console.WriteLine("Amount of books after decrease is: {0}", a);
                Console.ReadKey();
            }
            return a;
        }

        static void Main(string[] args)
        {
            int startAmountOfBooks = 10;
            Console.WriteLine("If you want to increase the amount of books please enter 1");
            Console.WriteLine("If you want to decrease the amount of books please enter 0");
            string usersInput = Console.ReadLine();
            bool IsUsersInputANumber = Int32.TryParse(usersInput,out int usersNumber);
            while (!IsUsersInputANumber)
            {
                Console.WriteLine("Please enter a number:");
                usersInput = Console.ReadLine();
                IsUsersInputANumber = Int32.TryParse(usersInput, out usersNumber);
            }
            switch (usersNumber)
            {
                case 0:
                    DecreaseAmountOfBooks(ref startAmountOfBooks);
                    break;
                case 1:
                    IncreaseAmountOfBooks(ref startAmountOfBooks);
                    break;
                default:
                    Console.WriteLine("You have to choose from 0 and 1 only.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
