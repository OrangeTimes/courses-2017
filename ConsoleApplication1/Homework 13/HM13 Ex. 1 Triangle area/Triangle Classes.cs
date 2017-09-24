using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13_Ex._1_Triangle_area
{
    public class Triangle
    {
                /*
                1. Write a program that will use coordinates of 3 points entered by user and calculate area of triangle created by those 3 dots. 
                Use structs or classes (Point, Triangle) in your implementation. 
                Distance between 2 dots (formula is in step-by-step dialog) https://www.wolframalpha.com/input/?i=points+distance+formulaTriangle 
                area formula: https://www.wolframalpha.com/input/?i=area+of+triangle+formula&rawformassumption=%7B%22MC%22,+%22%22%7D+-%3E+%7B%22Geometry%22%7D
                */

        public double area;
        EdgesLength EdgesLength1 = new EdgesLength();          // create instance of class EdgesLength with name "EdgesLength1"
        public double TriangleArea()         // calculate an area of the triangle
        {
            area = 0.25 * Math.Sqrt((EdgesLength1.lengthEdgeAB + EdgesLength1.lengthEdgeBC - EdgesLength1.lengthEdgeCA) * (EdgesLength1.lengthEdgeAB - EdgesLength1.lengthEdgeBC + EdgesLength1.lengthEdgeCA) * (-EdgesLength1.lengthEdgeAB + EdgesLength1.lengthEdgeBC + EdgesLength1.lengthEdgeCA) * (EdgesLength1.lengthEdgeAB + EdgesLength1.lengthEdgeBC + EdgesLength1.lengthEdgeCA));
            Console.WriteLine("Triangle area = " + area);
            Console.ReadLine();
            return area;
        }
    }




    public class EdgesLength
    {
        public double lengthEdgeAB;
        public double lengthEdgeBC;
        public double lengthEdgeCA;

        public EdgesLength ()                    // using custom constructor here to avoid an error "A field initializer cannot reference the nonstatic field, method, or property"
        {                                  // in constructor I create 3 instances of "Point" class and calculate length between these points 
            Point pointA = new Point();
            Point pointB = new Point();
            Point pointC = new Point();

            lengthEdgeAB = Math.Sqrt(Math.Pow((pointA.x - pointB.x), 2) + Math.Pow((pointA.y - pointB.y), 2));
            lengthEdgeBC = Math.Sqrt(Math.Pow((pointB.x - pointC.x), 2) + Math.Pow((pointB.y - pointC.y), 2));
            lengthEdgeCA = Math.Sqrt(Math.Pow((pointC.x - pointA.x), 2) + Math.Pow((pointC.y - pointA.y), 2));
        }
    }
        

       
        public class Point
    {
        public int x = Coordinates.GetPointX();                      // getting X coordinate, and assigning it to the variable x
        public int y = Coordinates.GetPointY();                      // getting Y coordinate, and assigning it to the variable y
    }



    public struct Coordinates
    {
        public static int GetPointX()                                 // method for getting X coordinate
        {
            Console.Write("Enter coordinates of a point X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int GetPointY()                                 // method for getting Y coordinate
        {
            Console.Write("Enter coordinates of a point Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
    }
}











