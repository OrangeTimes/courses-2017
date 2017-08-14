using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._1
{
    class Triangle
    {
        public double area;

        public double CalculateAreaOfTriangle(SideOfTriangle sideA, SideOfTriangle sideB, SideOfTriangle sideC)
        {
            area = 0.25*(Math.Sqrt((sideA.length + sideB.length - sideC.length)*(sideA.length - sideB.length + sideC.length)*(-(sideA.length) + sideB.length + sideC.length)*
                              (sideA.length + sideB.length + sideC.length)));
            return area;
        }


    }
}
