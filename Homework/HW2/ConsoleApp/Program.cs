using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Manufacturer;
            string Model;
            string year;
            string price;

            Console.WriteLine("What is the Manufacturer of your car?");
            Manufacturer = Console.ReadLine();
            Console.WriteLine("Manufacturer: " + Manufacturer);

            Console.WriteLine("What is the Model of your car?");
            Model = Console.ReadLine();
            Console.WriteLine("Model: " + Model);

            Console.WriteLine("What is the year of your car?");
            year = Console.ReadLine();
            Console.WriteLine("year: " + year);

            Console.WriteLine("What is the price of your car?");
            price = Console.ReadLine();
            Console.WriteLine("price: " + price);

            Console.WriteLine("Here is the information about your car: " + 
                "Manufacturer: " + Manufacturer + ". " + "Model: " + Model + ". " + 
                "year: " + year + ". " + "price: " + price);
            Console.ReadKey();
        }
    }
}
