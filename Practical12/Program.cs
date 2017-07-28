using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical12
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Exception();
			}
			
			catch (NotImplementedException e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		// since this method has 2 throws in it's body the line number in stacktrace will not be correct
		// https://stackoverflow.com/questions/2493779/wrong-line-number-on-stack-trace
		private static void Exception()
		{
			try
			{
				throw new NotImplementedException("This stuff was not implemented");
				//Console.WriteLine("In try block");
			}
			catch (NotImplementedException e)
			{
				Console.WriteLine(e);
				throw;
			}
			finally
			{
				Console.WriteLine("In finally block");
			}
			Console.WriteLine("After try catch block");
			Console.ReadKey();
		}
	}
}
