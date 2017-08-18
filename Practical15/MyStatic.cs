using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical15
{
	public class MyStatic
	{
		public int myVariable = 10;
		public static int myVariableStatic = 5;
		static MyStatic()
		{
			myVariableStatic = 20;
		}

		public MyStatic()
		{
			this.myVariable = 5;
		}
	}
}
