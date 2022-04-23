using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Player
    {
        public string Option { get; set; }
        public int Money { get; set; }

        public Player()
        {
            Option = string.Empty;
            Money = 1000;
        }

    }
}
