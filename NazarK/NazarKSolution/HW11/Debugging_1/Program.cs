using System;
using System.Text;

namespace Debugging_1
{
	// Write a program to create isosceles triangle in console by specifying its height
	// Value of height should be passed as command line parameter
	//    *
	//   ***
	//  *****
	// *******
	//*********
	class Program
	{
		static void Main(string[] args)
		{
			// get height from command line parameter
			int height = Convert.ToInt32(args[0]);

			// print each row
			for (int rowNum = 1; rowNum <= height; rowNum++)
			{
				Console.WriteLine(BuildRowByNum(rowNum, height));
			}
		}

		static string BuildRowByNum(int rowNum, int height)
		{
			// define number of characters to append by row number
			int numOfSpaces = height - rowNum;
			int numOfAsterisks = rowNum * 2 - 1;

			// create instance of string builder to be able to append strings/chars
			StringBuilder sb = new StringBuilder();

			// append spaces and asterisks multiple times
			sb.Append(' ', numOfSpaces);
			sb.Append('*', numOfAsterisks);

			// return string from the string builder
			return sb.ToString();
		}
	}
}
