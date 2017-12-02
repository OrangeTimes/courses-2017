using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_isosceles_triangle_in_Console_Part_1
{
	class Program
	{
		// Write a program to create isosceles triangle in console by specifying its height
		// a.Value of height should be passed as command line parameter
		// Example for height of 4:
		//       *    
		//      ***   
		//     *****  
		//    ******* 
		static void Main(string[] args)
		{
			int input = 0;
			try
			{
				Console.Write("Enter number: ");
				input = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Draw_Isosceles_Triangle(input);
		}

		public static void Draw_Isosceles_Triangle(int num) // !!! You should avoid name with undescores in most method names
		{
			// Run all over the triangle

			for (int i = 0; i < num; i++)
			{
				for (int j = num - i; j > 0; j--)
					Console.Write(" ");
				// Draw asterisks and one space to get an isosceles triangle
				for (int j = 0; j <= i; j++)
					Console.Write("*" + " "); // no nned of string concatenation here just put it a single string 
				Console.WriteLine();
			}
			Console.ReadKey();
			// there is more mathematical solution to such problem
			// 1 row - 1 (1*2 - 1)
			// 2 row - 3 (2*2 - 1)
			// 3 row - 5 (3*2 - 1)
			// so knowing the row number we can predict number of asterix in it number of asterisks = (rowNumber * 2) - 1
			// Create a mehod callded called CreateTrianleRow(int rowNumber, int rowLength) which will do the heavy lifting

		}
	}
}