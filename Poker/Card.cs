using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        public int Number { get; private set; }
        public Suit Suit { get; private set; }

        public Card(int number, Suit suit) 
        {
            Number = number;
            Suit = suit;
        }
    }
}