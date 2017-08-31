using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
	internal class Truck : Car
	{
		// child constructor which sets predefined maxSpeed for all cars of same type
		public Truck() : base(80)
		{
			Console.WriteLine("Truck is created");
		}
	}
}
