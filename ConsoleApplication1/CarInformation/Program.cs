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
            string manufacturer = Console.ReadLine();

            // todo: new code statment should be vertically aligned with previous statements. Here and below       // DONE
            // todo: Manufacturer --> manufacturer. Local variables names should be in camelCase. Here and below   // DONE
            // todo: according to most code convetions String --> string.                                          // DONE

            Console.WriteLine("Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Year:");
            int year = Convert.ToInt32(Console.ReadLine());  // however, this will throw an exception when alphabetical charecters are input here

            Console.WriteLine("Price (in US dollars):");
            double price = Convert.ToDouble(Console.ReadLine());  // again, this will throw an exception when alphabetical charecters are input here

            Console.WriteLine("Color:");
            string color = Console.ReadLine();

            Console.WriteLine("Fuel consumption (liters per 100 km):");
            int fuelConsumption = Convert.ToInt32(Console.ReadLine()); // will throw an exception when alphabetical charecters are input here

            Console.WriteLine();

            Console.WriteLine("Manufacturer: " + manufacturer + ", " + "Model: " + model + ", " + "Year: " + year + ", " + "Price (in US dollars): " + price + ", " +
                "Color: " + color + ", " + "Fuel consumption (liters per 100 km): " + fuelConsumption);
            Console.ReadLine();

        }

    }
}
