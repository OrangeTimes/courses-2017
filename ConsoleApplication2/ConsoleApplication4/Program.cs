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
            // Write a program to print out the result of adding, subtracting, multiplying and dividing two numbers  typed by the user. 
            //The remainder of the division must be displayed, too. 
            //Implementation note: to convert user string input to a Int32 value use System.Convert.ToInt32(some text) 
            //Output should look similar to this ( assuming user entered 12 and 3):  12 + 3 = 15  12 - 3 = 9 12 x 3 = 36  12 / 3 = 4 12 % 3 = 0  

            // ask user to provide value 1 and value 2
            Console.Write("Please enter value 1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value 2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            //calling methods to calculate results
            int resultOfAdding = Add(value1, value2);
            int resultOfSubstracting = Substract(value1, value2);
            int resultOfMultiplying = Multiply(value1, value2);
            int resultOfDividing = Divide(value1, value2);
            int remainingResult = Remaining(value1, value2);

            // initiating output strings to have shorter output message
            string outputAddingMessage = $"{value1} + {value2} = {resultOfAdding}";
            string outputSubstractingMessage = $"{value1} - {value2} = {resultOfSubstracting}";
            string outputMultiplyingMessage = $"{value1} * {value2} = {resultOfMultiplying}";
            string outputDividingMessage = $"{value1} / {value2} = {resultOfDividing}";
            string outputRemainingMessage = $"{value1} % {value2} = {remainingResult}";
            
            Console.WriteLine($"{outputAddingMessage} \n{outputSubstractingMessage} \n{outputMultiplyingMessage} \n{outputDividingMessage} \n{outputRemainingMessage}");
            Console.ReadKey();
        }

        // adding methods to add/substract/multiply/divide/show_remaining
        static int Add(int value1, int value2)
        {
            int addingResult = value1 + value2;
            return addingResult;
        }

        static int Substract(int value1, int value2)
        {
            int substractingResult = value1 - value2;
            return substractingResult;
        }

        static int Multiply(int value1, int value2)
        {
            int multiplyingResult = value1 * value2;
            return multiplyingResult;
        }

        static int Divide(int value1, int value2)
        {
            int dividingResult = value1 / value2;
            return dividingResult;
        }

        static int Remaining(int value1, int value2)
        {
            int remainingResult = value1 % value2;
            return remainingResult;
        }
    }
}
