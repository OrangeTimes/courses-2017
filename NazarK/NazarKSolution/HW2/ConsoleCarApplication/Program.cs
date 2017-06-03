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
			// get all data from user
			string manufacturer = GetManufacurer();
			string model = GetModel();
			int yearOfManufacture = GetYearOfManufacture();
			double price = GetPrice();
			int numberOfDoors = GetNumberOfDoors();

			// print user input
			Console.WriteLine($"Manufacturer: {manufacturer}, Model: {model}, Year of manufacture: {yearOfManufacture}, Price: {price}, Numder of doors: {numberOfDoors}");
		}

		public static int GetNumberOfDoors()
		{
			Console.Write("Please enter your car number of doors: ");
			return Convert.ToInt32(Console.ReadLine());
		}

		public static double GetPrice()
		{
			Console.Write("Please enter your car price: ");
			double price = Convert.ToDouble(Console.ReadLine());
			return price;
		}

		public static int GetYearOfManufacture()
		{
			// todo: you need to have all code formated in vertical line
			Console.Write("Please enter your car year of manufacture: ");
			int yearOfManufacture = Convert.ToInt32(Console.ReadLine());
			return yearOfManufacture;
		}

		public static string GetModel()
		{
			// todo: I would recommend breaking up logical blocks of code by using empy lines. For example after every ReadLine
			Console.Write("Please enter your car model: ");
			string model = Console.ReadLine();
			return model;
		}

		public static string GetManufacurer()
		{
			// todo: This is a valid statement, but it is not recommnded to us it as a code convention rule. Move declarations as close to assignment as possible
			// in scope this exercise this is correct. But in future using this prefix car in all variables names inside class is not good idea: for example in scope of a class named Car it isn't needed to have variable name: 'carManufacturer'
			// simply 'manufacturer' is enough. So it depends on context
			Console.Write("Hello friend!\nPlease enter your car manufacturer: ");
			string manufacturer = Console.ReadLine();
			return manufacturer;
		}
	}
}
