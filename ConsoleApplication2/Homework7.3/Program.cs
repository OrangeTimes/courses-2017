using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write each char in predefined string in new line in console (treat string as a char array it supports it out of the box).

            // predefined string
            string myString = "humbabra";

            WriteStringInConsole(myString);
        }

        static void WriteStringInConsole(string myString)
        {
            //convert string to char array
            char[] myStringArray = myString.ToCharArray();

            //write each char of array in separate line
            foreach (char i in myStringArray)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}
