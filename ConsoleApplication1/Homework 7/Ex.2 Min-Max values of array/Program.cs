using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2_Min_Max_values_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };  // array initialised and declared
            
            int min = myArray[0];   // declaring variable and assigning it a value of first array element
            int max= myArray[0];    // the same

            Console.WriteLine("To display maximum or minimum element, please type min or max and press Enter");
            string userInput = (Console.ReadLine()).ToLower(); // convert any string to lover case

            if (userInput.Contains("min")) // I could just write userInput == "min", my intention here was to use wildcard but Contains methods seemed like a better choice
            {
                for (int i = 0; i < myArray.Length; i++) // go through each element of the array
                {
                    if (myArray[i] < min) min = myArray[i];  // check whether current element in a loop is lesser than min variable, and if so then assign this lesser value to min
                }
                Console.WriteLine($"Minimum value is {min}");  // prints out result
            }

            else if (userInput.Contains("max"))
            {
                for (int i = 0; i < myArray.Length; i++) // go through each element of the array
                {
                    if (myArray[i] > max) max = myArray[i];  // check whether current element in a loop is greater than max variable, and if so then assign this greater value to max
                }
                Console.WriteLine($"Maximum value is {max}"); // prints out result
            }
            Console.ReadLine();
        }
    }
}
