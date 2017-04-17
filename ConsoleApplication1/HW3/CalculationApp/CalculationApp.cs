using System;

namespace CalculationApp
{
    class CalculationApp
    {
        static void Main(string[] args)
        {
            int userNumberOne, userNumberTwo;
            // todo: local variable names are in camelCase - done

            Console.WriteLine("Enter first number:");
            userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum first and second values: {userNumberOne} + {userNumberTwo} = {userNumberOne + userNumberTwo}");
            Console.WriteLine($"Substruct first and second values: {userNumberOne} - {userNumberTwo} = {userNumberOne - userNumberTwo}");
            Console.WriteLine($"Multiply first and second values: {userNumberOne} * {userNumberTwo} = {userNumberOne * userNumberTwo}");
            Console.WriteLine($"Divide first and second values: {userNumberOne} / {userNumberTwo} = {userNumberOne / userNumberTwo}");
            Console.WriteLine($"Show remainder of division for first and second values: {userNumberOne} % {userNumberTwo} = {userNumberOne % userNumberTwo}");
            Console.ReadKey();
            
            Console.WriteLine("Another representation:");
            Console.WriteLine($"{userNumberOne} + {userNumberTwo} = {userNumberOne + userNumberTwo}");
            Console.WriteLine($"{userNumberOne} - {userNumberTwo} = {userNumberOne - userNumberTwo}");
            Console.WriteLine($"{userNumberOne} * {userNumberTwo} = {userNumberOne * userNumberTwo}");
            Console.WriteLine($"{userNumberOne} / {userNumberTwo} = {userNumberOne / userNumberTwo}");
            Console.WriteLine($"{userNumberOne} % {userNumberTwo} = {userNumberOne % userNumberTwo}");
            Console.ReadKey();
        }
    }
}
