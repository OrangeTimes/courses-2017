using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW4_boolean_lights
{
    class Program
    {
		static void Main(string[] args)
		{

			Console.WriteLine("All five lights are turned off. Press Enter");
			Console.ReadLine();

			int roomLightsOff = 0; //0 0000
			int roomLightsOn = 21; //1 0101
			int turnOnPart = roomLightsOff | roomLightsOn; //1 0101
			string binaryForm = Convert.ToString(turnOnPart, 2);

			Console.WriteLine("You have turned on first, third and fifth light. Press Enter");
			Console.WriteLine(binaryForm);
			Console.ReadLine();

			int turnOnFull = 31; //1 1111   
			int turnOnAll = turnOnPart | turnOnFull; //1 1111
			binaryForm = Convert.ToString(turnOnAll, 2);
			Console.WriteLine("Now you have turned on all the lights. Have fun :)");
			Console.WriteLine(binaryForm);
			Console.WriteLine("If you want to check status of your lamps, click Enter");
			Console.ReadLine();

			for (int i = 5; i > 0; --i)
			{
				Console.WriteLine("{0}:{1}", 6 - i, (turnOnAll & 1) == 1);
				turnOnAll = turnOnAll >> 1;
			}

			bool checkLights = (turnOnAll & 31) == 31;
			Console.ReadLine();
		}
	}
}
