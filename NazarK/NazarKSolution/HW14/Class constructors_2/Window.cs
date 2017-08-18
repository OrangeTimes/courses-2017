using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class Window
	{
		public int width;
		public int height;
		public int glassThickness;

		public Window(int width, int height, int glassThickness)
		{
			this.width = width;
			this.height = height;
			this.glassThickness = glassThickness;
		}
	}
}
