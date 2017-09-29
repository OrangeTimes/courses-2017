using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical20
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 23;
			object y = x; // boxing
			int z = (int)y; // unboxing
			// Array list example
			ArrayList arrayList = new ArrayList();
			arrayList.Add(x); // boxing
			int unboxedValue = (int) arrayList[0]; // unboxing

			IEnumerable<int> myInumerable = new List<int>();
			IList<int> myNumbers = new List<int>();
			myNumbers.Add(3);
			myNumbers.Remove(3);
			Log(4.5, "Hello World");
			ArrayList arrayListFromFactory = Create<ArrayList>();

		}

		public IEnumerable<int> GetValues()
		{
			yield return 1;
			yield return 2;
			yield return 3;
		}

		public static void Log<T1,T2>(T1 value1, T2 value2) 
		{
			Console.WriteLine(value1);
			Console.WriteLine(value2);
		}

		public static T Create<T>() where T : class, new() 
		{
			T test = new T();
			return test;
		}


	}
}
