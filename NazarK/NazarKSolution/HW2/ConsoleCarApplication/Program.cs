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
            // todo: This is a valid statement, but it is not recommnded to us it as a code convention rule. Move declarations as close to assignment as possible
            // in scope this exercise this is correct. But in future using this prefix car in all variables names inside class is not good idea: for example in scope of a class named Car it isn't needed to have variable name: 'carManufacturer'
            // simply 'manufacturer' is enough. So it depends on context
            Console.WriteLine("Hello friend!\nPlease enter your car manufacturer:");
            string manufacturer = Console.ReadLine();

            // todo: I would recommend breaking up logical blocks of code by using empy lines. For example after every ReadLine
            Console.WriteLine("Please enter your car model:");
            string model = Console.ReadLine();

            // todo: you need to have all code formated in vertical line
            Console.WriteLine("Please enter your car year of manufacture:");
            int yearOfManufacture = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your car price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your car number of doors:");
            int numberOfDoors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Manufacturer: {0}, Model: {1}, Year of manufacture: {2}, Price: {3}, Numder of doors: {4}", manufacturer, model, yearOfManufacture, price, numberOfDoors);
            Console.ReadLine();
        }
    }
}
