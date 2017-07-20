namespace Deckofcards
{
    public class Card
    {
        string _value;
        string _suit;
        string _imagePath;

        public Card()
        {
            _value = "Joker";
            _suit = "Joker";
        }

        public Card(string value, string suit) {
            _value = value;
            _suit = suit;
        }

        public Card (string value, string suit, string imagePath)
        {
            _value = value;
            _suit = suit;
            _imagePath = imagePath;
        }

        public override string ToString()
        {
            return name();
        }

        public string getImagePath()
        {
            throw new System.NotImplementedException();
        }

        private string name() {
            if (_value == "Joker" || _suit == "Joker")
            {
                return "Joker";
            }
            else
            {
                return _value + " of " + _suit;
            }
        }
    }
}
