using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Manufacturer
{
    Mercedes,
    Bmw,
    Volkswagen,
    Citroen,
    Skoda,
    Volvo
}

namespace Homework14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program that will create a car with few different options (manufacturer, year of manufacture, price those are mandatory). 
            //Create 3 different cars and output it values to console (Hint: you can use a separate method in your class for that).

            // create 3 car objects
            Car myCar1 = new Car(Manufacturer.Mercedes, 2017, 55000);
            Car myCar2 = new Car(Manufacturer.Bmw, 2016, 50000);
            Car myCar3 = new Car(Manufacturer.Volkswagen, 2015, 45000);

            // print car info
            Car.PrintCarInfo(myCar1);
            Car.PrintCarInfo(myCar2);
            Car.PrintCarInfo(myCar3);
            Console.ReadLine();
        }

		// remove this redundant empty lines


    }
}
