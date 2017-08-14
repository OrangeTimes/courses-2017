using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._1
{
    class SideOfTriangle
    {
        public double length;

        public void CalculateSide(Point pointA, Point pointB)
        {
            length = Math.Sqrt(Math.Pow((pointA.x - pointB.x), 2) + Math.Pow((pointA.y - pointB.y), 2));
        }
    }
}
