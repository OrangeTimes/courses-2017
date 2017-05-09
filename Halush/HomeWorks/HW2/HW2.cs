using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class HW2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Manufacturer:");
            string carManufacturer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Model:");
            string carModel = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Year:");
            int carYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price:");
            double carPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Color:");
            string carColor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You selected Manufacturer:{0}, Model:{1}, Year:{2}, Price:{3}$, Color:{4}.", carManufacturer, carModel, carYear, carPrice, carColor);
            Console.ReadKey();
        }
    }
}
