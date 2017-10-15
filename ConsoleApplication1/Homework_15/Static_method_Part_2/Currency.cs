using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method_Part_2
{
	public class Currency
	{
		private double cashAmount;
		private string currencyType;

		//create private constructor which is not allowed to use externally

		private Currency(double cashAmount, string currencyType)
		{
			this.cashAmount = cashAmount;
			this.currencyType = currencyType;
		}
		// use instead static method
		public static Currency Display (double cashAmount, string currencyType)
		{
			return new Currency(cashAmount, currencyType);
		}
		//output result
		public static void outputCurrency(Currency Currency)
		{
			Console.WriteLine($"Price = {Currency.cashAmount} {Currency.currencyType}.");
		}
	}
}