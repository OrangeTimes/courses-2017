using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical09
{
	class Program
	{
		static void Main(string[] args)
		{
			int result = 100 ;
			Sum(10, 20, out result);
			Sum(ref result);
			Console.WriteLine(result);
			// optional parameters
			int text = 0;
			int multiplyResult = Multiply(text);
		}

		static void Sum(int x, int y, out int result)
		{
			result = x + y;
			// return x + y;
		}

		static void Sum(ref int x)
		{
		}
		
		// optional and named parameters
		//static int Multiply(int arg1 = 0, int arg2 = 0)
		//{
		//	return arg1 * arg2;
		//}

		static int Multiply(int x = 0, int y = 0, int z = 0)
		{
			return x * y * z;
		}

		static int Multiply(int x = 0, int y = 0)
		{
			return x * y ;
		}

		static int Multiply(int x)
		{
			return x * x;
		}

		static int Multiply(ref int x)
		{
			return x * x;
		}

	}
}
