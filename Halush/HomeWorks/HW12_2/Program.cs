using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Write an application to show content of txt file (use File.ReadAllText()) to console. 
Display proper messages to user in edge scenarios (file not present, empty path)
D:\WriteText.txt
*/

namespace HW12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a path to a file:");
                string path = Console.ReadLine();
                string text = File.ReadAllText(path);
                Console.WriteLine("File contain next text:");
                Console.WriteLine(text);
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File you are looking for doesn't exist.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid path. Such directory doesn't exist.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized access. Access is denied.");
            }
            Console.ReadKey();
        }
    }
}
