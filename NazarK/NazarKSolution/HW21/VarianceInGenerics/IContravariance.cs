namespace VarianceInGenerics
{
	// Create 2 generic interfaces one with covariance and another with contravariance for generic type. 
	interface IContravariance<in T>
	{
		void DoOperation(T input);
	}
}