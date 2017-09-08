using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical18
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 4;
			int b = a;
			a = 3;
			Console.WriteLine(b);
			
			Animal dogA = new Dog();
			Animal dogB = dogA;
			dogA.Legs = 3;
			Console.WriteLine(dogB.Legs);

			// structs
			Cat catA = new Cat();
			catA.Legs = 4;
			Cat catB = catA;
			catA.Legs = 3;
			Console.WriteLine(catB.Legs);

		}
	}

	public abstract class Animal
	{
		public int Legs = 4;
		public abstract void Speak();
		
		public void Eat()
		{
			Console.WriteLine("Animal eat");
		}
	}

	public class Dog : Animal
	{
		
		public override void Speak()
		{
			Console.WriteLine("Dog speak");
		}
	}


	public struct Cat
	{
		public int Legs;
	}

}
