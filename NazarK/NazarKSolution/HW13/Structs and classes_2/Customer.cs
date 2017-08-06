using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_classes_2
{
	public class Customer
	{
		private int yearOfBirth;

		// count customer age by year of birth
		public int Age()
		{
			int age = DateTime.Now.Year - yearOfBirth;
			return age;
		}

		// count customer discount by age
		public int GetDiscount()
		{
			int age = Age();
			int discount = 0;
			if (age < 30)
			{
				discount = 10;
			}
			else if (age >= 30 && age < 50)
			{
				discount = 20;
			}
			else if (age >= 50)
			{
				discount = 30;
			}
			return discount;
		}

		public Customer(int year)
		{
			yearOfBirth = year;
		}
	}
}
