using System;
using System.Collections.Generic;
using System.Text;

namespace PokerLogics
{
    public class Card : IComparable<Card>
    {
        public int Number { get; set; }
        public char Suit { get; set; }

        public Card(int number, char suit)
        {
            this.Number = number;
            this.Suit = suit;
        }

        public int CompareTo(Card card)
        {
            return Number.CompareTo(card.Number);
        }
    }
}
