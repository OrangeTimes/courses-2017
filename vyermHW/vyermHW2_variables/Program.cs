using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Please enter information about your car below:");
            Console.WriteLine("Manufacturer");
            string carManufacturer = Console.ReadLine();
            Console.WriteLine("Provide model of your car:");
            string carModel = Console.ReadLine();
            Console.WriteLine("Provide year of production:");
            int productionYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide price of your car:");
            decimal carPrice = Decimal.Parse(Console.ReadLine());
            // todo: Here it would be better to use double instead. We don't use decimal in most case

            // Variations of code. Option 1:
            string carResult = $"Manufacturer: {carManufacturer}, Model: {carModel}, Year: {productionYear}, Price: {carPrice}";
            Console.WriteLine("Verify that information you provided is correct:");
            Console.WriteLine(carResult);
            Console.ReadKey();

            // Variations of code. Option 2:
            Console.WriteLine("Verify that information you provided is correct:\r\nManufacturer: {0}, Model: {1}, Year: {2}, Price: {3}", carManufacturer, carModel, productionYear, carPrice);
            Console.ReadKey();

            // Variations of code. Option 3:
            Console.WriteLine("Verify that information you provided is correct:\r\nManufacturer: " + carManufacturer + ", Model: " + carModel + ", Year: " + productionYear + ", Price: " + carPrice);
            Console.ReadKey();

        }
        // todo: empty line in line 38 and line 13
    }
}
