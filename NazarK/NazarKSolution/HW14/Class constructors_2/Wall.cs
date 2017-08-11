using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class Wall
	{
		public int width;
		public int height;
		public int brickThickness;
		public Wall(int width, int height, int brickThickness)
		{
			this.width = width;
			this.height = height;
			this.brickThickness = brickThickness;
		}
	}
}
