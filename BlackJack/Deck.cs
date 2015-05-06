using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Card[] deck = new Card[52];
        public int[] values = new int[] { 11,2,3,4,5,6,7,8,9,10,10,10,10};
        public Deck()
        {
            int i = 0;
            foreach (var item in values)
            {
                deck[i] = new Card(Suits.Clubs, item, i);
                i++;
            }
            foreach (var item in values)
            {
                deck[i] = new Card(Suits.Diamonds, item, i);
                i++;
            }
            foreach (var item in values)
            {
                deck[i] = new Card(Suits.Hearts, item, i);
                i++;
            }
            foreach (var item in values)
            {
                deck[i] = new Card(Suits.Spades, item, i);
                i++;
            }
        }
        public void shuffle()
        {
            Random r = new Random();
            for (int i = deck.Length-1; i > 0; i--)
            {
                int k = r.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[k];
                deck[k] = temp;
            }
        }
     

    }
}
