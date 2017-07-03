using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW5_username
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your username here:");
			string userName = Console.ReadLine();
			bool invalidUserName = userName.Length <= 0 || userName.Length >= 50;

			while (invalidUserName)
			{
				Console.WriteLine("Your name should have at least one symbol but no more than 50 symbols.");
				Console.WriteLine("Please, enter your name again:");
				userName = Console.ReadLine();
				invalidUserName = userName.Length <= 0 || userName.Length >= 50;
			}
			Console.WriteLine("Thank you.");
			Console.ReadKey();
		}
	}
}