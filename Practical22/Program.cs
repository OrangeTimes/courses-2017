using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical22
{
	delegate int MyDelegate(int x, int y);

	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate hello = Add;
			hello += Subtract; //  Add + Subtract
			hello += (x, y) =>
			{
				return x + y;
			};

			int result = hello.Invoke(5, 4);
			var obj = new {MyX = 5, MyY = 6};
		}

		static int Add(int x, int y)
		{
			return x + y;
		}

		static int Subtract(int x, int y)
		{
			return x - y;
		}
	}


}
