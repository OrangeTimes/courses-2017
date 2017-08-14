using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._1
{
    public class Point
    {
        public int x;
        public int y;

        public void ConvertStringToCoordinates(string coordinates)
        {
            string[] coordinatesArray = coordinates.Split(',');
            x = Convert.ToInt32(coordinatesArray[0]);
            y = Convert.ToInt32(coordinatesArray[1]);

        }

    }
}

