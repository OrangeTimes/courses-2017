namespace VarianceInGenerics
{
	// Create 2 generic interfaces one with covariance and another with contravariance for generic type. 
	interface ICovariance<out T> where T : class, new()
	{
		T DoOperation();
	}
}