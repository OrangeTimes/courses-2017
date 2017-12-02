using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program that will create a car with few different options (manufacturer, year of manufacture, price those are mandatory). 
 Create 3 different cars and output it values to console (Hint: you can use a separate method in your class for that)
 */

namespace HW14_1
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Please prodide a manufacturer of your car:");
            this.manufacturer = Console.ReadLine();
            Console.WriteLine("Please prodide a year of your car:");
            this.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please prodide a price of your car:");
            this.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please prodide a color of your car:");
            this.color = (Console.ReadLine());
        }
        public string manufacturer;
        public int year;
        public int price;
        public string color;
    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello dear customer. Today we are going to create a car of your dream.");
            Car firstCar = new Car(); // todo: you should be passing  (manufacturer, year of manufacture, price those are mandatory) to constructor here
			Car secondCar = new Car();
            Car thirdCar = new Car();
            Console.WriteLine("Congratulations! You just created 3 new cars.");
            Console.WriteLine("Your first car was created with following conditions:");
            Console.WriteLine("Manufacturer: {0}; Year: {1}; Price: {2}; Color: {3}.", firstCar.manufacturer, firstCar.year, firstCar.price, firstCar.color);
            Console.WriteLine("Your second car was created with following conditions:");
            Console.WriteLine("Manufacturer: {0}; Year: {1}; Price: {2}; Color: {3}.", secondCar.manufacturer, secondCar.year, secondCar.price, secondCar.color);
            Console.WriteLine("Your third car was created with following conditions:");
            Console.WriteLine("Manufacturer: {0}; Year: {1}; Price: {2}; Color: {3}.", thirdCar.manufacturer, thirdCar.year, thirdCar.price, thirdCar.color);
            Console.ReadKey();
        }
    }
}
