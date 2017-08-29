using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to write the best profit you could have made from 1 purchase and 1 sale buying and selling specific book in 1 week.
a.Indexes in array indicate days past start day: [2] – Indicate that 2 days past from the start of week 
b.The values are the book price in dollars at that dayc. You must buy before you sell. 
You may not buy and sell in the same day. d.Try to iterate over array in most effective way  

Example of input: int[] bookPricesLastWeek = { 11, 9, 6, 8, 13, 7, 10 }
*/

namespace HW11_2
{
    class Program
    {
        static int GetBestProfit(int[] bookPricesWithinWeek)
        {
            int startPrice = 0;
            int endPrice = 0;
            int startProfit = 0;
            int bestProfit = 0;
            //Iterate from a first day
            for (int i = 0; i < bookPricesWithinWeek.Length; i++)
            {
                    //Iterate from a last day
                    for (int j = bookPricesWithinWeek.Length - 1; j > i; j--)
                    {
                        //Storing the lowest and the highest prices and a profit I can get
                        if (bookPricesWithinWeek[i] < bookPricesWithinWeek[j])
                        {
                            startPrice = bookPricesWithinWeek[i];
                            endPrice = bookPricesWithinWeek[j];
                            startProfit = endPrice - startPrice;
                                //Storing best profit I can get
                                if (bestProfit < startProfit)
                                {
                                    bestProfit = startProfit;
                                }
                        }
                    }
            }
            return bestProfit;
        }
        static void Main(string[] args)
        {
            int[] startPrices = new int[] {9, 5, 10, 2, 11, 12, 13};
            Console.WriteLine(GetBestProfit(startPrices));
            Console.ReadKey();
        }
    }
}
