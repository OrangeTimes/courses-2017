using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_struct_or_classes_calc_area_of_triangle_Part_1
{
	
	class TriangleSides
	{
		public double lengthAB;
		public double lengthBC;
		public double lengthAC;

		public void CalculateSideAB(Point pointA, Point pointB)
		{
			// calculate the length of the triangle side AB
			lengthAB = Math.Sqrt(Math.Pow((pointA.x - pointB.x), 2) + Math.Pow((pointA.y - pointB.y), 2));
		}
		public void CalculateSideBC(Point pointB, Point pointC)
		{
			// calculate the length of the triangle side BC
			lengthBC = Math.Sqrt(Math.Pow((pointB.x - pointC.x), 2) + Math.Pow((pointB.y - pointC.y), 2));
		}
		public void CalculateSideAC(Point pointA, Point pointC)
		{
			// calculate the length of the triangle side AC
			lengthAC = Math.Sqrt(Math.Pow((pointA.x - pointC.x), 2) + Math.Pow((pointA.y - pointC.y), 2));
		}
	}
	class Triangle
	{
		public double triangleArea;
		public double CalculateTriangleArea(TriangleSides sideAB, TriangleSides sideBC, TriangleSides sideAC)
		{
			// calculate triangle area
			triangleArea = 0.25 * Math.Sqrt((sideAB.lengthAB + sideBC.lengthBC - sideAC.lengthAC) * (sideAB.lengthAB - sideBC.lengthBC + sideAC.lengthAC) * (-sideAB.lengthAB + sideBC.lengthBC + sideAC.lengthAC) * (sideAB.lengthAB + sideBC.lengthBC + sideAC.lengthAC));
			return triangleArea;
		}
	}
}
