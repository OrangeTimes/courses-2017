using System;

namespace Debugging_2
{
	class Program
	{
		// Write a program to write the best profit you could have made from 1 purchase
		// and 1 sale buying and selling specific book in 1 week.

		// - Indexes in array indicate days past start day:
		// [2] – Indicate that 2 days past from the start of week

		// - The values are the book price in dollars at that day

		// - You must buy before you sell.You may not buy and sell in the same day.

		// - Try to iterate over array in most effective way
		// Example of input: int[] bookPricesLastWeek = { 11, 9, 6, 8, 13, 7, 10 }

		static void Main(string[] args)
		{
			// there is a more simpler solution to the problem see https://codereview.stackexchange.com/questions/169178/calculating-the-most-profit-from-an-array-of-stock-prices

			// define book prices
			int[] bookPricesLastWeek = { 1, 10, 2, 20, 3, 30, 60 };

			// initialize vars
			int buyingPrise = bookPricesLastWeek[0];
			int sellingPrise = bookPricesLastWeek[1];
			int profit = bookPricesLastWeek[0] - bookPricesLastWeek[1];

			// iterate over the prices to find the best buying price
			// don't do the last iteration for buying as we may not buy and sell in the same day anyway.
			for (int i = 0; i < bookPricesLastWeek.Length - 1; i++)
			{
				// optimize the process by skipping the iteration if next element has worse/same prices
				// not doing optimization for last element as it has no element to compare with (if remove will throw Exception)
				if (i < bookPricesLastWeek.Length - 1 && bookPricesLastWeek[i] >= bookPricesLastWeek[i + 1])
				{
					continue;
				}

				// iterate over the prices to find the best selling price
				// start iterating from the next day as we may not buy and sell in the same day.
				for (int j = i + 1; j < bookPricesLastWeek.Length; j++)
				{
					// speed up the process by skipping the iteration if next element has worse/same prices
					// not doing optimization for last element as it has no element to compare with (if remove will throw Exception)
					if (j < bookPricesLastWeek.Length - 1 && bookPricesLastWeek[j] <= bookPricesLastWeek[j + 1])
					{
						continue;
					}

					// compare the prices and reassign if better profit was found
					if (bookPricesLastWeek[j] - bookPricesLastWeek[i] > profit)
					{
						buyingPrise = bookPricesLastWeek[i];
						sellingPrise = bookPricesLastWeek[j];
						profit = bookPricesLastWeek[j] - bookPricesLastWeek[i];
					}
				}
			}

			// print the results to user
			Console.WriteLine($"The best:\n-Buying prise: {buyingPrise}\n-Selling prise: {sellingPrise}\n-Profit: {profit}");
		}
	}
}
