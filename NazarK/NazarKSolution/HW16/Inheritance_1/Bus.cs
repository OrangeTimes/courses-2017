using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
	internal class Bus : Car
	{
		// child constructor which sets predefined maxSpeed for all cars of same type
		public Bus() : base(90)
		{
			Console.WriteLine("Bus is created");
		}
	}
}
