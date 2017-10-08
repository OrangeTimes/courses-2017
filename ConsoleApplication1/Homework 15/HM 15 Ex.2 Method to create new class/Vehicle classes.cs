using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_15_Ex._2_Method_to_create_new_class
{
        public class Vehicle
        {
            public string type;                   // class varibles
            public string manufacturer;
            public string color;                 
            public double price;
        }
        public class Car: Vehicle
        {
            private Car(string type, string manufacturer, string color, double price)    // private Car constructor
            {
                this.type = type;
                this.manufacturer = manufacturer;
                this.color = color;
                this.price = price;
            }


            public static Car Create(string type, string manufacturer, string color, double price) // method to create new Car using constructor
            {
                return new Car(type, manufacturer, color, price);
            }


        }
    }

