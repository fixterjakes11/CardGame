using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВведите 1 чтобы начать игру\nВведите 2 чтобы выйти");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Game();
                }
                else
                {
                    break;
                }

            }
        }


        static void Game()
        {
            Console.WriteLine("\nНажмите Enter для начала игры");
            Player player = new Player();
            Player bot = new Player();
            Deck deck = new Deck(player, bot);
            Console.WriteLine($" Подснята карта: { deck.GetTrump()}");
            
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(deck.GetInfo());
                }
                if(deck.Status == false)
                {
                    break;
                }
            }
        }
    }

    
}
