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
			string name = "";
			UserName userName = UserName.Invalid;
			while (userName == UserName.Invalid)
			{
				name = Console.ReadLine();

				if (name.Length > 0 && name.Length < 50)
				{
					userName = UserName.Valid;
				}
				else
				{
					Console.Write("Name should have more than 0 and less than 50 symbols.\nPlease enter another user name: ");
				}
			}
			return name;
		}
	}
}
