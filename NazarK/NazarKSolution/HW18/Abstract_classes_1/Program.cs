using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// create new card deck
			StandardCardDeck myCardDeck = new StandardCardDeck();

			// print all cards in the deck
			Console.WriteLine("Printing all cards in the deck: ");
			myCardDeck.PrintAllCards();

			// get random card from the deck and print it
			StandardCard myCard = myCardDeck.GetCard();
			Console.WriteLine($"Printing random card from the deck: {myCard.ToString()}");
		}
	}
}
