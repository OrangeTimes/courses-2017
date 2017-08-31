using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical16
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle myCar = new Car();
			myCar.Drive();
			myCar.Stop();
			}
		}
	}

	class Vehicle
	{
		protected int numberOfWheels;
		protected string name;
		
		public Vehicle(string name) : this(2, name)
		{
			//numberOfWheels = 2;
		}

		public Vehicle(int numberOfWheels) : this(numberOfWheels, "Opel")
		{
			//this.numberOfWheels = numberOfWheels;
		}

		public Vehicle(int numberOfWheels, string name)
		{
			this.name = name;
			this.numberOfWheels = numberOfWheels;
		}

		public virtual void Drive()
		{
			Console.WriteLine($"Driving {name} from a base class");
		}

		public virtual void Stop()
		{
			Console.WriteLine($"Stopping {name} from a base class");
		}
	}

	class Car : Vehicle
	{
		public Car() : base(4)
		{
			
		}

		public new void Drive()
		{
			Console.WriteLine($"Driving {name} from a child class");
		}

		public new void Stop()
		{
			Console.WriteLine($"Stopping {name} from a child class");
		}
	}

