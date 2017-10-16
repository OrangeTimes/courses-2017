using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceInGenerics
{
	class ContravarianceClass<T> : IContravariance<T>
	{
		public void DoOperation(T input)
		{
			Console.WriteLine(input.ToString());
		}
	}
}
