using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace Exception_Handling_2
{
	// Write an application to show content of .txt file(use File.ReadAllText()) to console.
	// Display proper messages to user in edge scenarios (file not present, empty path)
	class Program
	{
		static void Main(string[] args)
		{
			// correct file path and name
			WriteAllTextToConsole("Hello World.txt");

			// 1 path is null
			WriteAllTextToConsole(null);

			// 2 empty path
			WriteAllTextToConsole("");

			// 3 file name is longer then 260 symbols
			WriteAllTextToConsole("Is post each that just leaf no. He connection interested so we an sympathize advantages. To said is it shed want do. Occasional middletons everything so to. Have spot part for his quit may. Enable it is square my an regard. Often merit stuff first oh up hills.");

			// 4 folder doesn't exist
			WriteAllTextToConsole(@"fake/fake.txt");

			// 5 file doesn't exist
			WriteAllTextToConsole("fake.txt");

			// 6 Access Denied because file is actually a folder
			WriteAllTextToConsole("FakeFolder");

			// 7 Access Denied because file is being used by another program
			// adding 2 more statements to open and close stream, and True to not to overwrite a file
			StreamWriter writer = new StreamWriter("Hello World.txt", true);
			WriteAllTextToConsole("Hello World.txt");
			writer.Close();

			// 8 Added invisible character to file name so that it will fail
			WriteAllTextToConsole(@"‪C:\Test.txt");

			// 9 Causes any calling code for any PermissionSet that is not a subset of the current PermissionSet to fail
			PermissionSet perms = new PermissionSet(null);
			perms.PermitOnly();
			WriteAllTextToConsole("Hello World.txt");
		}

		static void WriteAllTextToConsole(string path)
		{
			try
			{
				Console.WriteLine(File.ReadAllText(path));
			}

			catch (ArgumentNullException e)
			{
				Console.WriteLine("\nCatch 1: " + e.Message);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("\nCatch 2: " + e.Message);
			}
			catch (PathTooLongException e)
			{
				Console.WriteLine("\nCatch 3: " + e.Message);
			}
			catch (DirectoryNotFoundException e)
			{
				Console.WriteLine("\nCatch 4: " + "Check if folder exists. " + e.Message);
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine("\nCatch 5: " + e.Message);
			}
			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine("\nCatch 6: " + e.Message);
			}
			catch (IOException e)
			{
				Console.WriteLine("\nCatch 7: " + e.Message);
			}
			catch (NotSupportedException e)
			{
				Console.WriteLine("\nCatch 8: " + e.Message);
			}
			catch (SecurityException e)
			{
				Console.WriteLine("\nCatch 9: " + "You have no permission to read from this file. " + e.Message);
			}
		}
	}
}
