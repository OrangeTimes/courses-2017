using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_16_Ex._1_Driving_simulator
{
    public class Vehicle
    {
        public static int minSpeed = 0;
        public int currentSpeed;
        public int maxSpeed;
        public string carType;


        public void Accelerate()   // accelerate method
        {
            if (currentSpeed <= (maxSpeed - 10))
            {
                currentSpeed += 10;
                Console.WriteLine("Current speed " + currentSpeed + " km/h");
            }
            else
            {
                Console.WriteLine("You've reached Max speed for your car: " + currentSpeed);
            }
        }
        public void Decelerate()    // decelerate method
        {
            if (currentSpeed >= (minSpeed + 10))
            {
                currentSpeed -= 10;
                Console.WriteLine("Current speed " + currentSpeed + " km/h");
            }
            else
            {
                Console.WriteLine("You've reached Min speed for your car: " + currentSpeed);
            }
        }

        public void Check()  // method for checking current state 
        {
            Console.WriteLine(carType + ", Maximum speed: " + maxSpeed + ", Current speed: " + currentSpeed);
        }

    }
    public  class SUV : Vehicle
    {
        public SUV()
        {
            maxSpeed = 120;
            carType = "SUV";
        }
    }


    public class Truck : Vehicle
    {
        public Truck()
        {
            maxSpeed = 160;
            carType = "Truck";
        }
    }


    public class Bus : Vehicle
    {
        public Bus()
        {
            maxSpeed = 100;
            carType = "Bus";
        }
    }
}
