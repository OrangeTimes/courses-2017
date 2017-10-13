using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_house_with_parameters_Part_2
{
	class Wall
	{
		public double wallHeight;
		public double wallWidth;
		public Wall(double wallHeight, double wallWidth)
		{
			this.wallHeight = wallHeight;
			this.wallWidth = wallWidth;
		}
		public static void outputWalls(Wall Wall)
		{
			Console.WriteLine($"Wall height: {Wall.wallHeight} / Wall width: {Wall.wallWidth}.");
		}
	}
}
