using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_3_Cars_Part_1
{
	class Car
	{
		private string manufacturer;
		private int year;
		private double price;

		// Constructor:
		public Car(string manufacturer, int year, double price)
		{
			// Using this to qualify the fields: manufacturer, year, price.
			this.manufacturer = manufacturer;
			this.year = year;
			this.price = price;
		}
		// output the created Cars
		public static void outputCarsInConsole (Car Car)
		{
			Console.WriteLine($"Car Manufacturer: {Car.manufacturer} / year: {Car.year} / price: {Car.price}$.");
		}
	}
}
