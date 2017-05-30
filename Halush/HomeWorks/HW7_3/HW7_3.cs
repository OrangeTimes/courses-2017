using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write each char in predefined string in new line in console (treat string as a char array it supports it out of the box).
 */




namespace HW7_3
{
    class HW7_3
    {
        static void Main(string[] args)
        {
            string a = "Hello World!";
            // todo: it's better to use foreach loop here from code readability perspective
            // Halush Oleh: fixed
            foreach (char b in a)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
