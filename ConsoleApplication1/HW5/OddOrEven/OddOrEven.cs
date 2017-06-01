using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value which is being checked if it is odd or even: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            if (userValue % 2 == 0)
            {
                Console.WriteLine($"You've entered {userValue}, which is Even");
            }
            else
            {
                Console.WriteLine($"You've entered {userValue}, which is Odd");
            }
            Console.ReadKey();
        }

    }
}
