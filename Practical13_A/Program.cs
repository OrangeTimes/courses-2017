using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical13_A
{
	public struct Point
	{
		public int X;
		public int Y;
	}

	public class Adresss
	{
		public string Country;
		protected internal string City;

		public string GetLocation()
		{
			return Country + " " + City;
		}
	}

	public class PostalAdresss : Adresss
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
			// struct
			Point myPoint = new Point();
			myPoint.X = 1;
			myPoint.X = 7;
			myPoint.X = 9;
			myPoint.Y = 4;

			Point myPoint2 = new Point
			{
				X = 0, Y = 8
			};

			// class
			Adresss adress = new Adresss();
			adress.City = "Lviv";
			adress.Country = "Ukraine";
			
			myPoint.X = 0;
		}
	}
}
