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
			string carBrand, carModel, gearboxType;
			int productionYear, carPrice, maxSpeed;

			Console.WriteLine("Please type the car brand:");
			carBrand = Console.ReadLine();

			Console.WriteLine("Please type the model of the car:");
			carModel = Console.ReadLine();

			Console.WriteLine("Please set the type of gearbox:");
			gearboxType = Console.ReadLine();

			Console.WriteLine("Please type the year of production:");
			productionYear = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("How much should it cost?(specify in $)");
			carPrice = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please type the max car speed (km/h)");
			maxSpeed = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Confirmation - Brand: {0}, Model: {1}, Type of gearbox: {2}, Year of production: {3}, Price: {4}$, Max Speed: {5}km/h", carManufacturer, carModel, gearboxType, productionYear, carPrice, maxSpeed);
			Console.ReadLine();
		}
	}
}