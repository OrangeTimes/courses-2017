using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM14_Ex._1_Create_a_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", 1999, 23451.12, "sedan", 13);   // Creating an object of type Car   
			// todo: instead of using next line you can create an override of ToString method in Car class which will perform converting Car class to a string
            Console.WriteLine("manufacturer = " + myCar.manufacturer + '\n'+ "year Of Manufacture = " + myCar.yearOfManufacture + '\n' + "price = " + myCar.price + '\n' + "fuel consumption = " + myCar.fuelConsumption + '\n' + "color = " + myCar.color);
            Console.ReadLine();

            Car myCar2 = new Car("Lada", 2013, 323451.12, "uni", 10, "green");   
            Console.WriteLine("manufacturer = " + myCar2.manufacturer + '\n' + "year Of Manufacture = " + myCar2.yearOfManufacture + '\n' + "price = " + myCar2.price + '\n' + "fuel consumption = " + myCar2.fuelConsumption + '\n' + "color = " + myCar2.color);
            Console.ReadLine();

            Car myCar3 = new Car("Audi", 2015, 32333.11);
            Console.WriteLine("manufacturer = " + myCar3.manufacturer + '\n' + "year Of Manufacture = " + myCar3.yearOfManufacture + '\n' + "price = " + myCar3.price + '\n' + "fuel consumption = " + myCar3.fuelConsumption + '\n' + "color = " + myCar3.color);
            Console.ReadLine();
        }
    }
}
