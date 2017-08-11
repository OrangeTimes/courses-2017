using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class Door
	{
		public int width;
		public int height;
		public int woodThickness;
		public Door(int width, int height, int woodThickness)
		{
			this.width = width;
			this.height = height;
			this.woodThickness = woodThickness;
		}
	}
}
