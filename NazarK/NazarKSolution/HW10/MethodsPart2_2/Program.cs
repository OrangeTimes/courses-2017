using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_2
{
	class Program
	{
		// Write a program which manages books amount.
		// You will need initialize it with starting amount of books.
		// And write 2 methods which can increase and decrease this amount.
		// (use ref or out to implement this functionality)

		static void Main(string[] args)
		{
			// number of books at start
			int amountOfBooks = 5;
			Console.WriteLine($"Number of books at start: {amountOfBooks}");

			// increase number of books by 2
			IncreaseBooksAmount(ref amountOfBooks, 2);
			Console.WriteLine($"Number of books after increase by 2: {amountOfBooks}");

			// decrease number of books by 3
			DecreaseBooksAmount(ref amountOfBooks, 3);
			Console.WriteLine($"Number of books after decrease by 3: {amountOfBooks}");
		}

		static void IncreaseBooksAmount(ref int amountOfBooks, int numToIncrease)
		{
			amountOfBooks += numToIncrease;
		}

		static void DecreaseBooksAmount(ref int amountOfBooks, int numToDecrease)
		{
			amountOfBooks -= numToDecrease;
		}
	}
}
