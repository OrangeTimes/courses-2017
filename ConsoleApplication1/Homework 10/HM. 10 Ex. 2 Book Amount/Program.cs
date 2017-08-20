using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM._10_Ex._2_Book_Amount
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookAmount = 0;
            IncreaseAmount(ref bookAmount);
            Console.WriteLine($"Increased book amount to: {bookAmount}");
            Console.ReadLine();

            DecreaseAmount(ref bookAmount);
            Console.WriteLine($"Decreased book amount to: {bookAmount}");
            Console.ReadLine();
        }


        /*
        Write a program which manages books amount. 
        You will need init it with starting amount of books. 
        And write 2 methods which can increase and decrease this amount. 
        (use ref or out to implement this functionality)
        */
        /// <summary>
        /// Increses initial amount of books by some user-provided value
        /// </summary>
        /// <param name="bookAmount"></param>
        public static void IncreaseAmount(ref int bookAmount)
        {
            Console.WriteLine("Plese provide a number of books you want to add: ");
            int increment = Convert.ToInt32(Console.ReadLine());
            bookAmount += increment;
        }

        /// <summary>
        /// Decreases initial amount of books by some user-provided value
        /// </summary>
        /// <param name="bookAmount"></param>
        public static void DecreaseAmount(ref int bookAmount)
        {
            Console.WriteLine("Plese provide a number of books you want to take out: ");
            int decrement = Convert.ToInt32(Console.ReadLine());
            bookAmount -= decrement;
        }
    }
}
