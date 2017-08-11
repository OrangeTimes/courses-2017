using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class Roof
	{
		public int width;
		public int height;
		public int tiling;
		public Roof(int width, int height, int tiling)
		{
			this.width = width;
			this.height = height;
			this.tiling = tiling;
		}
	}
}
