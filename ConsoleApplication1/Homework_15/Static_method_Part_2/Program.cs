using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method_Part_2
	// Imagine a situation that you are not allowed to use public constructor
	// to create new class(you only have a private one). Use insteadstatic method to do so.
{
	class Program
	{
		static void Main(string[] args)
		{
			Currency Price = Currency.Display(56780, "euro");
			Currency.outputCurrency(Price);
			Console.ReadLine();
		}
	}
}
