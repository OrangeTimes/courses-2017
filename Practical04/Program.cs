using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical04
{
	class Program
	{
		static void Main(string[] args)
		{
			//string name = Console.ReadLine();
			//switch (name)
			//{
			//	case "Diana":
			//	case "Denis":
			//	{
			//		Console.WriteLine("Hello {0}", name);
			//		break;
			//	}
			//	case "Ivan":
			//	{
			//		Console.WriteLine("Go away {0}", name);
			//		break;
			//	}
			//	default:
			//	{
			//		Console.WriteLine("{0}", name);
			//		break;
			//	}
			//}
			
			//string name2 = Console.ReadLine();
			//// for loops
			//for (int i = 0; i < name2.Length; i++)
			//{
			//	if (i % 2 == 0)
			//	{
			//		continue;
			//	}
			//	else
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
			
			Console.WriteLine("End");
			// do while
			int count = 0;
			do
			{
				Console.WriteLine("do while");
				count++;
				Console.WriteLine(count);
			} while (count > 5);
			
			// while
			int count2 = 0;
			while (count2 > 5)
			{
				Console.WriteLine("while");
				count2++;
				Console.WriteLine(count2);
			}
		}
	}
}
