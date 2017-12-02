using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM._10_Ex._3_User_input_to_a_file
{
    class Program
    {
        public static void Main(string[] args)
        {
            InputToFile(); 
        }

        /*
        Create a program which can write user input to a file. 
        If user didn’t specify extension .txt extension should be used. 
        Implement this using optional method parameters and File.WriteAllText method
        */

        /// <summary>
        /// A program that can write user input to a file.
        /// </summary>
        /// <param name="fileExtention"> Optional parameter. If entered incorrectly the method will prompt user to correct the extension later </param>
        public static void InputToFile(string fileExtention = ".txt") // todo: you should also pass in full path to file
        {
            Console.Write("Enter the text you want to save into file: "); 
            string userText = Console.ReadLine(); // todo: this logic should be done outside this method. In main method

            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            while  (fileExtention[0] != '.')       // prompt user to correct file extension in case user provided it incorrectly by himself as an optional parameter
            {
                Console.WriteLine("Please provide a valid file extension - that starts with dot (.)"); 
                fileExtention = Console.ReadLine(); // todo: this logic should be done outside this method. In main method
            }
                
            string fullFileName = fileName + fileExtention;
            File.WriteAllText(fullFileName, userText);
        }
    }
}
