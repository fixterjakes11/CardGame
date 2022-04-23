using System;
using System.Collections.Generic;
using System.Text;

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

        public Deck(Player player1, Player bot)
        {
            Player1 = player1;
            Bot = bot;
        }


        public bool Status { get; private set; } = true;
        /// <summary>
        /// Список карт
        /// </summary>
        List<string> CardType = new List<string>
        {
            "Туз Пики", "Туз Черви", "Туз Крести", " Туз Бубны",
            "Кароль Пики", "Кароль Черви", "Кароль Крести", " Кароль Бубны",
            "Дама Пики", "Дама Черви", "Дама Крести", "Дама Бубны",
            "Валет Пики", "Валет Черви", "Валет Крести", " Валет Бубны",
            "10 Пики", "10 Черви", "10 Крести", " 10 Бубны",
            "9 Пики", "9 Черви", "9 Крести", " 9 Бубны",
            "8 Пики", "8 Черви", "8 Крести", " 8 Бубны",
            "7 Пики", "7 Черви", "7 Крести", " 7 Бубны",
            "6 Пики", "6 Черви", "6 Крести", " 6 Бубны",
        };
        /// <summary>
        /// Выбор козыря(Подсъем карты)
        /// </summary>
        /// <returns></returns>
        public string GetTrump()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, CardType.Count);
            TrumpCard = CardType[rndNumber];
            CardType.RemoveAt(rndNumber);
            return TrumpCard;
        }
        /// <summary>
        /// Раздача карт
        /// </summary>
        /// <returns></returns>
        public string GetCard()
        {
            if (CardType.Count == 0)
            {
                Status = false;
                return "Карты в колоде закончились";
            }
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, CardType.Count);
            Card = CardType[rndNumber];
            CardType.RemoveAt(rndNumber);
            return Card;
        }


        public string GetInfo()
        {
            Player1.Option = GetCard();
            Bot.Option = GetCard();
            return $"Денег у Игрока {Player1.Money} ----- Денег у бота: {Bot.Money}\n" +
                    $"Игрок взял карту: {Player1.Option}\n" +
                    $"Бот взял карту: {Bot.Option}\n" +
                    $"в колоде остало {CardType.Count}\n"
                    ;
        }

    }
}
