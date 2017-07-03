using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW7_enum
{
	public enum DeliveryMethod
	{
		Airplane = 1,
		Ship = 2,
		Post = 3,
		Train = 4,
		Courier = 5
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Which Delivery Method do you prefer? Please, select one of the following:");
			foreach (var value in Enum.GetValues(typeof(DeliveryMethod)))
			{
				Console.WriteLine("{0} - {1}", (int)value, ((DeliveryMethod)value));
			}

			string UserInput = Console.ReadLine();
			// user can inout either a number or the word (from small or capitalized letter)
			// I cannot handle exception when user inputs non-exiitng word, because we haven't learned try catch so far
			UserInput = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(UserInput);
			DeliveryMethod SelectedDelivery = (DeliveryMethod)Enum.Parse(typeof(DeliveryMethod), UserInput);

			switch (SelectedDelivery)
			{

				case DeliveryMethod.Airplane:
					Console.WriteLine("Airplane Delivery costs 25$");
					break;
				case DeliveryMethod.Courier:
					Console.WriteLine("Courier Delivery costs 30$");
					break;
				case DeliveryMethod.Train:
					Console.WriteLine("Train Delivery costs 15$");
					break;
				case DeliveryMethod.Post:
					Console.WriteLine("Post Delivery costs 10$");
					break;
				case DeliveryMethod.Ship:
					Console.WriteLine("Ship Delivery costs 20$");
					break;
				default:
					Console.WriteLine("Incorrect Delivery Method");
					break;
			}
			Console.ReadKey();
		}
	}
}
