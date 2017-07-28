using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Jasleen
 * Date: July 27, 2017
 * Description: Lesson 11
 * Version: 0.4  new Deck class
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());

            //hand = deck.Deal5(); // moves the top 5 cards from the deck to the hand object

            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
            Console.WriteLine("Dealt Top Five Cards");
            Console.WriteLine("==================================");
            Console.WriteLine();

            //Console.WriteLine(deck.ToString());
            hand = deck.Deal5(); //moves top five cards from the deck to the  
            //Console.WriteLine(hand);
            Console.WriteLine(hand.ToString());
            hand.HighestCards(hand);
            // Console.WriteLine(hand.HighestCards());

        }
    }
}