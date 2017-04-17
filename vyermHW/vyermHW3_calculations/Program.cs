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
            // todo: System qualifier is not needed here, since you are alreadyaded this namespace in using System - DONE;
            Console.WriteLine("Please enter the next number:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            // Variations of code. Option 1:
            // todo: add whitespace beetween comment sign // and text comment. Here and below - DONE
            Console.WriteLine("Here is some magic:");
            Console.WriteLine("{0} + {1} = {2}", userNumberOne, userNumberTwo, userNumberOne + userNumberTwo);
            Console.WriteLine("{0} - {1} = {2}", userNumberOne, userNumberTwo, userNumberOne - userNumberTwo);
            // todo you will output wrong information. Be carefull with copy-pasted code - DONE
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
            // todo you will output wrong information. Be carefull with copy-pasted code - DONE
            Console.WriteLine("{0} * {1} = {2}", userNumberOne, userNumberTwo, mathResultMultiply);
            Console.WriteLine("{0} / {1} = {2}", userNumberOne, userNumberTwo, mathResultDivide);
            Console.WriteLine("{0} % {1} = {2}", userNumberOne, userNumberTwo, mathResultRemainder);
            Console.ReadKey();
            
            // Variations of code. Option 3:
            // todo: empty line in line 46 is not necessary - DONE
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
