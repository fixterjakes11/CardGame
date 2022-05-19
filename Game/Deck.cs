using System;
using System.Collections.Generic;

namespace Game
{
    public class Deck
    {
        public string Card { get; private set; }
        /// <summary>
        /// Козырь
        /// </summary>
        public string TrumpCard { get; private set; }
        public Player Player1 { get; private set; }
        public Player Bot { get; private set; }

        public int Count = 2;


        /// <summary>
        /// Конструктор для игры
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="bot"></param>
        public Deck(Player player1, Player bot)
        {
            try
            {
                Player1 = player1 ?? throw new ArgumentNullException("Пустой объект");
                Bot = bot ?? throw new ArgumentNullException("Пустой объект");
                TrumpCard = SetTrump(GetRandom());
                Player1.trumpCard = TrumpCard;
                Bot.trumpCard = TrumpCard;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
 

        /// <summary>
        /// Конструктор для тестов
        /// </summary>
        public Deck() { }


        /// <summary>
        /// Рандом
        /// </summary>
        /// <returns>Рандомное число от 0 до количества карт в колоде</returns>
        public int GetRandom()
        {
            Random random = new Random();
            return random.Next(0, CardType.Count); ;
        }

        /// <summary>
        /// Список карт
        /// </summary>
        public List<string> CardType = new List<string>
        {
            "Туз Пики", "Туз Черви", "Туз Крести", "Туз Бубны",
            "Кароль Пики", "Кароль Черви", "Кароль Крести", "Кароль Бубны",
            "Дама Пики", "Дама Черви", "Дама Крести", "Дама Бубны",
            "Валет Пики", "Валет Черви", "Валет Крести", "Валет Бубны",
            "10 Пики", "10 Черви", "10 Крести", "10 Бубны",
            "9 Пики", "9 Черви", "9 Крести", "9 Бубны",
            "8 Пики", "8 Черви", "8 Крести", "8 Бубны",
            "7 Пики", "7 Черви", "7 Крести", "7 Бубны",
            "6 Пики", "6 Черви", "6 Крести", "6 Бубны",
        };

        /// <summary>
        /// Установка козыря (Подсъем карты)
        /// </summary>
        /// <param name="rndNumber">Рандомное число</param>
        /// <returns>Случайную Козырную карту их списка карт</returns>
        public string SetTrump(int rndNumber)
        {
            if (rndNumber > CardType.Count || rndNumber < 0)
            {
                throw new ArgumentException("В колоде такой карты не обнаружено");
            }
            TrumpCard = CardType[rndNumber];
            CardType.RemoveAt(rndNumber);
            return TrumpCard;
        }

        /// <summary>
        /// Раздача карт
        /// </summary>
        /// <returns>Случайно выброную карту из списка карт</returns>
        public string GetCard(int rndNumber)
        {
            if (rndNumber > CardType.Count || rndNumber < 0)
            {
                throw new ArgumentException("В колоде такой карты не обнаружено");
            }
            if (CardType.Count == 0)
            {
                return "Карты в колоде закончились";
            }
            Card = CardType[rndNumber];
            CardType.RemoveAt(rndNumber);
            return Card;
        }
        public string PlayerGetInfo()
        {
            Player1.Option = GetCard(GetRandom());
            string[] trumpCard = TrumpCard.Split(' ');
            string[] card = Player1.Option.Split(' ');
            if (card[1] != trumpCard[1])
            {
                Count = 2;
                return $"{Player1.PlayerGetInfo()}" +
                    $" Карт осталось {CardType.Count}";
            }
            return $"{Player1.ScoreInfo()}" +
                    $" Карт осталось {CardType.Count}";

        }
        public string BotGetInfo()
        {
            Bot.Option = GetCard(GetRandom());
            string[] trumpCard = TrumpCard.Split(' ');
            string[] card = Bot.Option.Split(' ');
            if (card[1] != trumpCard[1])
            {
                Count = 1;
                return $"{Bot.PlayerGetInfo()}" +
                    $" Карт осталось {CardType.Count}";
            }
            return $"{Bot.ScoreInfo()}" +
                    $" Карт осталось {CardType.Count}";
        }
        public string EndGame()
        {
            if (Bot.Money > Player1.Money)
                return $"{Bot.Name} ПОБЕДИЛ!!!";
            if(Player1.Money > Bot.Money)
            {
                return $"{Player1.Name} ПОБЕДИЛ!!!";
            }
            return "Ничья";
        }

    }
}
