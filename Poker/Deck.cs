using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public List<Card> CardList { get; set; }
        public Stack<Card> CardStack { get; set; }

        public Deck() 
        {
            CardList = new List<Card>();
            CardStack = new Stack<Card>();
            PopulateDeckList();
            PopulateDeckStack();
        }

        private void PopulateDeckStack()
        {
            foreach(Card card in CardList)
            {
                CardStack.Push(card);
            }
        }

        private void PopulateDeckList()
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
            for(int i = 1; i <= 13; i++)
            {
                var card = new Card(i, Suit.HEARTS);
                CardList.Add(card);
            }
        }
        private void CreateClubs()
        {
            for(int i = 1; i <= 13; i++)
            {
                var card = new Card(i, Suit.CLUBS);
                CardList.Add(card);
            }
        }
        private void CreateDiamonds()
        {
            for(int i = 1; i <= 13; i++)
            {
                var card = new Card(i, Suit.DIAMONDS);
                CardList.Add(card);
            }
        }
        private void CreateSpades()
        {
            for(int i = 1; i <= 13; i++)
            {
                var card = new Card(i, Suit.SPADES);
                CardList.Add(card);
            }
        }
    }
}