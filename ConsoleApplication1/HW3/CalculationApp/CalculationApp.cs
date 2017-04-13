using System;

namespace CalculationApp
{
    class CalculationApp
    {
        static void Main(string[] args)
        {
            int UserNumberOne, UserNumberTwo;

            Console.WriteLine("Enter first number:");
            UserNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            UserNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum first and second values: {UserNumberOne} + {UserNumberTwo} = {UserNumberOne + UserNumberTwo}");
            Console.WriteLine($"Substruct first and second values: {UserNumberOne} - {UserNumberTwo} = {UserNumberOne - UserNumberTwo}");
            Console.WriteLine($"Multiply first and second values: {UserNumberOne} * {UserNumberTwo} = {UserNumberOne * UserNumberTwo}");
            Console.WriteLine($"Divide first and second values: {UserNumberOne} / {UserNumberTwo} = {UserNumberOne / UserNumberTwo}");
            Console.WriteLine($"Show remainder of division for first and second values: {UserNumberOne} % {UserNumberTwo} = {UserNumberOne % UserNumberTwo}");
            Console.ReadKey();
            
            Console.WriteLine("Another representation:");
            Console.WriteLine($"{UserNumberOne} + {UserNumberTwo} = {UserNumberOne + UserNumberTwo}");
            Console.WriteLine($"{UserNumberOne} - {UserNumberTwo} = {UserNumberOne - UserNumberTwo}");
            Console.WriteLine($"{UserNumberOne} * {UserNumberTwo} = {UserNumberOne * UserNumberTwo}");
            Console.WriteLine($"{UserNumberOne} / {UserNumberTwo} = {UserNumberOne / UserNumberTwo}");
            Console.WriteLine($"{UserNumberOne} % {UserNumberTwo} = {UserNumberOne % UserNumberTwo}");
            Console.ReadKey();

        }
    }
}
