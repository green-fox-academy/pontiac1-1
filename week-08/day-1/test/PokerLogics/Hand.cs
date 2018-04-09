using System;
using System.Collections.Generic;
using System.Text;

namespace PokerLogics
{
    public class Hand
    {
        private List<Card> _pokerHand;
        private int _ranking;

        public List<Card> PokerHand { get; set; }
        public int Ranking { get; set; }

        public Hand()
        {           
        }

        public int GetRank()
        {

            return Ranking;
        }

        public bool IsFlush()
        {

            for (int i = 0; i < PokerHand.Count; i++)
            {
                char suit = PokerHand[0].Suit;
                if (PokerHand[1].Suit != suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsRoyal()
        {
            if (!IsFlush())
            {
                return false;
            }
            else if(!IsStaright())
            {
                return false;
            }
            return true;
        }

        public bool IsStaright()
        {
            PokerHand.Sort();
            for (int i = 0; i < PokerHand.Count-1; i++)
            {
                if (PokerHand[i+1].Number != PokerHand[i].Number + 1)
                {
                    return false;
                }               
            }

            return true;
        }
    }
}
