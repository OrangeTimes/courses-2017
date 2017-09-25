using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM14_Ex._1_Create_a_car
{

    /*
    1. Write a program that will create a car with few different options (manufacturer, year of manufacture, price those are mandatory). 
    Create 3 different cars and output it values to console (Hint: you can use a separate method in your class for that).  
    */

    class Car
    {
        public string manufacturer;         // class variables
        public int yearOfManufacture;
        public double price;
        public string type;
        public double fuelConsumption;
        public string color;

        public Car(string manufacturer, int yearOfManufacture, double price)               // here and below are different constructors with different number of parameters
        {
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.price = price;
        }


        public Car(string manufacturer, int yearOfManufacture, double price, string type)
        {
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.price = price;
            this.type = type;
        }

        public Car(string manufacturer, int yearOfManufacture, double price, string type, double fuelConsumption)
        {
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.price = price;
            this.type = type;
            this.fuelConsumption = fuelConsumption;
        }

        public Car(string manufacturer, int yearOfManufacture, double price, string type, double fuelConsumption, string color)
        {
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.price = price;
            this.type = type;
            this.fuelConsumption = fuelConsumption;
            this.color = color;
        }
    }
}
