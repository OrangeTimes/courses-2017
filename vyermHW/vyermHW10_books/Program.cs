using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW10_books
{
	class Program
	{
		static int BooksAdd(int param, ref int BookAmount)
		{
			return BookAmount += param;
		}

		static int BooksReduce(int param, ref int BookAmount)
		{
			return BookAmount -= param;
		}
		
		static void Main(string[] args)
		{
			int BookAmount = 10;
			Console.WriteLine("Your amount of books was enlarged. Now you have {0} books", BooksAdd(5, ref BookAmount));
			Console.WriteLine("Your amount of books was reduced now. Now you have {0} books", BooksReduce(5, ref BookAmount));
			Console.ReadKey();
		}
	}
}