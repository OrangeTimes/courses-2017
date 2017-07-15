using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_3
{
	class Program
	{
		// Create a program which can write user input to a file.
		// If user didn’t specify extension the .txt extension should be used.
		// Implement this using optional method parameters and File.WriteAllText method

		static void Main(string[] args)
		{
			// Get user input on all points
			Console.Write("Enter the text you want to save into file: ");
			string userText = Console.ReadLine();

			Console.Write("Enter the desired file name: ");
			string fileName = Console.ReadLine();

			Console.Write("Enter the desired file extension(optional): ");
			string fileExtention = Console.ReadLine();

			// Create file with user extension or with default if it was not specified
			if (fileExtention.Length == 0)
			{
				WriteUserInputToFile(userText, fileName);
			}
			else
			{
				WriteUserInputToFile(userText, fileName, fileExtention);
			}
		}

		static void WriteUserInputToFile(string userText, string fileName, string fileExtention = "txt")
		{
			// add dot separator if user didn't add it
			fileExtention = ValidateSeparatorDot(fileExtention);

			// create file name and write data
			string fullFileName = fileName + fileExtention;
			File.WriteAllText(fullFileName, userText);
		}

		// add dot separator if user didn't add it
		static string ValidateSeparatorDot(string fileExtention)
		{
			if (fileExtention[0] != '.')
			{
				fileExtention = '.' + fileExtention;
			}
			return fileExtention;
		}
	}
}
