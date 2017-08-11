using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructors_2
{
	class House
	{
		public Roof roof;
		public Wall wall;
		public Window window;
		public Door door;

		public House(Roof roof, Wall wall, Window window, Door door)
		{
			this.roof = roof;
			this.wall = wall;
			this.window = window;
			this.door = door;
		}
	}
}
