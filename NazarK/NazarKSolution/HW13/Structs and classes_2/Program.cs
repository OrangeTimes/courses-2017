using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_classes_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// get users year of birth
			Console.Write("Enter your year of birth: ");
			string userInput = Console.ReadLine();

			// declare new customer
			Customer myCustomer = new Customer(Convert.ToInt32(userInput));
			// print results
			Console.WriteLine($"Customer age is: {myCustomer.Age()}, and discount is: {myCustomer.GetDiscount()}.");
		}
	}
}
