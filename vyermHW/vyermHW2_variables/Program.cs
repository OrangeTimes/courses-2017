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
            string carManufacturer;
            string carModel;
            int productionYear;
            decimal carPrice;
            
            Console.WriteLine("Please enter information about your car below:");
            Console.WriteLine("Manufacturer");
            carManufacturer = Console.ReadLine();
            Console.WriteLine("Provide model of your car:");
            carModel = Console.ReadLine();
            Console.WriteLine("Provide year of production:");
            productionYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide price of your car:");
            carPrice = Decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Verify that information you provided is correct:\nManufacturer: " + carManufacturer + ", Model: " + carModel + ", Year: " + productionYear + ", Price: " + carPrice);
            //Console.WriteLine("Verify that information you provided is correct: \r\n Manufacturer: {0}, Model: {1}, Year: {2}, Price: {3}", carManufacturer, carModel, productionYear, carPrice);
            string carResult = $"Manufacturer: {carManufacturer}, Model: {carModel}, Year: {productionYear}, Price: {carPrice}";
            Console.WriteLine("Verify that information you provided is correct:");
            Console.WriteLine(carResult);
            Console.ReadLine();
        }
    }
}
