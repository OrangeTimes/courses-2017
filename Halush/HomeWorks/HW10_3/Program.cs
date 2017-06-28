using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Create a program which can write user input to a file. 
If user didn’t specify extension .txt extension should be used.
Implement this using optional method parameters and File.WriteAllText method
*/


namespace HW10_3
{
    class Program
    {
        static void WriteUserInputToAFile(string userText, string fileType = "txt")
        {
            switch (fileType)
            {
                case "txt":
                {
                    string path = @"C:\MyTxtFile.txt";
                    File.WriteAllText(path, userText);
                    break;
                }
                case "doc":
                {
                    string path = @"C:\MyDocFile.doc";
                    File.WriteAllText(path, userText);
                    break;
                }
                default:
                {
                    Console.WriteLine("Provided file extension is not supported.");
                    Console.ReadKey();
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text you want to be written to the file:");
            string userInput = Console.ReadLine();
            WriteUserInputToAFile(userInput);
        }
    }
}
