using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // How can you check that any light number entered by user is turned on without affecting it and other lights
            //(using bitwise operators and Boolean logic) and send back result to the user as Boolean value ? 
            //bool isUserLightActive = ...

            //To raise number to the specified power. 
            //double result = Math.Pow(3, 5); 

            //To convert between double and int: 
            //Convert.ToInt32(result)

            int roomLights = 0; //00000

            // user should decide which lights to enable
            Console.Write("Please specify the lights you want to enable: ");
            int lightsToEnable = Convert.ToInt32(Console.ReadLine(), 2);

            roomLights |= lightsToEnable;

            // tell user which lights are enabed
            Console.WriteLine($"Following lights are currently enabled: {Convert.ToString(roomLights, 2)}");
            Console.ReadLine();

            // user should decide which of the lights he wants to check
            Console.Write("Please specify the light number you want to check: ");
            int lightToCheck = Convert.ToInt32(Console.ReadLine());

            // define how many bytes we need to shift to check the desired light
            int numberOfLightsToShift = 5 - lightToCheck;

            // shift the bytes
            int lastLight = roomLights >> numberOfLightsToShift;

            // the last byte should represent if the desired light is enabled
            Console.WriteLine($"take a look at last number to know if desired light is enabled: {Convert.ToString(lastLight, 2)}");

            // tell user if the desired light is enabled
            bool isUserLightActive = (lastLight % 2) == 1;
            Console.WriteLine($"The light {lightToCheck} is enabled: {isUserLightActive}");
            Console.ReadLine();
        }
    }
}
