using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Using_File.ReadAllText_and_Exception_Part_2
{
	class Program
	// Write an application to show content of txt file (use File.ReadAllText()) to console.
	// Display proper messages to user in edge scenarios (file not present, empty path).
	{
		static void Main(string[] args)
		{
			DisplayContent();
			Console.ReadLine();
		}
		public static void DisplayContent()
		{
			Console.WriteLine("Please specify a path to your file with extension: ");
			string path = Console.ReadLine();
			try
			{
				// if the file exist and path is correct - the text of the file will be displayed in console
				// in other cases, one of the specified exception will be thrown
				Console.WriteLine(File.ReadAllText(path));
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine("Error Message: path is null");
				Console.WriteLine(e.ToString());
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("Error Message: path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars");
				Console.WriteLine(e.ToString());
			}
			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine("Error Message: path specified a directory or the caller does not have the required permission.");
				Console.WriteLine(e.ToString());
			}
			catch (PathTooLongException e)
			{
				Console.WriteLine("Error Message: The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
				Console.WriteLine(e.ToString());
			}
			catch (DirectoryNotFoundException e)
			{
				Console.WriteLine("Error Message: The specified path is invalid (for example, it is on an unmapped drive).");
				Console.WriteLine(e.ToString());
			}
			catch (NotSupportedException e)
			{
				Console.WriteLine("Error Message: path is in an invalid format.");
				Console.WriteLine(e.ToString());
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine("Error Message: The file specified in path was not found.");
				Console.WriteLine(e.ToString());
			}
			catch (IOException e)
			{
				Console.WriteLine("Error Message: An I/O error occurred while opening the file. Path specified a file that is read - only or operation is not supported on the current platform.");
				Console.WriteLine(e.ToString());
			}
			catch (SecurityException e)
			{
				Console.WriteLine("Error Message: The caller does not have the required permission.");
				Console.WriteLine(e.ToString());
			}
		}
	}
}
