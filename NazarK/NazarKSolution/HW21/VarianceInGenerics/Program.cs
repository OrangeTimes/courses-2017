using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceInGenerics
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create example of usage for covariance and contravariance in generic interfaces.
			// Remember class implementations of generic interfaces do not support variance
			ICovariance<Derrived> covarianceDerrived = new CovarianceСlass<Derrived>();
			ICovariance<Base> covarianceBased = covarianceDerrived;

			IContravariance<Base> contravarianceBased = new ContravarianceClass<Base>();
			IContravariance<Derrived> contravarianceDerrived = contravarianceBased;
		}
	}
}
