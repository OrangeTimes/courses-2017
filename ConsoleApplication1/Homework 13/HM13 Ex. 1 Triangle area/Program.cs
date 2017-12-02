using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HM13_Ex._1_Triangle_area
{

    class Program
    {
        static void Main(string[] args)
        {
			// todo: create new  and pass Points to Triangle constructor instead
            Triangle myTriangle = new Triangle();  // creating instance of "Triangle" class with name "myTriangle"
            myTriangle.TriangleArea();             // invoking a method using the instance of Triangle class
            Console.ReadLine();

        }
    }
}

