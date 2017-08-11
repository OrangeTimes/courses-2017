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
		public List<Wall> walls;
		public Window window;
		public Door door;

		public House(Roof roof, List<Wall> walls, Window window, Door door)
		{
			this.roof = roof;
			this.walls = walls;
			this.window = window;
			this.door = door;
		}
	}
}
