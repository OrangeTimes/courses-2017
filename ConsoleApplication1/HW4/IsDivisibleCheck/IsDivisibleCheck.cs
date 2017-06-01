using System;

namespace IsDivisibleCheck
{
    class IsDivisibleCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value 1");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value 2");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            bool isDivisibleCheck = valueOne % valueTwo == 0;

            Console.WriteLine(isDivisibleCheck);
            Console.ReadKey();
        }
    }
}
