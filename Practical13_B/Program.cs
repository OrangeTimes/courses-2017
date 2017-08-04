using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practical13_A;

namespace Practical13_B
{
	public class PostalAdresss2 : Adresss
	{
		public string GetPostalAdress()
		{
			return Country + " " + City;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Adresss myAdress = new Adresss();
			
		}
	}
}
