using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class CarInfo
    {
        static void Main(string[] args)
        {
            //Car manufacturer input
            // todo: text should be separated by whitespace in comment: like // comment
            Console.WriteLine("Manufacturer:");
            String CarMan = Console.ReadLine();
            // todo: as a general code convetion rule use string instead String. This is identical, but most all code convetions use string instead
            // todo: variables should be named using camelCase
            Console.Clear();

            //Car model input
            // todo:comments should be aligned with next statement after them
            Console.WriteLine("Model:");
            String CarModel = Console.ReadLine();
            Console.Clear();
                
                //Car year input
            // todo:comments should be aligned with next statement
            Console.WriteLine("Year:");
            String CarYear = Console.ReadLine();
            Console.Clear();
                
                //Car price input
            Console.WriteLine("Price: ($)");
            String CarPrice = Console.ReadLine();
            Console.Clear();
                
                //Describing the issue
            Console.WriteLine("Please describe a problem:");
            String TechSubmission = Console.ReadLine();
            Console.Clear();
                
                //Showing the results
            Console.Write("Manufacturer: " + CarMan + " | " + "Model: " + CarModel + " | " + "Year: " + CarYear + " | " + "Price: " + CarPrice + " $ " + " | " + "Issue: " + TechSubmission);
            Console.ReadKey();
        }

    } // todo: line 46 is redundant
}
