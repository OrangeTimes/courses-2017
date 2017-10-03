using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Customer_object_and_culculate_discount_Part_2
{
	class Customer
	{
		public int CustomerAge;
		public int customerDiscount;
		// calculate customer discount
		public int calculateDiscount(int CustomerAge)
		{
			if (CustomerAge< 30)
			{
				customerDiscount = 10;
			}
			else if (CustomerAge >= 30 && CustomerAge< 50)
			{
				customerDiscount = 20;
			}
			else
			{
			customerDiscount = 30;
			}
			return customerDiscount;
		}
	}
}