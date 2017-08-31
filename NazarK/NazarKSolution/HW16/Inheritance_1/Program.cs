using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// create the game title
			Console.Title = "Need for Speed Eron-Don-Don Edition";

			// get user input
			Console.WriteLine("Select your car type: Press 1 for Bus, Press 2 for Truck, Press 3 for SUV, default is SUV");
			int userInput = Convert.ToInt32(Console.ReadLine());

			// create a car depends on user input
			Car userCar;
			switch (userInput)
			{
				case 1:
					userCar = new Bus();
					break;
				case 2:
					userCar = new Truck();
					break;
				case 3:
				default:
					userCar = new SUV();
					break;
			}

			// print some instruction to user
			Console.WriteLine("\nPress W key to accelerate and S key on keyboard to Brake.\nPress I to show car status and F to get some fuel.");

			// ride a car while there is a fuel
			while (userCar.HasFuel())
			{
				// create bindings for buttons to ride
				ConsoleKey pressedKey = Console.ReadKey().Key;
				Console.WriteLine();

				// ride a car based on pressed key
				switch (pressedKey)
				{
					case ConsoleKey.W:
						userCar.Accelerate();
						break;
					case ConsoleKey.S:
						userCar.Brake();
						break;
					case ConsoleKey.I:
						userCar.PrintCarStatus();
						break;
					case ConsoleKey.F:
						userCar.IncreaseFuel();
						break;
				}
			}

			// print game over message
			Console.WriteLine("\nYou are out of fuel\nGAME OVER\n");
		}
	}
}
