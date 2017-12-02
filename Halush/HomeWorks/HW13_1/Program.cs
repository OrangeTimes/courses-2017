using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that will use coordinates of 3 points entered by user and calculate area of triangle created by those 3 dots.
Use structs or classes(Point, Triangle) in your implementation.
*/

namespace HW13_1
{
    //This class is for points' coordinates
    public class Point
    {
        public int x;
        public int y;
    }
    //This class is for 3 points of a triangle
    public class Triangle
    {
        public Point a; // todo: in general public field is a bad idea, you should use properties instead of such fields
        public Point b;
        public Point c;
        //This method calculates triangle's area
        public double GetTriangleArea(Point a, Point b, Point c)
        {
            double abLenght = GetDistance(a, b);
            double bcLenght = GetDistance(b, c);
            double caLenght = GetDistance(c, a);
            double sum = (abLenght + bcLenght - caLenght) * (abLenght - bcLenght + caLenght) * (-abLenght + bcLenght + caLenght) * (abLenght + bcLenght + caLenght);
            double result = 0.25 * Math.Sqrt(sum);
            return result;
        }
        //This method calculaates a side's distance
        public double GetDistance(Point a, Point b)
        {
            int arg1 = a.x - b.x;
            int arg2 = a.y - b.y;
            double result = Math.Sqrt(Math.Pow(arg1, 2) + Math.Pow(arg2, 2));
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create new object Trianlge and initialize 3 points of it
            Triangle myTriangle = new Triangle(); // todo: pass the 3 Points to contructor here
            myTriangle.a = new Point();
            myTriangle.b = new Point();
            myTriangle.c = new Point();
            Console.WriteLine("To calculate the area of a triangle you have to enter coordiantes of 3 points.");
            Console.WriteLine("Please enter coordinates of a first point:");
            myTriangle.a.x = Convert.ToInt32(Console.ReadLine());
            myTriangle.a.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of a second point:");
            myTriangle.b.x = Convert.ToInt32(Console.ReadLine());
            myTriangle.b.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of a third point:");
            myTriangle.c.x = Convert.ToInt32(Console.ReadLine());
            myTriangle.c.y = Convert.ToInt32(Console.ReadLine());
            double area = myTriangle.GetTriangleArea(myTriangle.a, myTriangle.b, myTriangle.c); // todo: if you will pass the  3 Points using contrctor there is no reason to apps them here
			Console.WriteLine("The area of your triangle is {0}", area);
            Console.ReadKey();
        }
    }
}