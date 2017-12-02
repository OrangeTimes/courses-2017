using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_String_as_char_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string predefinedString = "Something";  // predefined string
            char [] myStringArray = predefinedString.ToCharArray(); // declare char array and populate it with predefinedString (that is being converted to char array)
            foreach (char i in myStringArray) // loop through each char
            {
                Console.WriteLine($"{i}");    // prints out char
                // redundant space here
            }
            Console.ReadLine();
        }
    }
}
