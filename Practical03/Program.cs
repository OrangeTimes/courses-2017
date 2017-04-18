using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical03
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 7;//0111
			int y = 3;//0011
			int z = x ^ y;//0100
			bool isVisible = (!Check01() & Check02());
		}

		static bool Check01()
		{
			return true;
		}

		static bool Check02()
		{
			return true;
		}
	}
}
