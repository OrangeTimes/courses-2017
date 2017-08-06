using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_classes_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// get user input with 3 points
			// create point A
			Console.Write("Enter coordinates of point A separated by comma: ");
			string userInput = Console.ReadLine();
			Point PointA = new Point();
			PointA.setFieldsFromString(userInput);

			// create point B
			Console.Write("Enter coordinates of point B separated by comma: ");
			userInput = Console.ReadLine();
			Point PointB = new Point();
			PointB.setFieldsFromString(userInput);

			// create point C
			Console.Write("Enter coordinates of point B separated by comma: ");
			userInput = Console.ReadLine();
			Point PointC = new Point();
			PointC.setFieldsFromString(userInput);

			// create triangle
			Triangle myTriangle = new Triangle(PointA, PointB, PointC);
			// print results
			Console.WriteLine($"Area of the triangle is: {myTriangle.area}; edges are: {myTriangle.edgeA} {myTriangle.edgeB} {myTriangle.edgeC}");
		}
	}

	public struct Point
	{
		public int x;
		public int y;
		public void setFieldsFromString(string input)
		{
			string[] parts = input.Split(',');
			x = Convert.ToInt32(parts[0]);
			y = Convert.ToInt32(parts[1]);
		}
	}
}
