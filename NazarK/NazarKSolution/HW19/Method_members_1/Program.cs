using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_members_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Bus bus = new Bus
			{
				Engine = 3500,
				Name = "Mercedes",
				YearOfManufacture = 2000
			};
			Console.WriteLine(bus.ToString());
		}
	}
}
