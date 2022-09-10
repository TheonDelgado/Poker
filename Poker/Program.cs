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

            Console.WriteLine("Place a bet:");
            


        }

        private static void EndProgram()
        {
            Console.WriteLine("Press any key to end program...");
            Console.Read();
        }
    }
}
