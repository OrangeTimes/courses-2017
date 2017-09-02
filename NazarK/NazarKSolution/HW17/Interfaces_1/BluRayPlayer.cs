using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
	class BluRayPlayer : Remote, IRemote
	{
		public void Play()
		{
			Console.WriteLine("Blu-Ray Player is playing...");
			player = Player.Playing;
		}

		public Power GetPowerState()
		{
			return power;
		}

		public void PowerOff()
		{
			Console.WriteLine("Blu-Ray Player is powered off");
			power = Power.Off;
			player = Player.Stopped;
		}

		public void PowerOn()
		{
			Console.WriteLine("Blu-Ray Player is powered on");
			power = Power.On;
		}

		public void Stop()
		{
			Console.WriteLine("Blu-Ray Player has stopped playing...");
			player = Player.Stopped;
		}

		public void VolumeUp()
		{
			if (volume < 100)
			{
				volume += 5;
			}
			Console.WriteLine($"Blu-Ray Player volume is increased to {volume}");
		}

		public void VolumeDown()
		{
			if (volume > 0)
			{
				volume -= 5;
			}
			Console.WriteLine($"Blu-Ray Player volume is decreased to {volume}");
		}

		public void PrintRemoteStatus()
		{
			Console.WriteLine($"Blu-Ray Player is {power}, player is {player} and volume is {volume}");
		}
	}
}
