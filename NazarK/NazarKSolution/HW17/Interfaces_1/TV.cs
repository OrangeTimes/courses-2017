﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
	class TV : Remote, IRemote
	{
		public void Play()
		{
			Console.WriteLine("TV is playing...");
			player = Player.Playing;
		}

		public Power GetPowerState()
		{
			return power;
		}

		public void PowerOff()
		{
			Console.WriteLine("TV is powered off");
			power = Power.Off;
			player = Player.Stopped;
		}

		public void PowerOn()
		{
			Console.WriteLine("TV is powered on");
			power = Power.On;
		}

		public void Stop()
		{
			Console.WriteLine("TV has stopped playing...");
			player = Player.Stopped;
		}

		public void VolumeUp()
		{
			if (volume < 100)
			{
				volume += 5;
			}
			Console.WriteLine($"TV volume is increased to {volume}");
		}

		public void VolumeDown()
		{
			if (volume > 0)
			{
				volume -= 5;
			}
			Console.WriteLine($"TV volume is decreased to {volume}");
		}

		public void PrintRemoteStatus()
		{
			Console.WriteLine($"TV is {power}, player is {player} and volume is {volume}");
		}
	}
}
