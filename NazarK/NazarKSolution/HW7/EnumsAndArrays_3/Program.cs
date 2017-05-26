using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndArrays_3
{
	class Program
	{
		static void Main(string[] args)
		{
			// predefined string
			string predefinedString = "HelloWorld";

			// split string to parts
			char[] parts = predefinedString.ToCharArray();

			// print string parts vertically
			foreach (char character in parts)
			{
				Console.WriteLine(character);
			}
		}
	}
}
