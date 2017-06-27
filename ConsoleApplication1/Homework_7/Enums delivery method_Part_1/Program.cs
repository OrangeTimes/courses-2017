using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_delivery_method_Part_1
{
	class Program
	{
		// You are developing postal delivery application write a program to get info of delivery method
		// and display it using enums. (User input can be provided as number)
		public enum deliveryMethod
		{
			Air_Delivery,
			Shipping,
			Train_Delivery,
			Mail_Delivery,
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Please specify delivery method (numeric value): ");
			deliveryMethod specifiedMethod = (deliveryMethod)Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"The selected delivery method is {specifiedMethod}");
            Console.ReadLine();
		}
	}
}

