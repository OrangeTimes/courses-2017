using System;

namespace Homework_5_Part_3
{
	class Program
	{
		static void Main(string[] args)
		// Write a program that will read user name and will check if it is a valid one (has more than 0 symbols and less than 50 symbols).
		// If the input is invalid it should write an error message and prompt for user name again until user enters a valid one.
		{
			Console.WriteLine("Please type the username: ");
			string typedName = Console.ReadLine();

			int length = typedName.Length; // todo you can skip this variable and use typedName only

			while (length == 0 || length > 50)
			{
				Console.WriteLine("Sorry, the name is invalid. Please try again");
				typedName = Console.ReadLine();
				length = typedName.Length;
			}
			//todo align next 2 statmenet with other code in vertical line 
				Console.WriteLine("Thank you!");
				Console.ReadLine();
		}
	}
}

