using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_3_Cars_Part_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// create Cars
			Car Ford = new Car("Ford", 2017, 40000.60); // !!! variable names should be in camelCase in most code convetions
			Car Kia = new Car("Kia", 2016, 30000.55);
			Car Mercedes = new Car("Mercedes", 2017, 45000.98);

			Car.outputCarsInConsole(Ford); // Methods names should be in PascalCase in most code convetions
			Car.outputCarsInConsole(Kia);
			Car.outputCarsInConsole(Mercedes);
			Console.ReadLine();
		}
	}
}
