using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical17
{
	class Program
	{
		static void Main(string[] args)
		{
			ICar myCar = new Car("Opel");
			//myCar.Drive();
			IVehicle myVehicle = (IVehicle)myCar;
			myVehicle.Drive();
			ICar mycustomBike = new CustomBike("Custom Bike");
			mycustomBike.Drive();

			IVehicle vehicle = new Car("Opel");
			vehicle.Drive();
			vehicle.Stop();
			ICar car = new Car("Opel");
			car.Drive();
			car.Stop();
		}
	}

	interface IVehicle
	{
		void Drive();
		void Stop();
	}

	interface ICar
	{
		void Drive();
		void Stop();
	}

	class Car : IVehicle, ICar
	{
		private string name;
		public Car(string name)
		{
			this.name = name;
		}

		void IVehicle.Drive()
		{
			Console.WriteLine($"Driving {name} from a IVehicle interface");
		}

		void IVehicle.Stop()
		{
			Console.WriteLine($"Stopping {name} from a IVehicle interface");
		}
		
		public void Drive()
		{
			Console.WriteLine($"Driving {name} from a ICar interface");
		}

		public void Stop()
		{
			Console.WriteLine($"Stopping {name} from a ICar interface");
		}

		public void Open()
		{
			Console.WriteLine($"Driving {name} from a ICar interface");
		}
	}

	class Bike : ICar
	{
		protected string name;
		public Bike(string name)
		{
			this.name = name;
		}
		
		public virtual void Drive()
		{
			Console.WriteLine($"Driving {name} from a Bike interface");
		}

		public virtual void Stop()
		{
			Console.WriteLine($"Stopping {name} from a Bike interface");
		}
	}

	class CustomBike : Bike
	{
		public CustomBike(string name) : base(name)
		{
		}

		public override void Drive()
		{
			Console.WriteLine($"Driving {name} from a CustomBike ");
		}

		public override void Stop()
		{
			Console.WriteLine($"Stopping {name} from a CustomBike ");
		}
		
	}
}
