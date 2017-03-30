using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string carManufacturer, carModel;
            int carYearOfManufacture, carPrice, carNumberOfDoors;
            Console.WriteLine("Hello friend!\nPlease enter your car manufacturer:");
            carManufacturer = Console.ReadLine();
            Console.WriteLine("Please enter your car model:");
            carModel = Console.ReadLine();
            Console.WriteLine("Please enter your car year of manufacture:");
            carYearOfManufacture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your car price:");
            carPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your car number of doors:");
            carNumberOfDoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Manufacturer: {0}, Model: {1}, Year of manufacture: {2}, Price: {3}, Numder of doors: {4}", carManufacturer, carModel, carYearOfManufacture, carPrice, carNumberOfDoors);
            Console.ReadLine();
        }
    }
}
