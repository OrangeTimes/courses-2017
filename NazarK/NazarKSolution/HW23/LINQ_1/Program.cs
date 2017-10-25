using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 15, 55, -60, -5, 10, 12, 13 };

			// get maximum number from the list
			int maxNum = numbers.Aggregate((holder, next) => holder < next ? next : holder);

			// get minimum number from the list
			int minNum = numbers.Aggregate((holder, next) => holder > next ? next : holder);
			Console.WriteLine($"Max number is: {maxNum}, min number is: {minNum}");
		}
	}
}
