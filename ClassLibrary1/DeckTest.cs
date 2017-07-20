using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Deckofcards;
using System.Diagnostics;

namespace ClassLibrary1
{
    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void deck_should_start_in_order()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            string[] _values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] _suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

            int position = r.Next(1, 52);

            int suit = (position / 13);
            int value = position % 13;
            //if(value == 0) { value = 13; }
            Deck newDeck = new Deck();

            Assert.AreEqual(_values[value] + " of " + _suits[suit], newDeck.currentDeck[position].ToString());
        }

        // NOTE:: 
        // There is a random chance that a deck gets shuffled such that the two random cards selected are actually in the same place as the original deck. The nature of shuffling and randomness
        // allows for this occurance. The probability, however, is relatively low, so the chance of false positives with this test, while it exists, is also relatively low.
        // This test can be expanded to include EVERY card in each deck, but for simplicity sake, I'm only checking two cards. If the desire is for a more robust check, even 5 cards in a row would
        // be equivalent to a poker hand, which would be very random.
        [Test]
        public void deck_should_be_out_of_order()
        
        {
            Random r = new Random(DateTime.Now.Millisecond);
            
            int position = r.Next(5, 52);

            Deck shuffledDeck = new Deck();
            shuffledDeck.shuffle();

            Deck unshuffledDeck = new Deck();

            Assert.AreNotEqual(shuffledDeck.currentDeck[position].ToString() + shuffledDeck.currentDeck[position - 1].ToString(), unshuffledDeck.currentDeck[position].ToString() + unshuffledDeck.currentDeck[position - 1].ToString());


        }

        [Test]
        public void multiple_unshuffled_decks_are_equal()
        {
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
            Random r = new Random(DateTime.Now.Millisecond);

            int position = r.Next(5, 50);

            Assert.AreEqual(deck1.currentDeck[position].ToString() + deck1.currentDeck[position -1].ToString() , deck2.currentDeck[position].ToString() + deck2.currentDeck[position -1].ToString());

        }

    }
}
