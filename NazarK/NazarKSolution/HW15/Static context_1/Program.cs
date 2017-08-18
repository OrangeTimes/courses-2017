using System;

namespace Static_context_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Calculate Abs for two numbers
			Console.WriteLine($"Abs's are: {MyMath.Abs(9)} and {MyMath.Abs(-9.2)}");

			// Calculate Max for two numbers
			Console.WriteLine($"Max's are: {MyMath.Max(2, 9)} and {MyMath.Max(2.3, 2.2)}");

			// Calculate Min for two numbers
			Console.WriteLine($"Min's are: {MyMath.Min(2, 9)} and {MyMath.Min(2.3, 2.2)}");

			// Calculate Pow for two numbers
			Console.WriteLine($"Pow's are: {MyMath.Pow(2, 3)} and {MyMath.Pow(2.3, 2)}");

			// Calculate Sum for two numbers
			Console.WriteLine($"Sum's are: {MyMath.Sum(2, 3)} and {MyMath.Sum(2.3, 2)}");

			// Calculate Subtraction for two numbers
			Console.WriteLine($"Subtraction's are: {MyMath.Substruct(2, 3)} and {MyMath.Substruct(2.3, 2)}");
		}
	}
}
