using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Twenty_One_Game {
        
        private static CardPile cardPile = new CardPile(true);
        private static Hand[] hands;
        private static int[] totalPoints;
        private static int[] numOfGamesWon;
        private static int numOfUserAcesWithValueOne;

        public const int NUM_OF_PLAYERS = 2;

        public static void SetUpGame() {
            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();
            hands = new Hand[2] { playerHand, dealerHand };
            cardPile.Shuffle();
        }

        public static Card DealOneCardTo(int who) {
            Card card = cardPile.DealOneCard();
            hands[who].Add(card);
            return card;
        }

        public static int CalculateHandTotal(int who) {
            int handTotal = 0;

            foreach (Card card in hands[who]) {
                FaceValue faceValue = card.GetFaceValue();
                if (faceValue.Equals(FaceValue.Jack) || faceValue.Equals(FaceValue.Queen) || faceValue.Equals(FaceValue.King)) {
                    handTotal += 10;
                } else if (faceValue.Equals(FaceValue.Ace)) {
                    handTotal += 11;
                } else {
                    handTotal = (int)card.GetFaceValue();
                }
            } // End foreach loop

            return handTotal;
        }

        public static void PlayForDealer() {

        }

        public static Hand GetHand(int who) {
            return hands[who];
        }

        public static Hand GetTotalPoints(int who) {
            return new Hand();
        }

        public static int GetNumOfGamesWon(int who) {
            return 0;
        }

        public static int GetNumOfUserAcesWithValueOne() {
            return 0;
        }

        public static void IncrementNumOfUserAcesWithValueOne() {

        }

        public static void ResetTotals() {

        }
    }
}