using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void GetCardTest_14()
        {
            int number = 14;
            Deck deck = new Deck();
            string expected = deck.CardType[number];
            var actual = deck.GetCard(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCardTest_delete()
        {
            Deck deck = new Deck();
            int number = deck.GetRandom();
            string expected = deck.GetCard(number);
            string actual = deck.GetCard(number);
            Assert.AreNotEqual(expected, actual);

        }

        [TestMethod()]
        public void GetCardTest_ex()
        {
            int number = 37;
            Deck deck = new Deck();
            string expected = "В колоде такой карты не обнаружено";
            string actual = deck.GetCard(number);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCardTest_ex1()
        {
            int number = -1;
            Deck deck = new Deck();
            string expected = "В колоде такой карты не обнаружено";
            string actual = deck.GetCard(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCardTest_QueenOfSpades()
        {
            int number = 8;
            Deck deck = new Deck();
            string expected = "Дама Пики";
            var actual = deck.GetCard(number);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void SetTrumpTest_10()
        {
            Deck deck = new Deck();
            int number = 10;
            string expected = deck.CardType[number];
            string actual = deck.SetTrump(number);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetTrumpTest_Delete()
        {
            Deck deck = new Deck();
            int number = 10;
            string expected = deck.SetTrump(number);
            string actual = deck.SetTrump(number);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod()]
        public void SetTrumpTest_ex()
        {
            Deck deck = new Deck();
            int number = 37;
            string expected = "В колоде такой карты не обнаружено";
            string actual = deck.SetTrump(number);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SetTrumpTest_ex5()
        {
            Deck deck = new Deck();
            int number = -5;
            string expected = "В колоде такой карты не обнаружено";
            string actual = deck.SetTrump(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetTrumpTest_KingOfSpades()
        {
            Deck deck = new Deck();
            int number = 4;
            string expected = "Кароль Пики";
            string actual = deck.SetTrump(number);
            Assert.AreEqual(expected, actual);
        }


    }
}