using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Design a parent Car class with properties (Year of Manufacture, Name, Engine etc.). 
 Create 3 different subclasses with different engines. 
 Year of manufacture should be above 1990 and below 2017. 
 Name should not exceed 20 symbols. 
 Engine should have capacity from 500 to 3000 cc (cubic centimeters) 

 2. Create a ToString() method to output car characteristics to console 
*/

namespace HW19
{
    public class Car
    {
        private int yearOfManufacturer;
        internal protected int YearOfManufacturer
        {
            get
            {
                return yearOfManufacturer;
            }
            set
            {
                if (value > 1989 && value < 2018)
                    yearOfManufacturer = value;
            }
        }

        private string name = "Name is not provided";
        internal protected string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0 && value.Length < 21)
                    name = value;
            }
        }

        private int engine;
        internal protected int Engine
        {
            get
            {
                return engine;
            }
            set
            {
                if (value > 499 && value < 3001)
                    engine = value;
            }
        }

        public override string ToString()
        {
            string myString = "Year of manufacturer is: " + yearOfManufacturer + ". " + "Engine is: " + engine + ". " + "Name is: " + name + ".";
            return myString;
        }
    }

    public class SUV : Car
    {
        public SUV(string name, int engine, int year)
        {
            Name = name;
            Engine = engine;
            YearOfManufacturer = year;
        }
        public SUV()
        {
            Name = "SUV";
            Engine = 2000;
            YearOfManufacturer = 2010;
        }
    }

    public class Truck : Car
    {
        public Truck(string name, int engine, int year)
        {
            Name = name;
            Engine = engine;
            YearOfManufacturer = year;
        }
        public Truck()
        {
            Name = "Truck";
            Engine = 3000;
            YearOfManufacturer = 2010;
        }
    }

    public class Bus : Car
    {
        public Bus(string name, int engine, int year)
        {
            Name = name;
            Engine = engine;
            YearOfManufacturer = year;
        }
        public Bus()
        {
            Name = "Bus";
            Engine = 2500;
            YearOfManufacturer = 2010;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car newCar = new Truck(); // todo: you should pass stuff like Engine and YearOfManufacturer to constructor
			Console.WriteLine(newCar.ToString());
            Console.ReadKey();
        }
    }
}
