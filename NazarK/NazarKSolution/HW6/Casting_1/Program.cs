using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter a number that you want to evaluate: ");
			double input = Convert.ToDouble(Console.ReadLine());

			// if number is as zero than it is both whole and real
			if (input == 0)
			{
				Console.WriteLine("Zero is both whole and real.");
			}
			// convert input to integer and compare back, if number was whole it should lost precision and return false
			// also it should be bigger than 0
			else if (input == (Int32)input && input > 0)
			{
				Console.WriteLine("The number is Whole.");
			}
			else
			{
				Console.WriteLine("The number is Real.");
			}
		}
	}
}