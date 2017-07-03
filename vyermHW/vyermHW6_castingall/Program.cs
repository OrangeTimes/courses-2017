using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW6_castingall
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter any value:");
			string userInput = Console.ReadLine();
			Console.WriteLine("Define type of your value:");
			string userValueType = Console.ReadLine();

			switch (userValueType.ToLower())
			{
				case "byte":
					Console.WriteLine(Convert.ToByte(userInput));
					break;
				case "short":
					Console.WriteLine(Convert.ToInt16(userInput));
					break;
				case "integer":
				case "int":
					Console.WriteLine(Convert.ToInt32(userInput));
					break;
				case "long":
					Console.WriteLine(Convert.ToInt64(userInput));
					break;
				default:
					Console.WriteLine("Unsupported target type");
					break;
			}
			Console.ReadKey();
		}
	}
}
