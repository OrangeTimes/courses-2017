using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM9_Ex._1_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods for HOMEWORK #2
            // CarInformation("Some manufacturer", "Some model", 1222, 1212.33, "Some color", 12);
            // CarInfo();

            // Methods for HOMEWORK #3
            // ResultsOfMathOperations();

            // Methods for HOMEWORK #4
            // IsDivisible();

            // Methods for HOMEWORK #5
            //OddOrEven();
            //ValidateUsername();

            // Methods for HOMEWORK #6
            // WholeOrReal();
            // ConvertNmber();

            // Methods for HOMEWORK #7
            // GetDeliveryMethod();
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };  // array initialised and declared
            // MinMaxArrayValue(myArray);
            // StringAsCharArray("I've got something");

            // Methods for HOMEWORK #8

            int[][] myJaggedArray =                                                                     // array initialised and declared
                {   
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30}
            };
            // JaggedAvarageValue(myJaggedArray);

            int[][] jagger =                                                                            // array initialised and declared
                {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
                new int[] { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
            };
            // ReverseArray(jagger);

        }


        // HOMEWORK #2
        /* Create a program to gather all needed information about desired car 
        (Manufacturer, Model, Year, Price and other) from user (use Console) 
        and print out all gathered information in single line (e.g. Manufacturer: AUDI, Year: 2007).*/

        // First way
        // The following void method will just take all the parameters and then display them in the console
        public static void CarInformation(string manufacturer, string model, int year, double price, string color, int fuelConsumption)
        {
            Console.WriteLine($"Manufacturer: {manufacturer}, Model: {model}, Year: {year}, Price (in US dollars): {price}, Color: {color}, Fuel consumption (liters per 100 km): {fuelConsumption}");
            Console.ReadLine();
        }

        // Second way
        // The following void method will prompt user to provide different information about the car and then display it in the console
        public static void CarInfo()
        {
            // prompt user to fill car manufacturer
            Console.Write("Please provide manufacturer of your car: ");
            string manufacturer = Console.ReadLine();
            
            // prompt user to fill car model
            Console.Write("Please provide model of your car: ");
            string model = Console.ReadLine();

            // prompt user to fill car year
            Console.Write("Please provide year of your car: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // prompt user to fill car price
            Console.Write("Please provide price of your car: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // prompt user to fill car color
            Console.Write("Please provide color of your car: ");
            string color = Console.ReadLine();

            // prompt user to fill car fuel consumption
            Console.Write("Please provide fuel consumption of your car: ");
            int fuelConsumption = Convert.ToInt32(Console.ReadLine());

            // print out the result string
            Console.WriteLine($"Manufacturer: {manufacturer}, Model: {model}, Year: {year}, Price (in US dollars): {price}, Color: {color}, Fuel consumption (liters per 100 km): {fuelConsumption}");
            Console.ReadLine();
        }

        // HOMEWORK #3

        /* 2. Write a program to print out the result of adding, subtracting, multiplying and dividing two numbers  typed by the user. 
        The remainder of the division must be displayed, too. 
        Implementation note: to convert user string input to a Int32 value use System.Convert.ToInt32(some text) 
        Output should look similar to this ( assuming user entered 12 and 3):  
        12 + 3 = 15  
        12 - 3 = 9 
        12 x 3 = 36  
        12 / 3 = 4 
        12 % 3 = 0 
        */

        // The following void method - ResultsOfMathOperations - prompts user to provide two numbers, 
        // and then prints out results of math operations that were performed on those numbers
        public static void ResultsOfMathOperations() 
        {
            Console.Write("Please provide first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please provide second number (bigger than 0): ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            Console.ReadLine();
        }

        // HOMEWORK #4

        /* Write a program to check if user input is divisible by some number also entered by the user, 
        write the result to console. 
        Example of input: 10 , 2 Output: true */

        // The following method - IsDivisible - prompts user to provide two numbers, 
        // and then prints out bool result (true or false)
        public static void IsDivisible ()
        {
            Console.WriteLine("Please provide two numbers: Number1, Number 2 to check wether Number 1 is devisible by Number 2.");
            String[] numbers = Console.ReadLine().Split(',');
            int number1 = Convert.ToInt32(numbers[0]);
            int number2 = Convert.ToInt32(numbers[1]);
            bool isDivisible = number1 % number2 == 0;
            Console.WriteLine(isDivisible);
            Console.ReadLine();
        }

        // HOMEWORK #5

        /* 1. Write a program to print out result if number entered by user is odd or even. 
        If entered number is odd program should print: “Entered number %number% is odd” 
        or “Entered number %number% is even” otherwise. */

        // The following void method - OddOrEven - prompts user to provide a number, 
        // and then prints out results whether this number is odd or even
        public static void OddOrEven()
        {
            string exitKey = "exit";

            while (Console.ReadLine() != exitKey)  // Although not needed, but added this to be able to check several numbers (and not just one), 
                                                   // and also added exitKey to exit from the application by typing "exit"

            {
                Console.WriteLine("Please enter any number to check whether it is ODD or EVEN:");

                int inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber % 2 == 0)         // here it checks for numbers to be ODD or EVEN
                {
                    Console.WriteLine("Your number is EVEN");
                }
                else
                {
                    Console.WriteLine("Your number is ODD");
                }
                Console.WriteLine();
                Console.WriteLine("If you want to proceed press Enter");
                Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");
            }

        }

        /* 3. Write a program that will read user name and will check if it is a valid one (has more than 0 symbols and less than 50 symbols). 
        If the input is invalid it should write an error message and prompt for user name again until user enters a valid name. */

        // The following void method - ValidateUsername - prompts user to provide a username, 
        // and then checks if it is a valid one (has more than 0 symbols and less than 50 symbols) and prints out results
        public static void ValidateUsername()
            {
            Console.WriteLine("Please provide a username: "); // here I check for positive case - when user enters correct username from the first time
            string userName = Console.ReadLine();
            int nameLength = userName.Length;

            while (nameLength == 0 || nameLength > 50)        // here I check for negative case - when user enters incorrect username
            {
                Console.WriteLine("Your username is invalid. Please try again: ");    // and keep him in the loop until he enters correct one
                userName = Console.ReadLine();
                nameLength = userName.Length;
            }
            Console.WriteLine("Your username is correct");
            Console.ReadLine();
            }

        // HOMEWORK #6
        /* 1. Write a program to get a double value from user. 
        Determine if that number is whole or real number by outputting corresponding message (use casting).*/

        // The following void method - WholeOrReal - prompts user to provide a number, 
        // and then checks if that number is whole or real number and prints out results
        public static void WholeOrReal()
        {
            string exitKey = "exit";

            while (Console.ReadLine() != exitKey)

            {
                Console.WriteLine("Please enter any double number :");

                double inputNumber = Convert.ToDouble(Console.ReadLine());  // receiving double
                if (inputNumber == 0)                                       // checking for "0", as it is both WHOLE and REAL
                {
                    Console.WriteLine("Your number is both WHOLE and REAL");
                }

                else if (inputNumber == (int)inputNumber & inputNumber > 0) // checking for WHOLE number
                {
                    Console.WriteLine("Your number is WHOLE");
                }
                else
                {
                    Console.WriteLine("Your number is REAL");               // "else" flow displays that this is a REAL number
                }
                Console.WriteLine();
                Console.WriteLine("If you want to proceed press Enter");
                Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");
            }
        }

        /* 2. Write a program what supports multiple casting abilities for entered value by user. 
        After entering a value, you should ask about target type. 
        Supported target types: are “byte, short, integer, long”. 
        If entered target type is supported your program should display result of the cast or unsupported target type message otherwise.*/

        // The following void method - ConvertNmber - prompts user to provide any number, 
        // and then converts that number into a type that user selects and prints out results
        public static void ConvertNmber()
        {
            string exitKey = "exit";

            while (Console.ReadLine() != exitKey)

            {
                Console.WriteLine("Enter any number for conversion");
                string userInput = Console.ReadLine();

                Console.WriteLine("Enter cast type - byte, short, integer or long:");
                string castType = Console.ReadLine();

                switch (castType)
                {
                    case "byte":
                        try { Console.WriteLine(Convert.ToByte(userInput)); } 
                        catch (Exception) { goto default; }
                        break;

                    case "short":
                        try { Console.WriteLine(Convert.ToInt16(userInput)); }
                        catch (Exception) { goto default; }
                        break;

                    case "integer":
                        try { Console.WriteLine(Convert.ToInt32(userInput)); }
                        catch (Exception) { goto default; }
                        break;

                    case "long":
                        Console.WriteLine(Convert.ToInt64(userInput));
                        break;

                    default:
                        Console.WriteLine("Unsupported target type");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("If you want to proceed press Enter");
                Console.WriteLine("If you want to close the program type word \"exit\" and press Enter");
            }
        }

        // HOMEWORK #7
        /* 
        1. You are developing postal delivery application
        write a program to get info of delivery method and
        display it using enums. (User input can be provided as number)  
        */
        public enum deliveryMethod
        {
            First_class_mail,
            Second_class_mail,
            Third_class_mail,
            Forth_class_mail,
            Priority_mail,
            Express_mail,
            Certified_mail,
            Return_to_recipient,
            Registered_mail,
            Overnight_delivery
        }

        // The following void method - GetDeliveryMethod - prompts user to provide any number (index) from 0 to 9 of an element in enum, 
        // and then prints out string value of that selected enum element

        public static deliveryMethod GetDeliveryMethod()
        {
            Console.Write("Choose postal delivery method (from 0 to 9): ");
            // from 0 to 9 - because enum's items are indexed from 0
            deliveryMethod userInput = (deliveryMethod)Convert.ToInt32(Console.ReadLine());
            // I create a variable "userInput" of enum type - "deliveryMethod"
            // Receive user input, convert it to int (as ReadLine returns string), ad cast it to enum type - "deliveryMethod" (int that was returned is treated like index of certain element of enum)
            Console.Write($"Your delivery method is {userInput}");
            // Returns variable value to console
            Console.ReadLine();
            return userInput;
        }


        /*
        2. Write a program to get maximum and minimum value of values in predefined array
        */

        // The following void method - MinMaxArrayValue - takes an array as a parameter, 
        // and then prints out min or max element of an array

        public static void MinMaxArrayValue(int[] myArray)
        {
            int min = myArray[0];   // declaring variable and assigning it a value of first array element
            int max = myArray[0];    // the same

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

        /*
        3. Write each char in predefined string in new line in console (treat string as a char array it supports it out of the box). 
        */

        // The following void method - StringAsCharArray - takes any string as a parameter, 
        // converts that string to char array and then prints out each char in predefined string in new line in console
        public static void StringAsCharArray(string predefinedString)
        {
            char[] myStringArray = predefinedString.ToCharArray(); // declare char array and populate it with predefinedString (that is being converted to char array)
            foreach (char i in myStringArray) // loop through each char
            {
                Console.WriteLine($"{i}");    // prints out char

            }
            Console.ReadLine();
        }

        // HOMEWORK #8
        // 1. Write a C# program to get average value of elements in jagged integer array


        // The following void method - JaggedAvarageValue - takes a jagged array as a parameter, 
        // and then prints out avarage value of of that array

        public static void JaggedAvarageValue(int[][] jaggedArray) 
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < jaggedArray.Length; i++)      // to iterate over jagged array
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    count++;                             // to find count of elements in jagged array
                    sum += jaggedArray[i][j];                 // to find sum of elements in jagged array
                }
            }

            double avarage = sum / count;


            Console.WriteLine("\n" + "Avarage number in Jagged array is: " + avarage);


            Console.ReadLine();
        }

        // 2. Print out all values in reversed order(starting from last element) in jagged or multidimensional array

        // The following void method - ReverseArray - takes a jagged array as a parameter, 
        // and then prints out all values in reversed order(starting from last element)

        public static void ReverseArray(int [][] someJaggedArray)
        {
            for (int i = someJaggedArray.Length - 1; i >= 0; i--)      // to iterate over jagged array in reverse
            {
                Console.WriteLine();
                for (int j = someJaggedArray[i].Length - 1; j >= 0; j--)
                {
                    Console.Write("\n" + someJaggedArray[i][j]);
                }
            }

            Console.ReadLine();
        }

    }
}

