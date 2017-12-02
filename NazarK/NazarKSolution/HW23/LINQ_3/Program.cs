using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 15, 55, -60, -5, 10, 12, 13 };

			// Using Select method transform numbers to string representation with 2 number precision e.g.
			// “2.00” (check ToString() documentation to get more info)
			IEnumerable<string> strings = numbers.Select(x => x.ToString("0.00")); //often it is reasonoble to extract "0.00" to a separate variable 
																				//called doublePrecisionStringFormat to avoid magic string (numbers) in your code
			foreach (string line in strings)
			{
				Console.WriteLine(line);
			}
		}
	}
}
