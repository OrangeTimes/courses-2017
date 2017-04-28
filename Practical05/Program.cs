using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practical05
{
	class Program
	{
		static void Main(string[] args)
		{
			//// implicit
			//int x = 0;
			//object y = x;
			
			//// explicit
			//object a = 0;
			//int b = (int)a;

			int z = 10000;
			int s = 2;
			//byte result = checked ((byte)(z / s));
			// 4 octect int32 ....1000 10001000
			// 1 octet byte 10001000
			//byte result2 = Convert.ToByte(z / s);
			string input = "1,8";
			double d = Convert.ToDouble(input);
			//double d2 = Double.TryParse(input, )
		}
	}
}
