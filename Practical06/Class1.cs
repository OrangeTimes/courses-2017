using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical06
{
	[Flags]
	public enum Settings
	{
		EnableTurbo = 1,
		UseNitro = 2,
		StalkerMode = 4,
		GodMode = 8
	}
	
	public enum Location
	{
		West,
		East,
		South,
		North
	}

	public class Class1
	{
		public static void Main()
		{
			Enums();
			Arrays();
		}

		public static void Enums()
		{
			Location location = Location.North;
			Console.WriteLine(location);
			// convertions
			Console.WriteLine((int)location);
			Console.WriteLine((Location)2);

			// usage in switches
			//Location loc = Location.East;
			//switch (loc)
			//   {
			//	case Location.North:
			//    {
			//			// logic here
			//			break;
			//    }
			//	case Location.South:

			//   }

		}

		public static void Arrays()
		{
			int[] myNumbers = {1, 45, 7895, 43, 43, 585};
			int sumOfElements = 0;
			// Length = 6
			// 0, 1, 2, 3, 4, 5,
			int lastElement = myNumbers[myNumbers.Length - 1];
			// v1 sum of elements
			foreach (int number in myNumbers)
			{
				sumOfElements += number;
				// sumOfElements = sumOfElements + number;
			}
			Console.WriteLine(sumOfElements);
			// v2 sum of elements
			int sumOfElementsForLoop = 0;
			for (int i = 0; i < myNumbers.Length; i++)
			{
				sumOfElementsForLoop += myNumbers[i];
			}
			Console.WriteLine(sumOfElementsForLoop);
			
			// Average calculated
			Console.WriteLine(sumOfElements / myNumbers.Length);
			Console.ReadKey();
			
			// foreach doesn't allow modification of iteration variable
			foreach (int number in myNumbers)
			{
				//number = 0;
			}

			// for allows iterated array modification
			for (int i = 0; i < myNumbers.Length; i++)
			{
				myNumbers[i] = 0;
			}

		}

	}
}
