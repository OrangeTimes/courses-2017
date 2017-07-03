using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW3_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the next number:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            // Variations of code. Option 1:
            Console.WriteLine("Here is some magic:");
            Console.WriteLine("{0} + {1} = {2}", userNumberOne, userNumberTwo, userNumberOne + userNumberTwo);
            Console.WriteLine("{0} - {1} = {2}", userNumberOne, userNumberTwo, userNumberOne - userNumberTwo);
            Console.WriteLine("{0} * {1} = {2}", userNumberOne, userNumberTwo, userNumberOne * userNumberTwo);
            Console.WriteLine("{0} / {1} = {2}", userNumberOne, userNumberTwo, userNumberOne / userNumberTwo);
            Console.WriteLine("{0} % {1} = {2}", userNumberOne, userNumberTwo, userNumberOne % userNumberTwo);
            Console.ReadKey();

            // Variations of code. Option 2:
            int mathResultAdd = userNumberOne + userNumberTwo;
            int mathResultDeduct = userNumberOne - userNumberTwo;
            int mathResultMultiply = userNumberOne * userNumberTwo;
            int mathResultDivide = userNumberOne / userNumberTwo;
            int mathResultRemainder = userNumberOne % userNumberTwo;

            Console.WriteLine("Here is some magic:");
            Console.WriteLine("{0} + {1} = {2}", userNumberOne, userNumberTwo, mathResultAdd);
            Console.WriteLine("{0} - {1} = {2}", userNumberOne, userNumberTwo, mathResultDeduct);
            Console.WriteLine("{0} * {1} = {2}", userNumberOne, userNumberTwo, mathResultMultiply);
            Console.WriteLine("{0} / {1} = {2}", userNumberOne, userNumberTwo, mathResultDivide);
            Console.WriteLine("{0} % {1} = {2}", userNumberOne, userNumberTwo, mathResultRemainder);
            Console.ReadKey();
            
            // Variations of code. Option 3:
            Console.WriteLine("Here is some magic:");
            string format = "{0} {1} {2} = {3}";
            Console.WriteLine(format, userNumberOne, "+", userNumberTwo, userNumberOne + userNumberTwo);
            Console.WriteLine(format, userNumberOne, "-", userNumberTwo, userNumberOne - userNumberTwo);
            Console.WriteLine(format, userNumberOne, "*", userNumberTwo, userNumberOne * userNumberTwo);
            Console.WriteLine(format, userNumberOne, "/", userNumberTwo, userNumberOne / userNumberTwo);
            Console.WriteLine(format, userNumberOne, "%", userNumberTwo, userNumberOne % userNumberTwo);
            Console.ReadKey();
        }
    }
}
