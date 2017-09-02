using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// get user input
			Console.WriteLine("Select your remote type: Press 1 for TV, Press 2 for Blu-Ray player, Press 3 for Stereo Receiver, default is Stereo Receiver");
			int userInput = Convert.ToInt32(Console.ReadLine());

			// create a remote depends on user input
			IRemote userRemote;
			switch (userInput)
			{
				case 1:
					userRemote = new TV();
					break;
				case 2:
					userRemote = new BluRayPlayer();
					break;
				case 3:
				default:
					userRemote = new StereoReceiver();
					break;
			}

			// print some instruction to user
			Console.WriteLine(
				@"\nPress W key to increase and S key to decrease Volume.
				\nPress I to show status.
				\nPress E key to power on and D key to power off.
				\nPress Q key to play and A key to stop playing."
			);

			// control the player by remote
			while (userRemote.GetPowerState() == Power.On)
			{
				// create bindings for buttons on remote
				ConsoleKey pressedKey = Console.ReadKey().Key;
				Console.WriteLine();

				// do something based on pressed button
				switch (pressedKey)
				{
					case ConsoleKey.W:
						userRemote.VolumeUp();
						break;
					case ConsoleKey.S:
						userRemote.VolumeDown();
						break;
					case ConsoleKey.I:
						userRemote.PrintRemoteStatus();
						break;
					case ConsoleKey.E:
						userRemote.PowerOn();
						break;
					case ConsoleKey.D:
						userRemote.PowerOff();
						break;
					case ConsoleKey.Q:
						userRemote.Play();
						break;
					case ConsoleKey.A:
						userRemote.Stop();
						break;
				}
			}

			// print game over message
			Console.WriteLine("\nBye-bye");
		}
	}
}
