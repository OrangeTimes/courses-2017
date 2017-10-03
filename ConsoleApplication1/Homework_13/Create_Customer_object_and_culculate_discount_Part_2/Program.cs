using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Customer_object_and_culculate_discount_Part_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// from console specify the customer age
			Console.WriteLine("Please, specify your age: ");
			int CustomerAge = Convert.ToInt32(Console.ReadLine());
			//create new Customer class
			Customer myCustomer = new Customer();
			//output the discount
			Console.WriteLine($"For the user who is {CustomerAge} years old the discount is {myCustomer.calculateDiscount(CustomerAge)}");
			Console.ReadLine();
		}
	}
}
