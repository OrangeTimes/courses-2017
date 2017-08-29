using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_optional_method_parameters_Part_3
{
	class Program
	// Create a program which can write user input to a file.If user didn’t specify extension.txt extension should be used.
	// Implement this using optional method parameters and File.WriteAllText method.
	{
		static void Main(string[] args)
		{
			Console.Write("Please specify the file text: ");
			string inputText = Console.ReadLine();

			Console.Write("Please specify the file name: ");
			string fileName = Console.ReadLine();

			Console.Write("Please specify the file extension: ");
			string fileExtension = Console.ReadLine();

			// verification whether the extension is set 
			bool extensionSpecified = String.IsNullOrEmpty(fileExtension);

			if (extensionSpecified == true)
			{
				CreateFileAndSetText(inputText, fileName);
			}
			else
			{
				CreateFileAndSetText(inputText, fileName, fileExtension); // if the extension was not set then the file should be created with default extension (specified as an optional parameter)
			}
		}
		public static void CreateFileAndSetText(string inputText, string fileName, string fileExtention = ".txt")
		{
			string fileNameAndExtention = fileName + fileExtention;
			File.WriteAllText(fileNameAndExtention, inputText);
		}
	}
}
