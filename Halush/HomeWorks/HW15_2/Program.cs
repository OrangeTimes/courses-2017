using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Imagine a situation that you are not allowed to use public constructor to create new class(you only have a private one).
Use instead static method to do so.
*/

namespace HW15_2
{
    public class Car
    {
        public int wheels;
        public int maxSpeed;
        public string color;

        private Car()
        {
        }

        public static Car CreateCar()
        {
            Car myCar = new Car();
            return myCar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car olegsCar = Car.CreateCar();
            olegsCar.wheels = 3;
            olegsCar.maxSpeed = 100;
            olegsCar.color = "Green";
            Console.WriteLine("You have created a car with {0}km/hr max speed, {1} wheels and {2} color.", olegsCar.maxSpeed, olegsCar.wheels, olegsCar.color);
            Console.ReadKey();
        }
    }
}
