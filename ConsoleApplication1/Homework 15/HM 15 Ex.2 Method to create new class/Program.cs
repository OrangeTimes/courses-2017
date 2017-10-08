using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_15_Ex._2_Method_to_create_new_class
{
    class Program
    {

        /*
        2. Imagine a situation that you are not allowed to use public constructor to create new class (you only have a private one). 
        Use instead static method to do so.
        */

        static void Main(string[] args)
        {
            
            Car myCar = Car.Create("some type", "some manufacturer", "red", 121432.121322);
            Console.WriteLine($"object - {myCar}");
            Console.WriteLine('\n' + myCar.type + '\n' + myCar.manufacturer + '\n' + myCar.color + '\n' + myCar.price);

            Console.ReadLine();

        }
    }
}
