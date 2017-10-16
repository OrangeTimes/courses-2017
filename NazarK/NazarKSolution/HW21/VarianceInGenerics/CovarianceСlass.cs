using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceInGenerics
{
	class CovarianceСlass<T> : ICovariance<T> where T : class, new()
	{
		public T DoOperation()
		{
			return new T();
		}
	}
}
