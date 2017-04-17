using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            // todo text comment should have a whitespace between comment sign \\ and comment text. Except commented out code. Same below
            Console.Write("Please enter comma separated values for dividend and divisor: ");
            string[] parts = Console.ReadLine().Split(',');
            int dividend = Convert.ToInt32(parts[0]);
            int divisor = Convert.ToInt32(parts[1]);
            Console.WriteLine($"Output: {(dividend % divisor == 0)}\n");

            //Task2
            int roomLights = 0;
            Console.Write("Please enter which lights among 5 you want to enable (in binary): ");
            string input = Console.ReadLine();
            roomLights |= Convert.ToInt32(input, 2);
            Console.WriteLine($"Current state of lights: {Convert.ToString(roomLights, 2)}\n");
            Console.WriteLine("Turning on all the lights...");
            roomLights |= Convert.ToInt32("11111", 2);
            Console.WriteLine($"Current state of lights: {Convert.ToString(roomLights, 2)}\n");

            //Optional - common
            int lightNumToCheck;
            bool isUserLightActive;
            // todo: This is a valid statement, but it is not recommnded to us it as a code convention rule. Move declarations as close to assignment as possible

            //Optional - Variant1 - with bitwise shift
            roomLights = 0;
            Console.Write("Please enter which lights among 5 you want to enable (in binary): ");
            input = Console.ReadLine();
            roomLights |= Convert.ToInt32(input, 2);
            Console.Write("Please enter which light you want to check: ");
            lightNumToCheck = Convert.ToInt32(Console.ReadLine());
            isUserLightActive = ((roomLights >> 5 - lightNumToCheck) & 1) == 1;
            // as a coding practice it makes sense to split such not trivial expressions to multiple variables
            // also try to avoid 'roomLights >> 5 - lightNumToCheck' it takes time for other developer to figure out what is the actual operator execution will be.
            // It is often a potential place for defects. Use (roomLights >> (5 - lightNumToCheck)) to explicitly show your intent
            Console.WriteLine($"Current state of light: {isUserLightActive}\n");

            //Optional - Variant2 - with math power
            roomLights = 0;
            Console.Write("Please enter which lights among 5 you want to enable (in binary): ");
            input = Console.ReadLine();
            roomLights |= Convert.ToInt32(input, 2);
            Console.Write("Please enter which light you want to check: ");
            lightNumToCheck = Convert.ToInt32(Console.ReadLine());
            isUserLightActive = (roomLights & (int)Math.Pow(2, 5 - lightNumToCheck)) == Math.Pow(2, 5 - lightNumToCheck);
            // todo: move Math.Pow(2, 5 - lightNumToCheck) to a separate variable. it will simplify this expression a lot
            Console.WriteLine($"Current state of light: {isUserLightActive}\n");
        }
    }
}