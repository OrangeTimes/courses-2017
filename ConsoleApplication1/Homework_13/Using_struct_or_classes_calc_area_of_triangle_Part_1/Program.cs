using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that will use coordinates of 3 points entered by user and calculate area of triangle created by those 3 dots.
// Use structs or classes(Point, Triangle) in your implementation.

namespace Using_struct_or_classes_calc_area_of_triangle_Part_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//create pointA and assign the coordinates from the console
			Console.WriteLine("Specify the coordinates of pointA (separate by comma): ");
			string pointAcoordinates = Console.ReadLine();
			Point pointA = new Point();
			pointA.StringAsCoordinates(pointAcoordinates);

			//create pointB and assign the coordinates from the console
			Console.WriteLine("Specify the coordinates of pointB (separate by comma): ");
			string pointBcoordinates = (Console.ReadLine());
			Point pointB = new Point();
			pointB.StringAsCoordinates(pointBcoordinates);

			//create pointC and assign the coordinates from the console
			Console.WriteLine("Specify the coordinates of pointC (separate by comma): ");
			string pointCcoordinates = (Console.ReadLine());
			Point pointC = new Point();
			pointC.StringAsCoordinates(pointCcoordinates);

			// create three sides of the triangle
			TriangleSides sideAB = new TriangleSides(); 
			sideAB.CalculateSideAB(pointA, pointB);

			TriangleSides sideBC = new TriangleSides(); // You don't need to construct this object multiple times. You could pass all the 3 point to constructor. CalculateSideAB and other method can be private in Triangle class.
			
			sideBC.CalculateSideBC(pointB, pointC);

			TriangleSides sideAC = new TriangleSides();
			sideAC.CalculateSideAC(pointA, pointC);

			// create triangle and output the triangle area
			Triangle myTriangle = new Triangle();
			
			myTriangle.CalculateTriangleArea(sideAB, sideBC, sideAC); // it's bettter to ppass this information using constructor, andthe nuse parametrless method CalculateArea();

			Console.WriteLine($"The area of the triangle is: {myTriangle.triangleArea}");
			Console.ReadLine();
		}
	}
}