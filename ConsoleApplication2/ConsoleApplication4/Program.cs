using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter value 1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value 2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            int resultOfAdding = value1 + value2;
            int resultOfSubstracting = value1 - value2;
            int resultOfMultiplying = value1 * value2;
            int resultOfDividing = value1 / value2;
            int remainingResult = value1 % value2;
            Console.WriteLine($"{value1} + {value2} = {resultOfAdding} \n {value1} - {value2} = {resultOfSubstracting} \n {value1} * {value2} = {resultOfMultiplying} \n {value1} / {value2} = {resultOfDividing} \n {value1} % {value2} = {remainingResult}");
            Console.ReadKey();
        }
    }
}
