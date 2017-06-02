using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_5_Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int i = 1; i<=101; ++i)  // used this loop to iterate, and then in each iteration added "-1" 
            {
                number = number + (-1);
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
