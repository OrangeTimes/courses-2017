using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Exercise 2: You have 5 lights in room.Lights are controlled by microprocessor.
            // Current state of lights is: 00000, where each slot corresponds to light state and is stored in int variable called roomLights;
            //Create command to enable 1, 3, 5 light in the room using binary data and bitwise operators.
            // After it switch all the lights. 
            // To enable change you need to update value of roomLights variable.
            // Note: you can use next statement to convert int value to binary representation for output: stringbinaryForm = Convert.ToString(number, 2);

            int roomLights = 0; //00000

            // to enable 1, 3, 5 light
            Console.WriteLine("Plase enter which lights you want to enable: ");
            //string lightsToEnable = Console.ReadLine();
            int lightsToEnable = Convert.ToInt32(Console.ReadLine(), 2);

            roomLights |= lightsToEnable;
            //roomLights |= Convert.ToInt32(lightsToEnable, 2);
            Console.WriteLine($"Current state: {Convert.ToString(roomLights, 2)}");
            Console.ReadLine();

            //to enable all lights
            roomLights |= Convert.ToInt32("11111", 2);
            Console.WriteLine($"Current state: {Convert.ToString(roomLights, 2)}");
            Console.ReadLine();
        }
    }
}
