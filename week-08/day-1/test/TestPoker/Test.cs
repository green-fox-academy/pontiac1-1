using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PokerLogics;

namespace TestPoker
{
    [TestFixture]
    class Test
    {
        Hand Straight = new Hand
        {
            PokerHand = new List<Card>
            {
                new Card(5, 'S'),
                new Card(9, 'H'),
                new Card(7, 'S'),
                new Card(6, 'C'),
                new Card(8, 'C')
            }
        };

        Hand HighCardHand = new Hand
        {
            PokerHand = new List<Card>
            {
                new Card(5, 'S'),
                new Card(9, 'H'),
                new Card(7, 'S'),
                new Card(6, 'C'),
                new Card(12, 'C')
            }
        };


        [TestCase]
        public void Test_IsStraight()
        {
            Assert.IsTrue(Straight.IsStaright());
        }

        [TestCase]
        public void Test_IsStraight_False()
        {
            Assert.IsFalse(HighCardHand.IsStaright());
        }
    }
}
