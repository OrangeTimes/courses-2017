using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.Create a program which can write user input to a file. 
            //If user didn’t specify extension.txt extension should be used.
            //Implement this using optional method parameters and File.WriteAllText method

            // ask user to add text and file extension
            Console.WriteLine("Please add text: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Specify path: ");
            string path = Console.ReadLine();
            Console.WriteLine("Please file name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Specify file extension: ");
            string fileExtension = Console.ReadLine();

            string filePathAndName = path + fileName;
            
            
            //check if file extension is provided
            bool extensionSpecified = String.IsNullOrEmpty(fileExtension);

            //create file and write text to it
            if (extensionSpecified == true) // todo: check  ==true is redundant here
            {
                CreateFileWithText(userInput, filePathAndName);
            }
            else
            {
                CreateFileWithText(userInput, filePathAndName, fileExtension);
            }
        }

        static void CreateFileWithText(string userInput, string pathAndName, string fileExtension = ".txt")
        {
            string filePathNameExtension = pathAndName + fileExtension;
            File.WriteAllText(filePathNameExtension, userInput);
        }


    }
}
