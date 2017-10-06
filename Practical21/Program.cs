using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practical21
{
	// Type T is declared covariant by using the out keyword.  
	


	class Program
	{
		
		public static IEnumerable<string> GetValues()
		{
			yield return "a";
			yield return "b";
			yield return "c";
		}

		static void Main(string[] args)
		{
			IEnumerable<object> objects = GetValues();
			HelloWorld<int> myHelloWorld = new HelloWorld<int>();
			myHelloWorld.Add(1235434564);
			HelloWorld<string> myHelloWorld2 = new HelloWorld<string>();
			myHelloWorld2.Add("1235434564");
			// Covariance
			IHelloWorld<string> hello = new Getter<string>();
			IHelloWorld<object> helloObjects = hello;
			// Contrvariance
			Action<object> actObj = x => Console.WriteLine("object: {0}", x);
			Action<string> actStr = actObj; // Action<object>
			Write(1);
		}

		public static void Write(object value)
		{
			
		}
	}

	class HelloWorld<T>
	{
		private List<T> t = new List<T>();

		public void Add(T item)
		{
			t.Add(item);
		}
	}

	interface IHelloWorld<out T>
	{
		T Get<T>();
	}

	class Getter<T> : IHelloWorld<T>
	{
		public T Get<T>()
		{
			throw new NotImplementedException();
		}
	}



}
