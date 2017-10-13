using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_house_with_parameters_Part_2
{
	public class Door
	{
		public double doorHeight;
		public double doorWidth;
		public string doorMaterial;
		public Door(double doorHeight, double doorWidth, string doorMaterial)
		{
			this.doorHeight = doorHeight;
			this.doorWidth = doorWidth;
			this.doorMaterial = doorMaterial;
		}
		public static void outputDoor(Door Door)
		{
			Console.WriteLine($"Door height: {Door.doorHeight} / Door width: {Door.doorWidth} / Door material: {Door.doorMaterial}.");
		}
	}
}
	