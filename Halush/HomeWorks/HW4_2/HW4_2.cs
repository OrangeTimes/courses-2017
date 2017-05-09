using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
You have 5 lights in room. Lights are controlled by microprocessor. 
Current state of lights is: 00000, where each slot corresponds to light state and is stored in int variable called roomLights; 
Create command to enable 1, 3, 5 light in the room using binary data and bitwise operators.  
After it switch all the lights. 
To enable change you need to update value of roomLights variable. 
Note: you can use next statement to convert int value to binary representation for output:
string binaryForm = Convert.ToString(number, 2);
 */

namespace HW4_2
{
    class HW4_2
    {
        static void Main(string[] args)
        {
            int roomLights = 0;
            Console.WriteLine("Enter 1 or 3 or 5 to switch the light:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            switch (userNumber)         //User selects how many lights to switch on
            {
                case 1:
                    {
                        roomLights |= 1;
                        Console.WriteLine("You switched 1 light");
                        break;
                    }
                case 3:
                    {
                        roomLights |= 7;
                        Console.WriteLine("You switched 3 lights");
                        break;
                    }
                case 5:
                    {
                        roomLights |= 31;
                        Console.WriteLine("You switched 5 lights");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not valid value, please select from 1 or 3 or 5");
                        break;
                    }
            }

            int allLight = 31;
            roomLights |= allLight;      //System switch all the light
        }
    }
}
