using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Bitwise_Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have 5 lights in room.Lights are controlled by microprocessor.
            //Current state of lights is: 00000, where each slot corresponds to light state and is stored in int variable called roomLights;
            //Create command to enable 1, 3, 5 light in the room using binary data and bitwise operators.
            //After it switch all the lights. 
            //To enable change you need to update value of roomLights variable.
            //Note: you can use next statement to convert int value to binary representation for output: stringbinaryForm = Convert.ToString(number, 2);


            int roomLights = 0; // equals to "... 00000". All lights are off
            Console.WriteLine ("Enter in binary which lights among 5 you want to enable.");
            Console.WriteLine ("You need to input 10101 to enable 1, 3, 5 lights in the room");
            string userInput = Console.ReadLine(); // User needs to input 10101 to enable 1, 3, 5 light in the room

            roomLights |= Convert.ToInt32(userInput, 2);  // Converts input from binary to int and turns on all lights defined by user
            Console.WriteLine($"Current state of lights: {Convert.ToString(roomLights, 2)}");

            Console.WriteLine ("Enter in binary which lights among 5 you want to enable.");
            Console.WriteLine ("You need to input 11111 to enable all the lights in the room");

            string userInput2 = Console.ReadLine();
            roomLights |= Convert.ToInt32(userInput2, 2);
            Console.WriteLine ($"Current state of lights: {Convert.ToString(roomLights, 2)} - all lights are ON");

            Console.ReadLine();
        }
    }
}