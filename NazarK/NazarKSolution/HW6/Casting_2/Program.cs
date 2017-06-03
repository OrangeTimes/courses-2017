using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// get user input
			Console.Write("Please enter a number that you want to convert: ");
			string inputToConvert = Console.ReadLine();
			Console.Write("Please enter which type you want to convert to: ");
			string typeToConvertTo = Console.ReadLine();

			// Convert to supported type and write the result or write error
			ConvertTo(inputToConvert, typeToConvertTo);
		}

		public static void ConvertTo(string inputToConvert, string typeToConvertTo)
		{
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
					Console.WriteLine($"Error: Unsupported target type");
					break;
			}
		}
	}
}
