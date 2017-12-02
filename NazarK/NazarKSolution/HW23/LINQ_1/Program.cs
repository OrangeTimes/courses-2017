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
			
			List<int> numbers = new List<int>() { 1, 2, 3, 15, 55, -60, -5, 10, 12, 13 }; // Note: in real world scenario it's better to use array here 
																						  // (since you are not doing any List specific operation like adding or removing elemnets)
																						  // and memory footprint is a little bit less
			// get maximum number from the list
			int maxNum = numbers.Aggregate((holder, next) => holder < next ? next : holder);

			// get minimum number from the list
			int minNum = numbers.Aggregate((holder, next) => holder > next ? next : holder);
			Console.WriteLine($"Max number is: {maxNum}, min number is: {minNum}");
		}
	}
}
