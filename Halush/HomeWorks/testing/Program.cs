using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


/*
Create an abstract class CardDeck. Create concrete class StandardCardDeck with 52 card. 
Create class StandardCard to represent single card. 
You need to implement an abstract method GetCard that will return you a random card from deck. 
Try not to create an array. 
Think of how to create card based on any given number.
Hint: You will probably need Math.Floor, casting, and Enums, and Random. 

Example of how to generate a random number between 0 (including) and 52 (excluding): 
Random random = newRandom();
int value = random.Next(0
*/


namespace testing
{
    enum CardType
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    enum Cards
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

    public class StandardCard
    {
        CardType cardType;
        Cards card;
    }

    public abstract class CardDeck
    {
        public StandardCard standardCard;
        public abstract void GetRandomCard();
        public abstract void GetAmountOfCards();
        
    }

    public class StandardCardDeck : CardDeck
    {

        public override void GetRandomCard()
        {
            Random random = new Random();
            int amountOfTypes = Enum.GetNames(typeof(CardType)).Length;
            int amountOfCards = Enum.GetNames(typeof(Cards)).Length;
            int randomNumberOfType = random.Next(0, amountOfTypes);
            int randomNumberOfCard = random.Next(0, amountOfCards);
            string type = Convert.ToString((CardType)randomNumberOfType);
            string card = Convert.ToString((Cards)randomNumberOfCard);
            Console.WriteLine("Your card is {0} of {1}", type, card);
        }

        public override void GetAmountOfCards()
        {
            int amountOfCards = Enum.GetNames(typeof(CardType)).Length * Enum.GetNames(typeof(Cards)).Length;
            Console.WriteLine(amountOfCards);
        }
    }


    public class Program
    {
        public static void Main()
        {
            CardDeck a = new StandardCardDeck();
            Console.ReadKey();
        }
    }
}

//Generates random number
//int b = 52;
//Random random = new Random();
//int random1 = random.Next(0, 52);

//Returns maximum number
//decimal a = 52;
//decimal c = Math.Floor(a);

//Get the amount of cards
//int cardsAmount = Enum.GetNames(typeof(CardType)).Length * Enum.GetNames(typeof(Cards)).Length;

