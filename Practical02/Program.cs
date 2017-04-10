using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical02
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = "aaaa";
			string b = "bbbb";
			string domain = "example.com";
			string email2 = a + "_" + b + "@" + domain;
			string email = $"{a}_{b}@{domain}";
			int x = 0;
			int y = 0;
			int z = 3;
			int sum = x + y % z;
			Console.WriteLine(email);
			Console.ReadKey();
		}
	}
}
