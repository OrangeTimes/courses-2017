using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace HM12_Ex._2_TXT_content_to_console
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowContent();
            Console.ReadLine();

        }

        /*
        2. Write an application to show content of txt file (use File.ReadAllText()) to console. 
        Display proper messages to user in edge scenarios (file not present, empty path)
        */

        /// <summary>
        /// This method opens a file, reads each line of the file, and then adds each line as an element of a string. It then closes the file. 
        /// The resulting string does not contain the terminating carriage return and/or line feed.
        /// This method attempts to automatically detect the encoding of a file based on the presence of byte order marks.Encoding formats UTF-8 and UTF-32 can be detected.
        /// Displays proper messages to user in edge scenarios (file not present, empty path, etc)
        /// </summary>
        public static void ShowContent()
        {
            Console.WriteLine("Please provide a path to your file with extension: ");
            string path = Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            // The following catch blocks will catch exceptions in order from most to least specific and print out some textual information and actual error text.
			// todo: avoid long statements, span them over few lines in needed
            catch (SecurityException e) { Console.WriteLine("\n The caller does not have the required permission.\n"); Console.WriteLine(e.ToString()); }
            catch (NotSupportedException e) { Console.WriteLine("\n Path is in an invalid format.\n"); Console.WriteLine(e.ToString()); }
            catch (FileNotFoundException e) { Console.WriteLine("\n The file specified in path was not found.\n"); Console.WriteLine(e.ToString()); }
            catch (UnauthorizedAccessException e) { Console.WriteLine("\n Path specified a file that is read-only \n- or -This operation is not supported on the current platform. \n- or - path specified a directory. \n- or - The caller does not have the required permission. \n"); Console.WriteLine(e.ToString()); }
            catch (PathTooLongException e) { Console.WriteLine("\n The specified path, file name, or both exceed the system-defined maximum length. \n For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.\n"); Console.WriteLine(e.ToString()); }
            catch (DirectoryNotFoundException e) { Console.WriteLine("\n The specified path is invalid (for example, it is on an unmapped drive). \n"); Console.WriteLine(e.ToString()); }
            catch (IOException e) { Console.WriteLine("\n An I/O error occurred while opening the file. \n"); Console.WriteLine(e.ToString()); }
            catch (ArgumentNullException e) { Console.WriteLine("\n Path is null. \n"); Console.WriteLine(e.ToString()); }
            catch (ArgumentException e) { Console.WriteLine("\n Path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars. \n"); Console.WriteLine(e.ToString()); }
        }
    }
}
