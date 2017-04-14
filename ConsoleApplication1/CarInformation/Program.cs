using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide some info about your car");
            Console.WriteLine(); // added this to display empty line for better visual presentation
            Console.WriteLine("Manufacturer:");
                String Manufacturer = Console.ReadLine();

            Console.WriteLine("Model:");
                String Model = Console.ReadLine();

            Console.WriteLine("Year:");
                int Year = Convert.ToInt32(Console.ReadLine());  // however, this will throw an exception when alphabetical charecters are input here

            Console.WriteLine("Price (in US dollars):");
                double Price = Convert.ToDouble(Console.ReadLine());  // again, this will throw an exception when alphabetical charecters are input here

            Console.WriteLine("Color:");
                String Color = Console.ReadLine();

            Console.WriteLine("Fuel consumption (liters per 100 km):");
                int FuelConsumption = Convert.ToInt32(Console.ReadLine()); // will throw an exception when alphabetical charecters are input here

            Console.WriteLine();

            Console.WriteLine("Manufacturer: " + Manufacturer + ", " + "Model: " + Model + ", " + "Year: " + Year + ", " + "Price (in US dollars): " + Price + ", " +
                "Color: " + Color + ", " + "Fuel consumption (liters per 100 km): " + FuelConsumption);
            Console.ReadLine();


        }
    }
}
