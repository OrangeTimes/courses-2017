using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
	interface IRemote
	{
		//Power On, Power Off, Volume Up (max 100%), Volume Down (min 0%), Play, and Stop
		void PowerOn();
		Power GetPowerState();
		void PowerOff();
		void VolumeUp();
		void VolumeDown();
		void Play();
		void Stop();
		void PrintRemoteStatus();
	}
}
