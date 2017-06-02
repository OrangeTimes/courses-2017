using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Boolean_Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to check if user input is divisible by some number 
            //also enter by the user, write the result to console. 
            //Example of input: 10 , 2 Output: true


            Console.WriteLine("Please provide two numbers: Number1 and Number 2 to check wether Number 1 is devisible by Number 2.");
            String[] numbers = Console.ReadLine().Split(',');
            int number1 = Convert.ToInt32(numbers [0]);
            int number2 = Convert.ToInt32(numbers[1]);
            bool isDivisible = number1 % number2 == 0;
            Console.WriteLine(isDivisible);
            Console.ReadLine();
        }
    }
}
