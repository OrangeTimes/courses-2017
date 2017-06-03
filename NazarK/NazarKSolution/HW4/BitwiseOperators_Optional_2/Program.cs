using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators_Optional_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variant2 - with math power

			// turn off all lighs
			int roomLights = 0;
			Console.Write("Please enter which lights among 5 you want to enable (in binary): ");
			string input = Console.ReadLine();

			// Convert input from binary to decimal and turn on all lights defined by user 
			TurnOnLights(ref roomLights, input);

			// Get sequence number of light to check
			int decimalPositionOfNumToCheck = GetDecimalPositionOfNumToCheck();

			// Use power of two to move 1 to same position as decimalPositionOfNumToCheck
			int numberInPowerOfTwo = GetNumInPowerOfTwo(decimalPositionOfNumToCheck);

			// Do bitwise 'and' with roomLights and decimanl shiftedNumberToCompare
			// it will return shiftedNumberToCompare only if shiftedNumberToCompare byte is 1
			bool isUserLightActive = CompareLights(roomLights, numberInPowerOfTwo);

			// Print results
			Console.WriteLine($"Current state of light: {isUserLightActive}\n");
		}

		public static bool CompareLights(int roomLights, int numberInPowerOfTwo)
		{
			return (roomLights & numberInPowerOfTwo) == numberInPowerOfTwo;
		}

		public static int GetNumInPowerOfTwo(int decimalPositionOfNumToCheck)
		{
			double powerOfBinaryTwo = Math.Pow(2, decimalPositionOfNumToCheck);
			int shiftedNumberToCompare = Convert.ToInt32(powerOfBinaryTwo);
			return shiftedNumberToCompare;
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
