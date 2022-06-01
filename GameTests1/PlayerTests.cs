using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void ScoreInfoTest_Queen()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "Дама Пики";
            player.ScoreInfo();
            int expected = 970;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_7()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "7 Пики";
            player.ScoreInfo();
            int expected = 930;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_Vallet()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "Валет Пики";
            player.ScoreInfo();
            int expected = 980;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_Ace()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "Туз Пики";
            player.ScoreInfo();
            int expected = 890;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_10()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "10 Пики";
            player.ScoreInfo();
            int expected = 900;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_9()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "9 Пики";
            player.ScoreInfo();
            int expected = 910;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ScoreInfoTest_8()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "8 Пики";
            player.ScoreInfo();
            int expected = 920;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod()]
        public void ScoreInfoTest_6()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "6 Пики";
            player.ScoreInfo();
            int expected = 940;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void ScoreInfoTest_Not()
        {
            Player player = new Player("Игрок", 10);
            player.trumpCard = "Кароль Пики";
            player.Option = "9 Крести";
            player.ScoreInfo();
            int expected = 1000;
            int actual = player.Money;
            Assert.AreEqual(actual, expected);
        }
    }
}