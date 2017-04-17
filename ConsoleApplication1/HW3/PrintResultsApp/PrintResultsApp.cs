using System;

namespace PrintResultsApp
{
    class PrintResultsApp
    {
        static void Main(string[] args)
        {
            //first multiply, than sum
            Console.WriteLine("Calculate: -1 + 3 * 5 = {0}", -1 + 3 * 5);
            
            //first sum, than divide
            Console.WriteLine("Calculate: (24 + 5) % 7 = {0}", (24 + 5) % 7);
            
            //first multiply, than divide, than sum 
            Console.WriteLine("Calculate: 15 + -4 * 6 / 11 = {0}", 15 + -4 * 6 / 11);
            
            //divide, multiply, divide, sum, extract
            Console.WriteLine("Calculate: 2 + 10 / 6 * 1 - 7 % 2 = {0}", 2 + 10 / 6 * 1 - 7 % 2);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
