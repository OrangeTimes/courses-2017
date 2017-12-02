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
			string predefinedString = "HelloWorld!";

			PrintAsCharArray(predefinedString);

			PrintCharsUsingIndex(predefinedString);
		}

		public static void PrintAsCharArray(string predefinedString)
		{
			// split string to parts
			char[] parts = predefinedString.ToCharArray();

			// print string parts vertically
			foreach (char character in parts)
			{
				Console.WriteLine(character);
			}
		}

		public static void PrintCharsUsingIndex(string predefinedString)
		{
			// print string parts vertically
			for (int i = 0; i < predefinedString.Length; i++) // no need to use for loop here you can use foreach
			{
				Console.WriteLine(predefinedString[i]);
			}
		}
	}
}
