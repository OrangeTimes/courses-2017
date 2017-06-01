using System;

namespace LoopAllNegatives
{
    class LoopAllNegatives
    {
        static void Main(string[] args)
        {
            for (int i = -1; i >= -100; i--)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
