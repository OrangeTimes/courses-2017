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
			WriteAllTextToConsole(GetProjectPath() + "Hello World.txt");

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
			WriteAllTextToConsole(GetProjectPath() + "FakeFolder");

			// 7 Access Denied because file is being used by another program
			// adding 2 more statements to open and close stream, and True to not to overwrite a file
			StreamWriter writer = new StreamWriter(GetProjectPath() + "Hello World.txt", true);
			WriteAllTextToConsole(GetProjectPath() + "Hello World.txt");
			writer.Close();

			// 8 Added invisible character to file name so that it will fail
			WriteAllTextToConsole(@"‪C:\Test.txt");

			// 9 Causes any calling code for any PermissionSet that is not a subset of the current PermissionSet to fail. Next line after PermitOnly should fail
			PermissionSet perms = new PermissionSet(null);
			// get parent path before read because it will fail too early as next line after PermitOnly should fail
			string parentPath = GetProjectPath();
			perms.PermitOnly();
			WriteAllTextToConsole(parentPath + "Hello World.txt");
		}

		// adding header for exception messages
		public const string exceptionHeadingMessage = "\n\nFailed to read file on exception: \n";

		public static string GetProjectPath()
		{
			// find path to file in project folder 
			// get current folder
			string path = Environment.CurrentDirectory.ToString();
			// get path to grandfolder and add slashes
			string projectPath = Directory.GetParent(Directory.GetParent(path).ToString()) + "\\";
			return projectPath;
		}

		static void WriteAllTextToConsole(string path)
		{
			try
			{
				Console.WriteLine(File.ReadAllText(path));
			}

			catch (ArgumentNullException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (PathTooLongException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (DirectoryNotFoundException e)
			{
				Console.WriteLine(exceptionHeadingMessage + "Check if folder exists. " + e.Message);
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (IOException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (NotSupportedException e)
			{
				Console.WriteLine(exceptionHeadingMessage + e.Message);
			}
			catch (SecurityException e)
			{
				Console.WriteLine(exceptionHeadingMessage + "You have no permission to read from this file. " + e.Message);
			}
		}
	}
}
