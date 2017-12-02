using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Books_amount_manage
{
	class Program
	// Write a program which manages books amount.You will need init it with starting amount of books.
	// And write 2 methods which can increase and decrease this amount. (use ref or out to implement this functionality)
	{
		static void Main(string[] args)
		{
			int booksAmount = 32;
			Console.WriteLine($"Initial amount of books: {booksAmount}");
			Console.WriteLine();
			// increase amount of books
		Increase(ref booksAmount,6); // !!!formatting Increase(ref booksAmount, 6); and code is not aligned
			Console.WriteLine($"Increased amount of books: {booksAmount}");
			// decrease amount of books
			Decrease(ref booksAmount,8); // !!!formatting Decrease(ref booksAmount, 8); and code is not aligned
			Console.WriteLine($"Decreased amount of books: {booksAmount}");
			Console.ReadLine();
		}
		static void Increase(ref int booksAmount, int increaseAmount) // add whitespace between method declarations
		{
			booksAmount += increaseAmount;
		}
		static void Decrease(ref int booksAmount, int decreaseAmount) // add whitespace between method declarations
		{
			booksAmount -= decreaseAmount;
		}
	}
}