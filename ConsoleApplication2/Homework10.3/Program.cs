using System;
using System.Collections.Generic;
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
            Console.WriteLine("Specify file extension: ");
            string fileExtension = Console.ReadLine();

            //check if file extension is provided
            bool extensionNotSpecified = String.IsNullOrEmpty(fileExtension);

            //if file extension not provided - add txt extention
            if (extensionNotSpecified == true)
            {
                fileExtension = "txt";
            }

            //form filePath with extension
            string filePath = "C:/1." + fileExtension;

            //create file and write text to it
            File.WriteAllText(filePath, userInput);
        }
    }
}
