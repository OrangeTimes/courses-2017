using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    public enum CardType
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public enum Cards
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public abstract class CardDeck : StandardCard
    {
        public abstract void GetRandomCard();
    }

    public class StandardCardDeck : CardDeck
    {
        public override void GetRandomCard()
        {
            Random random = new Random();
            //Get length of the enums
            int amountOfTypes = Enum.GetNames(typeof(CardType)).Length;
            int amountOfCards = Enum.GetNames(typeof(Cards)).Length;
            //Get random number of each enum
            int randomNumberOfType = random.Next(0, amountOfTypes);
            int randomNumberOfCard = random.Next(0, amountOfCards);
            //Create card object and assign random type and card to it
            StandardCard standardCard = new StandardCard()
            {
                cardType = (CardType)randomNumberOfType,
                card = (Cards)randomNumberOfCard
            };
            Console.WriteLine("Your card is {0} of {1}", Convert.ToString(standardCard.card), Convert.ToString(standardCard.cardType));
        }
    }

    public class StandardCard
    {
        public CardType cardType;
        public Cards card;
    }

    public class Program
    {
        public static void Main()
        {
            StandardCardDeck myDeck = new StandardCardDeck();
            myDeck.GetRandomCard();
            Console.ReadKey();
        }
    }
}
