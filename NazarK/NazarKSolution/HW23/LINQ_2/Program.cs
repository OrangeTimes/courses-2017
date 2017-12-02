using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 15, 55, -60, -5, 10, 12, 13};

			// Using Where method find all numbers that are divisible by 2
			IEnumerable<int> divisibleByTwo = numbers.Where(x => x % 2 == 0); // Note: in this case it is okay to use var instead of IEnumerable<int>
																			  // also divisibleByTwo is not the best naming, since you have a collection of numbers and you don't tell it in your variables
																			  // numbersDivisibleByTwo is a better name in this context
			foreach (int num in divisibleByTwo)
			{
				Console.WriteLine(num);
			}
		}
	}
}
