using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Use Aggregate function to get minimum and maximum value of predefined collection of numbers
2. Using Where method find all numbers that are divisible by 2
3. Using Select method transform numbers to string representation with 2 number precision e.g. “2.00”(check ToString() documentation to get more info)
*/

namespace HW23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double>() { 5.777, 7, 1, 4, 10.101, 33.333 };
            //Min and Max values of a collection
            var minValueOfCollection = myList.Aggregate((start, end) => start - end);
            var maxValueOfCollection = myList.Aggregate((start, end) => start + end);
            //Numbers divisible by 2
            var divisibleBy2 = myList.Where(x => x % 2 == 0).ToList();
            //String representation with 2 numbers precision
            var twoNumbersPrecision = myList.Select(x => x.ToString("F")).ToList();
            Console.WriteLine("Min value of collection: {0}", minValueOfCollection);
            Console.WriteLine("Max value of collection: {0}", maxValueOfCollection);
            Console.ReadKey();
        }
    }
}
