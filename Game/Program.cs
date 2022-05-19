using System;


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
                    Console.WriteLine("\nНапишите ставку: ");
                    try
                    {
                        int bid = Convert.ToInt32(Console.ReadLine());
                        Game(bid);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                if(Console.ReadKey().Key == ConsoleKey.D2)
                {
                    break;
                }

            }
        }


        static void Game(int bid)
        {
            Console.WriteLine("\nНажмите Enter для начала игры");
            Player player = new Player("Игрок", bid);
            Player bot = new Player("Бот", bid);
            Deck deck = new Deck(player, bot);
            Console.WriteLine($" Подснята карта: { deck.TrumpCard}");
            
            while (true)
            {
                Console.WriteLine("\nНажмите Enter для следущего хода...\n");
                if (Console.ReadKey().Key == ConsoleKey.Enter)

                {
                    switch (deck.Count)
                    {
                        case 1:
                            Console.WriteLine(deck.PlayerGetInfo());
                            break;
                        case 2:
                            Console.WriteLine(deck.BotGetInfo());
                            break;

                    }

                }
                if(deck.CardType.Count == 0)
                {
                    Console.WriteLine(deck.EndGame()); 
                    break;
                }
            }
        }
    }

    
}
