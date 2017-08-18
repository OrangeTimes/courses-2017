using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Practical14
{
	class Customer
	{
		private string firstName;
		private string lastName;

		public Customer(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}
		public Customer()
		{
			firstName = "Hello";
			this.lastName = "World";
		}
	}
}
