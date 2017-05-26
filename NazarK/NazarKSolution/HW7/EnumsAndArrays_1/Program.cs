using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndArrays_1
{
	class Program
	{
		public enum PostalDeliveryMethod
		{
			// to avoid problem with zero index put first item = 1
			byRailway = 1,
			byPlane,
			bySea,
			byCar,
			byHyperLoop
		}
		static void Main(string[] args)
		{
			Console.Write("Please enter number of delivery method that you chose (from 1 to 5): ");

			// get user input
			string input = Console.ReadLine();

			// cast user input to enum
			PostalDeliveryMethod userDeliveryMethod = (PostalDeliveryMethod)Convert.ToInt32(input);
			Console.WriteLine($"You chose: {userDeliveryMethod}");
		}
	}
}