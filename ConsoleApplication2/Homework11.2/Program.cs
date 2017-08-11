using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11._2
{
    internal class Program
    {
        // 2.	 Write a program to write the best profit you could have made from 1 purchase and 1 sale 
        //buying and selling specific book in 1 week. 
        //a.Indexes in array indicate days past start day: [2] – Indicate that 2 days past from the start of week
        //b.The values are the book price in dollars at that day
        //c.You must buy before you sell. You may not buy and sell in the same day.
        //d.Try to iterate over array in most effective way
        //Example of input: int[] bookPricesLastWeek = { 11, 9, 6, 8, 13, 7, 10 }

        private static void Main(string[] args)
        {
            int[] bookPricesLastWeek = {11, 9, 6, 8, 13, 7, 10};
            int bestProfit = CalculateBestProfit(bookPricesLastWeek);
            Console.WriteLine($"Best Profit is {bestProfit}");
            Console.ReadLine();
        }

        private static int CalculateBestProfit(int[] bookPrices)
        {
            // declare variables
            int buy;
            int sell;
            int profit;
            // declare and ititialize best profit (same as profit of 1st iteration)
            int bestProfit = bookPrices[bookPrices.Length - 1] - bookPrices[bookPrices.Length - 2];

            // iterate through sell prices starting from the last day
            for (int i = 6; i > 0; i--)
            {

                // iterate through buy prices starting from the day before selling
                for (int j = i - 1; j >= 0; j--)
                {
                    sell = bookPrices[i];
                    buy = bookPrices[j];
                    // calculate profit
                    profit = sell - buy;

                    //remember the best profit
                    if (profit > bestProfit)
                    {
                        bestProfit = profit;
                    }
                }
            }
            return bestProfit;

        }
    }

}