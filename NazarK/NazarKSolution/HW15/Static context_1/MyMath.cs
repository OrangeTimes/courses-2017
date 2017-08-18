namespace Static_context_1
{
	internal static class MyMath
	{
		internal static int Abs(int num)
		{
			return num > 0 ? num : num * -1;
		}

		internal static double Abs(double num)
		{
			return num > 0 ? num : num * -1;
		}

		internal static int Max(int num1, int num2)
		{
			return num1 > num2 ? num1 : num2;
		}

		internal static double Max(double num1, double num2)
		{
			return num1 > num2 ? num1 : num2;
		}

		internal static int Min(int num1, int num2)
		{
			return num1 < num2 ? num1 : num2;
		}

		internal static double Min(double num1, double num2)
		{
			return num1 < num2 ? num1 : num2;
		}

		internal static int Pow(int num, int pow)
		{
			for (int i = 0; i < pow; i++)
			{
				num *= num;
			}
			return num;
		}

		internal static int Substruct(int num1, int num2)
		{
			return num1 - num2;
		}

		internal static double Substruct(double num1, double num2)
		{
			return num1 - num2;
		}

		internal static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}

		internal static double Sum(double num1, double num2)
		{
			return num1 + num2;
		}

		internal static double Pow(double num, int pow)
		{
			for (int i = 0; i < pow; i++)
			{
				num *= num;
			}
			return num;
		}
	}
}
