using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			//1. Write a program that will use coordinates of 3 points entered by user 
			//and calculate area of triangle created by those 3 dots. 
			//Use structs or classes (Point, Triangle) in your implementation. 
			//Distance between 2 dots (formula is in step-by-step dialog) 
			//https://www.wolframalpha.com/input/?i=points+distance+formula
			//Triangle area formula: https://www.wolframalpha.com/input/?i=area+of+triangle+formula&rawformassumption=%7B%22MC%22,+%22%22%7D+-%3E+%7B%22Geometry%22%7D

			// get coordinates of point A
			Console.Write("please enter coordinates of point A, separated by comma: ");
			string coordinatesPointA = Console.ReadLine();

			Point pointA = new Point();
			pointA.ConvertStringToCoordinates(coordinatesPointA);

			// get coordinates of point B
			Console.Write("please enter coordinates of point B, separated by comma: ");
			string coordinatesPointB = Console.ReadLine();

			Point pointB = new Point();
			pointB.ConvertStringToCoordinates(coordinatesPointB);

			// get coordinates of point C
			Console.Write("please enter coordinates of point C, separated by comma: ");
			string coordinatesPointC = Console.ReadLine();

			Point pointC = new Point();
			pointC.ConvertStringToCoordinates(coordinatesPointC);

			// create sides & calculate sides length
			SideOfTriangle sideA = new SideOfTriangle();
			sideA.CalculateSide(pointA, pointB);

			SideOfTriangle sideB = new SideOfTriangle();
			sideB.CalculateSide(pointB, pointC);

			SideOfTriangle sideC = new SideOfTriangle();
			sideC.CalculateSide(pointA, pointC);

			//create triangle
			Triangle myTriangle = new Triangle();
			myTriangle.CalculateAreaOfTriangle(sideA, sideB, sideC);

			Console.WriteLine($"Side A length = {sideA.length}, Side B length = {sideB.length}, Side C = {sideC.length}. The area of your triangle is: {myTriangle.area}");
			Console.ReadLine();
		}

	}
}