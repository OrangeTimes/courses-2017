using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
	enum Power
	{
		On,
		Off
	}

	enum Player
	{
		Playing,
		Stopped
	}

	internal class Remote
	{
		protected Power power;
		protected Player player;
		protected int volume;

		public Remote()
		{
			power = Power.On;
			player = Player.Stopped;
			volume = 0;
		}
	}
}
