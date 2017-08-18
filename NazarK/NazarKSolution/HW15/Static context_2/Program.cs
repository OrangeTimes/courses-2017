using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_context_2
{
	// Imagine a situation that you are not allowed to use public constructor
	// to create new class (you only have a private one).
	// Use instead static method to do so.
	class Program
	{
		static void Main(string[] args)
		{
			// Create new Car using static method
			Car ferrari = Car.Create("Red", 300000);
		}
	}
}
