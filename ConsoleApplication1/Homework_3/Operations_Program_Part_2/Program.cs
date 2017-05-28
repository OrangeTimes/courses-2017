using System;

namespace Operations_Program_Part_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y;
			char operation;

			// Example: Input first number: 12
						// Input operation: +
						// Input second number: 3
						// Expected Output : 12 + 3 = 15

			Console.Write("Input first number: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input operation: ");
			operation = Convert.ToChar(Console.ReadLine());
			Console.Write("Input second number: ");
			y = Convert.ToInt32(Console.ReadLine());
			// todo it's better to use swithc in this case
			if (operation == '+')
				Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
			else if (operation == '-')
				Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
			else if ((operation == 'x') || (operation == '*'))
				Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
			else if (operation == '/')
				Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
			else if (operation == '%')
				Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);
			else
				Console.WriteLine("Incorrect Character");
			Console.ReadLine();

			// Another implementation
			// all operations will be displayed after entering two numbers: Example: Input first number: 6
																				// Input second number: 6
																				// 6 + 6 = 12
																				// 6 - 6 = 0
																				// 6 * 6 = 36
																				// 6 / 6 = 1
																				// 6 mod 6 = 0
			Console.Write("Input first number: ");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input second number: ");
			int b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
			Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
			Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
			Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
			Console.WriteLine("{0} mod {1} = {2}", a, b, a % b);  
			Console.ReadLine();
		}
	}
}

	