using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalDeliveryApp
{
    partial class PostalDeliveryApp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter preffered delivery method: ");
            PostalDeliveryMethods userValue = (PostalDeliveryMethods)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You've selected {userValue} method");
            Console.ReadKey();
        }
    }
}
