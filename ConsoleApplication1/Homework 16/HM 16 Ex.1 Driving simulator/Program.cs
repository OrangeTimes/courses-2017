using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_16_Ex._1_Driving_simulator
{
    class Program
    {
        /*
        1.  Create an application that can "simulate" driving of a SUV, a truck, and a bus. Each car will have predefined max speed. 
        Each car should have Accelerate, and Brake methods. 
        On acceleration vehicle should increase speed by 10 km/h but should not reach over max speed for current vehicle. 
        On acceleration vehicle should decrease speed by 10 km/h but should not be less than 0. 

        After each action you should show its current speed to console. 
        Bind W key to accelerate and S key on keybord to Brake methods. 
        Bind I to show car status. 
        
        Example of console: Select your car type: Press 1 for SUV, Press 2 for truck... 
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
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type of car: 1 for SUV, 2 for Truck, 3 for Bus");
            int carType = Convert.ToInt32(Console.ReadLine());
            Vehicle myCar;
            switch (carType)               // switch for creating certain car type based on user input
            {
                case 1:
                    myCar = new SUV();
                    break;

                case 2:
                    myCar = new Truck();
                    break;

                case 3:
                    myCar = new Bus();
                    break;

                default:
                    myCar = new Bus();
                    break;

            }
            Console.WriteLine("Now you can drive" + '\n' + "Use W key to accelerate" + '\n' + "Use S key to decelerate" + '\n' + "Use I key to get current driving status" + '\n');

            int x = 1;
            while (x ==1)    // while loop  - for making possible continuous user input // todo: check formatting
            {
                ConsoleKey pressedKey = Console.ReadKey().Key; // it is reasonoble to move this car control logic to separate method. It would be to have 1 method to conctruct a car, and next to control it
                Console.WriteLine();

                switch (pressedKey)   // switch for key binding to a method
                {
                    case ConsoleKey.W:
                        myCar.Accelerate();
                        break;
                    case ConsoleKey.S:
                        myCar.Decelerate();
                        break;
                    case ConsoleKey.I:
                        myCar.Check();
                        break;
                }
            }
        }
    }
}
