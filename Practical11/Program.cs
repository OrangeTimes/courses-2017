using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical11
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 99; i++)
			{
				int x = 0;
			}

			MethodA(new []{8});

		}

		public static void MethodA(int[] value)
		{
			int x = 0;
			MethodB();
		}

		public static void MethodB()
		{
			int x = 0;
			MethodC();
		}

		public static void MethodC()
		{
			int x = 0;
		}
	}
}
