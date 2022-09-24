using System;

namespace Poker 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Poker! Press 'Enter' to Start!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ConsoleKeyInfo consoleKey = Console.ReadKey();
            if(consoleKey.Key == ConsoleKey.Enter)
            {
                PlayGame();
            }



            EndProgram();
        }

        private static void PlayGame()
        {
            Console.Clear();

            var player = new Player();
            int currentBet = 0;

            Console.WriteLine("Place a bet:");
            currentBet = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Current bet is " + currentBet);
            Console.WriteLine("Press 'Enter' to get your hand");

            ConsoleKeyInfo consoleKey = Console.ReadKey();          
            if(consoleKey.Key == ConsoleKey.Enter)
            {
                PlayFirstHand();

            }
        }

        private static void PlayFirstHand()
        {
            Console.Clear();

            var deck = new Deck();
            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();

            Tuple<List<Card>, List<Card>> hands = DealFirstHand(deck, playerHand, dealerHand);

            playerHand = hands.Item1;
            dealerHand = hands.Item2;

            Console.WriteLine($"Dealers cards are {dealerHand[0].Number}" + " " + dealerHand[0].Suit);
            Console.WriteLine($"Dealers cards are {dealerHand[1].Number}" + " " + dealerHand[1].Suit);
            Console.WriteLine($"Your cards are {playerHand[0].Number}" + " " + playerHand[0].Suit);
            Console.WriteLine($"Your cards are {playerHand[1].Number}" + " " + playerHand[1].Suit);
        }

        private static Tuple<List<Card>, List<Card>> DealFirstHand(Deck deck, List<Card> playerHand, List<Card> dealerHand)  
        {
            Card playerCard1 = deck.CardStack.Pop();
            Card dealerCard1 = deck.CardStack.Pop();
            Card playerCard2 = deck.CardStack.Pop();
            Card dealerCard2 = deck.CardStack.Pop();

            playerHand.Add(playerCard1);
            playerHand.Add(playerCard2);
            dealerHand.Add(dealerCard1);
            dealerHand.Add(dealerCard2);

            return Tuple.Create<List<Card>, List<Card>>(playerHand, dealerHand);
        }

        private static void EndProgram()
        {
            Console.WriteLine("Press any key to end program...");
            Console.Read();
        }
    }
}
