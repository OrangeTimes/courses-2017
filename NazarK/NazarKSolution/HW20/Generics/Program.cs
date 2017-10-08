using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1 PrintList
			List<string> myList = new List<string>() { "something", "another text", "yet another text" };
			PrintList(myList);

			// 2 ShiftList
			myList = ShiftList(myList, "the end");
			PrintList(myList);

			// 3 PrintStruct
			MyStruct myStruct = new MyStruct();
			myStruct.someValueInStruct = 2;
			PrintStruct(myStruct);
		}

		// Create a method that will output to console content of passed List 
		public static void PrintList<T>(List<T> list)
		{
			foreach (T item in list)
			{
				Console.WriteLine(item);
			}
		}

		// Create a method that will remove first element in passed in list and add a new value to the end of list.
		public static List<T> ShiftList<T>(List<T> list, T itemToAdd)
		{
			list.RemoveAt(0);
			list.Add(itemToAdd);
			return list;
		}

		// Create a generic method that accepts only struct values and displays them to console
		public static void PrintStruct<T>(T structToPrint) where T : struct
		{
			Console.WriteLine(structToPrint.ToString());
		}
	}

	public struct MyStruct
	{
		public int someValueInStruct;
		public override string ToString()
		{
			return $"Something: {someValueInStruct}";
		}
	}
}
