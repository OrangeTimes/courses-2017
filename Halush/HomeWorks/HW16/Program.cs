using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create an application that can "simulate" driving of a SUV, a truck, and a bus. 
Each car will have predefined max speed. Each car should have Accelerate, and Brake methods.
On acceleration vehicle should increase speed by 10 km/h but should not reach over max speed for current vehicle. 
On acceleration vehicle should decrease speed by 10 km/h but should not be less than 0. 
After each action you should show its current speed to console.
Bind W key to accelerate and S key on keybord to Brake methods. 
Bind I to show car status.

Example of console: 
Select your car type: Press 1 for SUV, Press 2 for truck... 
2 
W 
Current speed 10km/h
W 
Current speed 20km/h
S 
Current speed 10km/h 
I 
Type: Truck, Maximum speed: 180km/h, Current speed: 10km/h 

Hint: use Console.ReadKey().Key == ConsoleKey.W to check user key 
*/

namespace HW16
{
    public class Car
    {
        public string type;
        public int maxSpeed;
        public int minSpeed;
        public int currentSpeed;

        public Car()
        {
            type = "Car";
            maxSpeed = 180;
            minSpeed = 0;
            currentSpeed = 0;
        }

        public int Accelerate()
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += 10;
                Console.WriteLine(currentSpeed + "km/h");
                return currentSpeed;
            }
            else
                Console.WriteLine("You have reached maximum speed. You can't go faster");
            return currentSpeed;
        }

        public int Break()
        {
            if (currentSpeed > minSpeed)
            {
                currentSpeed -= 10;
                Console.WriteLine(currentSpeed + "km/h");
                return currentSpeed;
            }
            else
                Console.WriteLine("You are staing on one place. You can't go slowly");
            return currentSpeed;
        }

        public void Info()
        {
            Console.WriteLine("Type: {0}, Maximum speed: {1}km/h, Current speed: {2}km/h", type, maxSpeed, currentSpeed);
        }
    }

    public class SUV : Car
    {
        public SUV()
        {
            type = "SUV";
            maxSpeed = 220;
        }
    }

    public class Truck : Car
    {
        public Truck()
        {
            type = "Truck";
            maxSpeed = 160;
        }
    }

    public class Bus : Car
    {
        public Bus()
        {
            type = "Bus";
            maxSpeed = 120;
        }
    }

    public class Program
    {
        static void Instruction()
        {
            Console.WriteLine("New car is created.Press W to accelerate, S to break, I to get info and Esc to finish the race.");
            Console.WriteLine("Press any key to proceed.");
        }

        static Car CreateCar()
        {
            Console.WriteLine("Please choose your car:");
            Console.WriteLine("Press 1 for SUV. Press 2 for truck. Press 3 for bus.");
            bool isUserInputValid = Int32.TryParse(Console.ReadLine(), out int usersInput);
            while (!isUserInputValid)
            {
                Console.WriteLine("You have entered an incorrect value. Please try again.");
                Console.WriteLine("Press 1 for SUV. Press 2 for truck. Press 3 for bus.");
                isUserInputValid = Int32.TryParse(Console.ReadLine(), out usersInput);
            }

            Car newCar;

            switch (usersInput)
            {
                case 1:
                    {
                        newCar = new SUV();
                        Instruction();
                        break;
                    }
                case 2:
                    {
                        newCar = new Truck();
                        Instruction();
                        break;
                    }
                case 3:
                    {
                        newCar = new Bus();
                        Instruction();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You haven't chosen proposed cars. The default one will be created.");
                        Instruction();
                        newCar = new Car();
                        break;
                    }
            }
            return newCar;
        }

        static void Main(string[] args)
        {
            Car newCar = CreateCar();

            int i = 1;
            while (i > 0)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        {
                            Console.WriteLine();
                            newCar.Accelerate();
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            Console.WriteLine();
                            newCar.Break();
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.WriteLine();
                            newCar.Info();
                            break;
                        }
                    case ConsoleKey.Escape:
                        i = 0;
                        break;
                }
            }
        }
    }
}
