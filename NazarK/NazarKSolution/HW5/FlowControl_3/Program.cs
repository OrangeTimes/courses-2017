using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a user name: ");

			// ask user for input until it's valid
			string validUserName = GetValidUserName();
			Console.WriteLine($"User name is: {validUserName}");
		}

		public enum UserName
		{
			Valid,
			Invalid
		}

		private static string GetValidUserName()
		{
			string name;
			UserName userName;
			do
			{
				// get user input
				name = Console.ReadLine();

				// check if username is valid
				if (name.Length > 0 && name.Length < 50)
				{
					userName = UserName.Valid;
				}
				else
				{
					userName = UserName.Invalid;
					Console.Write("Name should have more than 0 and less than 50 symbols.\nPlease enter another user name: ");
				}
			} while (userName == UserName.Invalid);
			return name;
		}
	}
}
