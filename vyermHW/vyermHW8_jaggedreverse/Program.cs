using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyermHW8_jaggedreverse
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] MyMultiArray = { { 1, 2, 3, 4, 5 }, { 11, 22, 33, 44, 55 }, { 111, 222, 333, 444, 555 }, { 1111, 2222, 3333, 4444, 5555 } };

			for (int row = MyMultiArray.GetLength(0) -1; row >=0; row--)
			{
				for (int col = MyMultiArray.GetLength(1) - 1; col >=0; col--)
				{
					Console.WriteLine(MyMultiArray[row, col]);
				}
			}
			Console.ReadKey();
		}
	}
}

