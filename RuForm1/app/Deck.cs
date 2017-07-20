using System.Collections.Generic;
using System.Linq;

namespace Deckofcards

{
    public class Deck

    {
        List<Card> _currentDeck;
        string[] _values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] _suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

        public Deck() {
            _currentDeck = new List<Card>();
            init();
        }

        private void init() {
            for (int suitcount = 0; suitcount < _suits.Length; suitcount++)
            {
                for (int valuecount = 0; valuecount < _values.Length; valuecount++)
                {
                    _currentDeck.Add(new Card(_values[valuecount], _suits[suitcount]));
                }
            }
        }

        public void shuffle()
        {
            _currentDeck = _currentDeck.OrderBy(a => System.Guid.NewGuid()).ToList();
        }


        public List<Card> currentDeck { get { return _currentDeck; } }
    }
}
