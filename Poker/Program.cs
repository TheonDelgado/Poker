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
                Console.Clear();

                var deck = new Deck();

                

                Console.WriteLine($"Dealers cards are ");
                Console.WriteLine($"Your cards are ");
            }


        }

        private static void EndProgram()
        {
            Console.WriteLine("Press any key to end program...");
            Console.Read();
        }
    }
}
