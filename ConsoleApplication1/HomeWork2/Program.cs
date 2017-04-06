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
            Console.WriteLine("Manufacturer:");
            String CarMan = Console.ReadLine();
            Console.Clear();
                
                //Car model input
            Console.WriteLine("Model:");
            String CarModel = Console.ReadLine();
            Console.Clear();
                
                //Car year input
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

    }
}
