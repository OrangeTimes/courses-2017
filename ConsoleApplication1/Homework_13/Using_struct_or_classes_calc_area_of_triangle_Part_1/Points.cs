using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_struct_or_classes_calc_area_of_triangle_Part_1
{
	class Point
	{
		public int x;
		public int y;
		public void StringAsCoordinates(string coordinates)
		{
			string[] coordinatesArray = coordinates.Split(',');
			x = Convert.ToInt32(coordinatesArray[0]);
			y = Convert.ToInt32(coordinatesArray[1]);
		}
	}
}
