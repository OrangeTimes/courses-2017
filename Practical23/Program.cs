using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical23
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() {1, 4, 3, 2, 5, 6, 7, 10, 6};
			
			var numbersLargerThanFive = numbers.Where(x => x > 5)
				.Select(x => x * 10).Aggregate((accumulate, current) => accumulate + current);
			numbers.Add(20);
			numbers.Add(30);
			var list = numbersLargerThanFive;

		}
	}
}
