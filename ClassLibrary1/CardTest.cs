using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Deckofcards;
namespace Tests
{
    [TestFixture]
    public class CardTest
    {
        [Test]
        public void card_without_anything()
        {
            Card card = new Card();

            Assert.AreEqual("Joker", card.ToString());
        }

        [Test]
        public void ace_of_spades()
        {
            Card card = new Card("Ace", "Spades");

            Assert.AreEqual("Ace of Spades", card.ToString());
        }

        // NOTE::
        // I set this test up specifically to fail, in order to outline how Unit Tests can drive development - as a checklist of objectives not yet accomplished.
        // In this case, the image portion of the cards has not yet been implemented. 
        [Test]
        public void card_image_should_return_string()
        {
            string pathString = "some/image/ace_of_spades.jpg";
            Card card = new Card("Ace", "Spades", pathString);
            Assert.AreEqual(pathString, card.getImagePath());
        }

    }
}
