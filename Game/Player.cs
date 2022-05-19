using System;


namespace Game
{
    public class Player
    {
        public string trumpCard { get; set; }
        public string Option { get; set; }
        public int Money { get; set; }
        public string Name { get; set; }
        public int Bid { get; set; }

        public Player(string name, int bid)
        {
            Name = name;
            Option = string.Empty;
            Money = 1000;
            trumpCard = string.Empty;
            Bid = bid;
        }


        public string ScoreInfo()
        {
            string[] TrumpCard = trumpCard.Split(' '); // козырь
            string[] card = Option.Split(' '); // карты
            if (card[1] == TrumpCard[1]) // сравниваем масти карт на соответствие козырю
            {
                switch (card[0])
                {
                    case "Туз":
                        Money -= 11 * Bid; 
                        return $"Выпала козырная карта {Option} у {Name} забрали {11 * Bid} денег\n осталось денег {Money}";
                    case "Кароль":
                        Money -= 4 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали { 4 * Bid} денег\n осталось денег {Money}";
                    case "Дама":
                        Money -= 3 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали { 3 * Bid} денег\n осталось денег {Money}";
                    case "Валет":
                        Money -= 2 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали {2 * Bid} денег\n осталось денег {Money}";
                    case "6":
                        Money -= 6 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали {6 * Bid} денег\n осталось денег {Money}";
                    case "7":
                        Money -= 7 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали {7 * Bid} денег\n осталось денег {Money}";
                    case "8":
                        Money -= 8 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали { 8 * Bid} денег\n осталось денег {Money}";
                    case "9":
                        Money -= 9 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали {9 * Bid} денег\n осталось денег {Money}";
                    case "10":
                        Money -= 10 * Bid;
                        return $"Выпала козырная карта {Option} у {Name} забрали {10 * Bid} денег\n осталось денег {Money}";
                }
            }
            return string.Empty;
        }

        public string PlayerGetInfo()
        {
            return $"\nУ {Name} выпала карта: {Option}\n" +
                $"Денег осталось : {Money}\n";
        }


    }
}
