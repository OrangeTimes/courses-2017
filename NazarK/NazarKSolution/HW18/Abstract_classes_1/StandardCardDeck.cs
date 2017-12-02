using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_1
{
	internal class StandardCardDeck : CardDeck
	{
		internal override StandardCard GetCard()
		{
			// create random rank considering that rank is increasing after each 4th card
			Random random = new Random();
			int randomValue = random.Next(0, 52); 
			int rank = randomValue / 4;

			// create random suit considering that each 4 cards have different suit
			Suite suit = (Suite)(randomValue % 4);

			// return a card based on above
			StandardCard newCard = new StandardCard(suit, rank);
			return newCard;
		}

		internal void PrintAllCards()
		{
			for (int i = 0; i < 52; i++)
			{
				int rank = i / 4;
				Suite suit = (Suite)(i % 4);
				StandardCard newCard = new StandardCard(suit, rank);
				Console.WriteLine(newCard.ToString());
			}
		}
	}
}
