using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackJack
{
    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public class Card
    {
        public Suits Suit { get; set; }
        public int Value { get; set; }
        public int Img { get; set; }
        public Card(Suits _suit,int _value,int _image)
        {
            this.Suit = _suit;
            this.Value = _value;
            this.Img = _image;
        }
    }
}
