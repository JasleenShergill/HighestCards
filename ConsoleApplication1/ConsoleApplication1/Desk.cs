using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Jasleen
 * Date: July 27, 2017
 * Description:  Deck class
 * It inherits from the List generic and uses Card as the base type
 * Version: 0.5 - Refactored the toString method
 */

namespace ConsoleApplication1
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {

            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES

        // PRIVATE METHODS

        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        protected override void _initialize()
        {
            // initialize the pseudo-random number generator
            this._random = new Random();

            // This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Deck Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();
                Card.OverWrite(this[secondCard], this[firstCard]);
                Card.OverWrite(this[firstCard], tempCard);
            }
        }

        /// <summary>
        /// This method returns the top card of the deck
        /// </summary>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); // this removes the top card from the deck

            // for testing / debugging only
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count);

            return topCard;
        }
        public Hand Deal5()
        {
            Hand topFiveHand = new Hand();
            for (int topCards = 0; topCards <= 4; topCards++)
            {
                Card topFive = this[0];
                topFiveHand.Add(this[0]);
                this.RemoveAt(0); //this removes the cards dealt as top five
                Console.WriteLine("Cards Dealt: {0} = {1} of {2} || Deck size = {3}", topCards + 1, topFive.Suit, topFive.Face, this.Count);
            }
            return topFiveHand;

        }
    }
}