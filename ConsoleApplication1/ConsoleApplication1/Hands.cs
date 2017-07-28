using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Jasleen
 * Date: July 27, 2017
 * Description:  Lesson 11
 * Version: 0.3 -  Deck class
 */
namespace ConsoleApplication1
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
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

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        public void HighestCards(Hand hand)
        {
            var sortedHand = from cards in hand
                             orderby cards.Face descending
                             select cards.Face;
            Console.WriteLine("The Highest cards in descending order: ");
            foreach (var item in sortedHand)
            {
                {
                    Console.WriteLine(item);
                }


            }
        }
    }
}