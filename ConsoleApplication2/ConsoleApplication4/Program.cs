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

            // initiating output strings to have shorter output message
            string outputAddingMessage = $"{value1} + {value2} = {resultOfAdding}";
            string outputSubstractingMessage = $"{value1} - {value2} = {resultOfSubstracting}";
            string outputMultiplyingMessage = $"{value1} * {value2} = {resultOfMultiplying}";
            string outputDividingMessage = $"{value1} / {value2} = {resultOfDividing}";
            string outputRemainingMessage = $"{value1} % {value2} = {remainingResult}";

            Console.WriteLine($"{outputAddingMessage} \n{outputSubstractingMessage} \n{outputMultiplyingMessage} \n{outputDividingMessage} \n{outputRemainingMessage}");

            Console.ReadKey();
        }
    }
}
