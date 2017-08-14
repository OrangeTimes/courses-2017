using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework14._1;


namespace Homework14._1

{
    public class Car
    {
        public Manufacturer manufacturer;
        public int year;
        public int price;

        // create constructor
        public Car(Manufacturer manufacturer, int year, int price)
        {
            this.manufacturer = manufacturer;
            this.year = year;
            this.price = price;
        }

        // method to print car info
        public static void PrintCarInfo(Car myCar)
        {
            Console.WriteLine($"Car Manufacturer: {myCar.manufacturer}; year: {myCar.year}, price: {myCar.price}$.");
        }
    }
}
