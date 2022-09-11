using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public List<Card> CardList { get; set; }

        public Deck() 
        {
            CardList = new List<Card>();
            PopulateDeck();

            foreach(Card card in CardList)
            {
                Console.Write(card.Number + " ");
                Console.Write(card.Suit);
                Console.WriteLine();
            }
        }

        private void PopulateDeck()
        {
            CreateClubs();
            CreateDiamonds();
            CreateHearts();
            CreateSpades();

            Random rand = new Random();
            CardList = CardList.OrderBy(x => rand.Next()).ToList();
        }

        private void CreateHearts()
        {
            for(int i = 0; i < 13; i++)
            {
                var card = new Card(i, Suit.HEARTS);
                CardList.Add(card);
            }
        }
        private void CreateClubs()
        {
            for(int i = 0; i < 13; i++)
            {
                var card = new Card(i, Suit.CLUBS);
                CardList.Add(card);
            }
        }
        private void CreateDiamonds()
        {
            for(int i = 0; i < 13; i++)
            {
                var card = new Card(i, Suit.DIAMONDS);
                CardList.Add(card);
            }
        }
        private void CreateSpades()
        {
            for(int i = 0; i < 13; i++)
            {
                var card = new Card(i, Suit.SPADES);
                CardList.Add(card);
            }
        }
    }
}