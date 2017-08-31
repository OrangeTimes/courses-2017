using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
	internal class SUV : Car
	{
		// child constructor which sets predefined maxSpeed for all cars of same type
		public SUV() : base(140)
		{
			Console.WriteLine("SUV is created");
		}
	}
}
