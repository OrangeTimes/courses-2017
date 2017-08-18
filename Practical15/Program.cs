using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical15
{
	class Program
	{
		static void Main(string[] args)
		{
			MyStatic instance = new MyStatic();
			MyStatic instance2 = new MyStatic();
			int myIntInstance = instance2.myVariable;
			MyStatic.myVariableStatic = 100;
		}
	}
}
