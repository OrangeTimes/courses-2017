using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_classes_1
{
	public class Triangle
	{
		// all points and edges, all read-only to not to change after creation
		// so that some methods will run only once and be private
		public readonly Point pointA;
		public readonly Point pointB;
		public readonly Point pointC;
		public readonly double edgeA;
		public readonly double edgeB;
		public readonly double edgeC;
		public readonly double area;

		// calculate an edge length by two points
		// public so that user can reuse it outside the class
		// static because it doesn't use object fields directly
		public static double Edge(Point first, Point second)
		{
			double dist = Math.Sqrt(Math.Pow((first.x - second.x), 2) + Math.Pow((first.y - second.y), 2));
			return dist;
		}

		// calculate an area by 3 edges
		// private as it will run only once and is not meant to be reused
		// non static because it uses fields directly from class object 
		private double Area()
		{
			double area = 0.25 * Math.Sqrt((edgeA + edgeB - edgeC) * (edgeA - edgeB + edgeC) * (-edgeA + edgeB + edgeC) * (edgeA + edgeB + edgeC));
			return area;
		}

		public Triangle(Point pointA, Point pointB, Point pointC)
		{
			this.pointA = pointA;
			this.pointB = pointB;
			this.pointC = pointC;
			edgeA = Edge(pointA, pointB);
			edgeB = Edge(pointB, pointC);
			edgeC = Edge(pointC, pointA);
			area = Area(); // it's better to move this to a separate method, and perform it on demand and not during construction time
		}
	}
}
