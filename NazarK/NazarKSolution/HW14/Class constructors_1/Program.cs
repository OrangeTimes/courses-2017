using System;

namespace Class_constructors_1
{
	class Program
	{
		// 1.Write a program that will create a car with few different options
		// (manufacturer, year of manufacture, price those are mandatory).
		// Create 3 different cars and output it values to console 
		// (Hint: you can use a separate method in your class for that). 
		static void Main(string[] args)
		{
			// Create 3 Cars using constructor with 3 fields
			Car rollsRoycePhantop = new Car("Rolls Royce", 2017, 1000000.01);
			Car BMWX6= new Car("BMW X6", 2016, 900000.02);
			Car ferrariLaFerrari = new Car("Ferrari", 2015, 3000000.03);

			// Print Cars to console
			Console.WriteLine(rollsRoycePhantop.ToString());
			Console.WriteLine(BMWX6.ToString());
			Console.WriteLine(ferrariLaFerrari.ToString());
		}
	}
}
