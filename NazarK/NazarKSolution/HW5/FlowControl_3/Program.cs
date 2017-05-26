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
			bool isValidName = false;
			string errorMessage = "User name is not valid.\nShould have more than 0 and less than 50 symbols.\n";

			while (!isValidName)
			{
				Console.Write("Enter a user name: ");
				string name = Console.ReadLine();

				if (name.Length > 0 && name.Length < 50)
				{
					isValidName = true;
				}
				else
				{
					Console.WriteLine(errorMessage);
				}
			}
		}
	}
}
