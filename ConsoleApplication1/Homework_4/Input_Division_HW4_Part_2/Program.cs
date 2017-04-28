using System;

namespace Homework_4_Part_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Exercise 2: You have 5 lights in room. Lights are controlled by microprocessor.Current state of lights is: 00000, 
			// where each slot corresponds to light state and is stored in int variable called roomLights; Create command to 
			// enable 1, 3, 5 light in the room using binary data and bitwise operators.

			//After it switch all the lights. 
			// To enable change you need to update value of roomLights variable.
			// Note: you can use next statement to convert int value to binary representation for output: string binaryForm = Convert.ToString(number, 2);

			int currentStateofRoomLights = 0;
			// enable 1,3,5
			Console.WriteLine("Enter which lights you would like to enable: ");
			int userInput = Convert.ToInt32(Console.ReadLine(), 2);

			currentStateofRoomLights |= userInput;
			string resultOfComparing = Convert.ToString(currentStateofRoomLights, 2);
			Console.WriteLine($"Current state: {resultOfComparing}");
			Console.ReadLine();
			//enable all lights
			Console.WriteLine("Please turn on all lights: ");
			int userInput2 = Convert.ToInt32("11111", 2);

			currentStateofRoomLights |= userInput2;
			string resultOfComparing2 = Convert.ToString(currentStateofRoomLights, 2);
			Console.WriteLine($"Current state: {resultOfComparing2}");
			Console.ReadLine();
		}
	}
}