using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
	internal abstract class Car
	{
		// speed and max speed vars
		protected int speed = 0;
		protected readonly int maxSpeed;
		protected int fuel = 20;

		// constructor
		public Car(int maxSpeed)
		{
			this.maxSpeed = maxSpeed;
		}

		// methods to increase and decrease speed. Use fuel only if speed is more than 0
		internal void Accelerate()
		{
			if (speed < maxSpeed)
			{
				speed += 10;
			}
			DecreaseFuel();
			PrintCurrentSpeed();
		}

		internal void Brake()
		{
			if (speed > 0)
			{
				speed -= 10;
				DecreaseFuel();
			}
			PrintCurrentSpeed();
		}

		// check if there is a fuel in car
		internal bool HasFuel()
		{
			if (fuel > 0)
			{
				return true; // in general avoid mutiple returns from single method
			}
			else
			{
				return false;
			}
		}

		// burn some fuel =)
		protected void DecreaseFuel()
		{
			fuel -= 1;
		}

		internal void IncreaseFuel()
		{
			fuel += 10;
		}

		// methods to print info about the car
		protected void PrintCurrentSpeed()
		{
			Console.WriteLine($"Current speed {speed}km/h");
		}

		protected void PrintCurrentFuel()
		{
			Console.WriteLine($"Fuel remaining {fuel} liters");
		}

		internal void PrintCarStatus()
		{
			Console.WriteLine($"Type: {this.GetType().Name}, Maximum speed: {maxSpeed}km/h");
			PrintCurrentFuel();
			PrintCurrentSpeed();
		}
	}
}
