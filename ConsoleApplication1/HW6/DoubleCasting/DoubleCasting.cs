using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCasting
{
    class DoubleCasting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter custom number: ");
            double userValue = Convert.ToDouble(Console.ReadLine());

            if (userValue == 0)
            {
                Console.WriteLine($"You have entered {userValue} which is WHOLE and REAL at same time");
            }

            else if (userValue == (int)userValue && userValue > 0)
            {
                Console.WriteLine($"You have entered {userValue} which is WHOLE");
            }

            else
            {
                Console.WriteLine($"You have entered {userValue} which is REAL");
            }

            Console.ReadKey();
        }
    }
}
