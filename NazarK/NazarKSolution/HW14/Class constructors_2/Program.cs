using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class Program
	{
		// 2. Create a house using objects like 1 door, 1 window, 4 walls, 1 roof.
		// Create few appropriate properties for each object
		// (for window – width, height, glass thickness etc.)
		// and create house based on them.
		static void Main(string[] args)
		{
			// create array of walls for house
			Wall[] walls = new Wall[] {
				new Wall(4, 4, 6),
				new Wall(5, 5, 7),
				new Wall(4, 4, 6),
				new Wall(5, 5, 7)
			};

			// assemble all parts into house
			House myCustomHouse = new House
			(
				new Roof(1, 2, 3),
				walls,
				new Window(7, 8, 9),
				new Door(10, 11, 12)
			);
		}
	}
}
