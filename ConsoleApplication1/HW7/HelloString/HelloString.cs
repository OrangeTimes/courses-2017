using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloString
{
    class HelloString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter custom text: ");
            string userString = Convert.ToString(Console.ReadLine());
            //string userString = "Vava Viva!";

            char [] userStringArray = userString.ToCharArray();

            foreach (char input in userStringArray)
            {
                Console.WriteLine($"{input}");
            }
            Console.ReadKey();
        }
    }
}
