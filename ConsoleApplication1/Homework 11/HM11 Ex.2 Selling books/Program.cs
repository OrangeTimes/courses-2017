using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM11_Ex._2_Selling_books
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int[] bookPricesLastWeek = { 120, 121, 121, 121, 121, 121, 160 };
            BestProfit(bookPricesLastWeek);
            Console.ReadLine();

        }


        /*
        2. Write a program to write the best profit you could have made from 1 purchase and 1 sale buying and selling specific book in 1 week. 
              a.Indexes in array indicate days past start day: [2] –Indicate that 2 days past from the start of week 
              b.The values are the book price in dollars at that day
              c. You must buy before you sell. You may not buy and sell in the same day. 
              d.Try to iterate over array in most effective way  
        
        Example of input: int[] bookPricesLastWeek = { 11, 9, 6, 8, 13, 7, 10 }
        */


        /// <summary>
        /// Displays the best profit you could have made from 1 purchase and 1 sale buying and selling specific item in 1 week.
        /// You must buy before you sell. You may not buy and sell in the same day. 
        /// </summary>
        /// <param name="bookPricesLastWeek"> Use 7-item integer array </param>
        public static void BestProfit(int[] bookPricesLastWeek)
        {
            int buyPrice = bookPricesLastWeek[0];
            int sellPrice = bookPricesLastWeek[1];
            int profit = bookPricesLastWeek[1] - bookPricesLastWeek[0];


            for (int i = 0; i < bookPricesLastWeek.Length; i++) // itteration over buy prices
            {
                    for (int j = i + 1; j < bookPricesLastWeek.Length; j++) // itteration over sell prices, and making sure we don't sell the same day
                {
                    if (bookPricesLastWeek[j] - bookPricesLastWeek[i] > profit)  
                    {
                        buyPrice = bookPricesLastWeek[i];
                        sellPrice = bookPricesLastWeek[j];
                        profit = bookPricesLastWeek[j] - bookPricesLastWeek[i];
                    }
                }
            }
            Console.WriteLine("Best buy price: " + $"{buyPrice}"+ $"\n\n" + "Best sell price: " + $"{sellPrice}" + $"\n\n" + "Best profit: "+ $"{profit}");

        }
    }

}
