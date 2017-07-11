using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW10_writetofile
{
	class Program
	{
		public static void WriteAllText(string contents, string path = "E:\\newfile.txt")
		{
			File.WriteAllText(path, contents);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Please provide any text:");
			string contents = Console.ReadLine();
			Console.WriteLine("Please provide path and extension of file for saving; Click Enter to leave defaults:");
			string path = Console.ReadLine();
			
			if (string.IsNullOrEmpty(path))
			{
				WriteAllText(contents);
			}
			else
			{
				WriteAllText(contents, path);
			}
		}
	}
}