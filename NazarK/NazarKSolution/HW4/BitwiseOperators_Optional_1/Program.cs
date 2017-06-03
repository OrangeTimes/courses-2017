using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators_Optional_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variant1 - with bitwise shift

			// turn off all lighs
			int roomLights = 0;
			Console.Write("Please enter which lights among 5 you want to enable (in binary format): ");
			string input = Console.ReadLine();

			// Convert input from binary to decimal and turn on all lights defined by user 
			TurnOnLights(ref roomLights, input);

			// Get sequence number of light to check
			int decimalPositionOfNumToCheck = GetDecimalPositionOfNumToCheck();

			// do bitwise shift to cut all digits after the one that we want to check
			int shiftedNumToCompare = BitwiseShift(roomLights, decimalPositionOfNumToCheck);

			// do bitwise 'and' with cutNumToCompare and decimanl 1
			// it will return decimal 1 only if last byte is byte 1
			bool isUserLightActive = CompareLights(shiftedNumToCompare);

			// Print result
			Console.WriteLine($"Current state of light: {isUserLightActive}\n");
		}

		private static bool CompareLights(int cutNumToCompare)
		{
			return (cutNumToCompare & 1) == 1;
		}

		private static int BitwiseShift(int roomLights, int decimalPositionOfNumToCheck)
		{
			return roomLights >> decimalPositionOfNumToCheck;
		}

		public static int GetDecimalPositionOfNumToCheck()
		{
			Console.Write("Please enter which lights you want to check: ");
			// get user input
			int sequentialNumberOfLightToCheck = Convert.ToInt32(Console.ReadLine());
			// mirror the input from right to left
			int decimalPositionOfNumToCheck = 5 - sequentialNumberOfLightToCheck;
			return decimalPositionOfNumToCheck;
		}

		public static void TurnOnLights(ref int roomLights, string input)
		{
			// Convert input from binary to decimal and turn on all lights defined by user 
			roomLights |= Convert.ToInt32(input, 2);
			Console.WriteLine($"Current state of lights: {Convert.ToString(roomLights, 2)}\n");
		}
	}
}
