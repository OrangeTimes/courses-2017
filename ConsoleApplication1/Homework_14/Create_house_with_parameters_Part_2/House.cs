using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_house_with_parameters_Part_2
{
	class House
	{
		static void Main(string[] args)
		{
			// create Door
			Door houseDoor = new Door(2.3, 1.5, "Steel");
			//create Window
			Window houseWindow = new Window("Veka", 3, 2.45, 3.5);
			// create Walls
			Wall houseWall1 = new Wall(4.6, 5.6);
			Wall houseWall2 = new Wall(5, 4.6);
			Wall houseWall3 = new Wall(6, 8.9);
			Wall houseWall4 = new Wall(8, 9.9);
			// create Roof
			Roof houseRoof = new Roof("Tiling", "Folded");

			// output house characteristics in Console
			Door.outputDoor(houseDoor);
			Window.outputWindow(houseWindow);
			Wall.outputWalls(houseWall1);
			Wall.outputWalls(houseWall2);
			Wall.outputWalls(houseWall3);
			Wall.outputWalls(houseWall4);
			Roof.outputRoof(houseRoof);
			Console.WriteLine("The house is created!");
			Console.ReadLine();
		}
	}
}
