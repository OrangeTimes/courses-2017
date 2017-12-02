using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Write an application to show content of txt file (use File.ReadAllText()) to console. 
            //Display proper messages to user in edge scenarios (file not present, empty path) 
            #region ask user info
            // ask info about file
            Console.Write("Specify path: ");
            string filePath = Console.ReadLine();

            Console.Write("Specify file name: ");
            string fileName = Console.ReadLine();

            Console.Write("Specify extension: ");
            string fileExtension = Console.ReadLine();
            #endregion

            Console.WriteLine(ShowFileContent(filePath, fileName, fileExtension));
            Console.ReadLine();
        }

        static string ShowFileContent(string filePath, string fileName, string fileExtension)
        {
            fileName = ValidateDot(fileName, fileExtension);
            string content = "";
            try
            {
	            
				// throw exception if one of parameters is blank
				if (filePath == "" | fileName == "" | fileExtension == "") // todo: there is separate method string.IsNullOrEmpty since string can be empty and can be null as a reference type
                {
                    throw new ArgumentException("Path, name cannot be blank.");
                }

                // build full file path with name and extension
                string path = $"{filePath}{fileName}.{fileExtension}"; // you are not using the string format shortcut effectively. I would expect it to look like this $"{filePath}{fileName}.{fileExtension}"
				content = File.ReadAllText(path);
            }
            #region catch block
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File was not found. \r\n" + ex.ToString());
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
            return content;

        }
		// todo: add empty line between method declarations
        // verify if file name or extension contains dot, if not - add dot
        static string ValidateDot(string fileName, string fileExtension)
        {
            if (fileName.Contains(".") | fileExtension.Contains(".")) // todo: in most cases you should use the conditional or || instead of |. Also you could invert the logcal condition here using ! in order to avoid empty code block
            { }
            else
            {
                fileName = fileName + ".";
            }
            return fileName;
        }

    }
}