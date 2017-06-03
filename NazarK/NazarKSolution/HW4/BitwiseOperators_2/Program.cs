using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// turn off all lighs
			int roomLights = 0;

			// get user input in binary format of what to turn on
			Console.Write("Please enter which lights among 5 you want to enable (in binary format): ");
			string input = Console.ReadLine();

			// turn on certain lights and print result
			TurnOnLights(ref roomLights, input);

			// turn on all lights and print result
			Console.WriteLine("Turning on all the lights...");
			TurnOnLights(ref roomLights, "11111");
		}

		public static void TurnOnLights(ref int roomLights, string input)
		{
			// Convert input from binary to decimal and turn on all lights defined by user 
			roomLights |= Convert.ToInt32(input, 2);
			Console.WriteLine($"Current state of lights: {Convert.ToString(roomLights, 2)}\n");
		}
	}
}
