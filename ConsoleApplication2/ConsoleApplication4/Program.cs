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

            string outputAddingMessage = $"{value1} + {value2} = {resultOfAdding}";
            string outputSubstractingMessage = $"{value1} - {value2} = {resultOfSubstracting}";
            string outputMultiplyingMessage = $"{value1} * {value2} = {resultOfMultiplying}";
            string outputDividingMessage = $"{value1} / {value2} = {resultOfDividing}";
            string outputRemainingMessage = $"{value1} % {value2} = {remainingResult}";

            Console.WriteLine($"{outputAddingMessage} \n{outputSubstractingMessage} \n{outputMultiplyingMessage} \n{outputDividingMessage} \n{outputRemainingMessage}");
            // todo: it is not recommnded to have such huge sinle statements. Around 150 symbols is optimal. 
            // The problem with long statemnets is that it is hard to see differences in code made during code review if you use side by side comparisson. 
            // In this case it's better to use create 5 strings with result information for output and concatenate them
            // Using multiple console statements here is not the best way if taking into account perfomance considerantion: since create 5 string and concatanete them is faster than 5 Console.WriteLines

            Console.ReadKey();
        }
    }
}
