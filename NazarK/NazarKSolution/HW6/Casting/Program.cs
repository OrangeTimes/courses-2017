using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
	class Program
	{
		static void Main(string[] args)
		{
			// Task1
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


			// Task2
			Console.Write("\nPlease enter a number that you want to convert: ");
			string inputToConvert = Console.ReadLine();

			Console.Write("Please enter which type you want to convert to: ");
			string typeToConvertTo = Console.ReadLine();

			// Convert to supported type and write the result or write error
			switch (typeToConvertTo)
			{
				case "byte":
					Console.WriteLine($"{Convert.ToByte(inputToConvert)}");
					break;
				case "short":
					Console.WriteLine($"{Convert.ToInt16(inputToConvert)}");
					break;
				case "integer":
					Console.WriteLine($"{Convert.ToInt32(inputToConvert)}");
					break;
				case "long":
					Console.WriteLine($"{Convert.ToInt64(inputToConvert)}");
					break;
				default:
					Console.WriteLine($"Unsupported target type");
					break;
			}
		}
	}
}