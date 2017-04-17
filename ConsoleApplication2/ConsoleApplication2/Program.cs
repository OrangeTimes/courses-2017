using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify the manufacturer of the car you'd like to buy:");
            string carManufacturer = Console.ReadLine();
            // it is often a good practise to split your code into logical blocks separated by empty lines. In this case: after  each ReadLine()
            Console.Write("Please select the model of the car: ");
            string carModel = Console.ReadLine();
            Console.Write("Please specify the year of production: ");
            int carYearOfProduction = Convert.ToInt32(Console.ReadLine());
            Console.Write("Specify the maximum suitable price in dollars: ");
            string carMaxPrice = Console.ReadLine();
            Console.WriteLine("Please confirm the following information is correct. You would like to buy {0} {1}, of {2} year of production, for {3}$.", carManufacturer, carModel, carYearOfProduction, carMaxPrice);
            Console.WriteLine($"Please confirm the following information is correct. You would like to buy {carManufacturer} {carModel}, of {carYearOfProduction} year of production, for {carMaxPrice}.");
            Console.ReadKey();
        }
    }
}
