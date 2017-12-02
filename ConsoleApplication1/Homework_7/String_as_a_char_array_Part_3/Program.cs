using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_as_a_char_array_Part_3
{
	class Program
	{
		static void Main(string[] args)
			// Write each char in predefined string in new line in console(treat string as a char array it supportsit out of the box).
		{
			string definedString = "Hello";
			//convert to char array
			char[] arrayStr;
			arrayStr = definedString.ToCharArray();
			// print out each char in separate string line
			foreach (char i in arrayStr) 
			Console.WriteLine($"{i}"); // !!! it's better to put code inside the loop in in scope using {} brackets, even your implementation is a valid syntax
			Console.ReadKey();
		}
	}
}
