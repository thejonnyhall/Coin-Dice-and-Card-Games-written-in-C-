using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Twenty_One_Game {

        private static CardPile cardPile;
        private static Hand[] hands = new Hand[2];
        private static int[] totalPoints = new int[2];
        private static int[] numOfGamesWon = new int[2];
        private static int numOfUserAcesWithValueOne;
        private const int ZERO = 0;
        private const int BLACK_JACK = 21;

        /// <summary>
        /// Sets up the game ready for playing
        /// </summary>
        public static void SetUpGame() {
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            for (int i = 0; i < hands.Length; i++) {
                hands[i] = new Hand();
                totalPoints[i] = ZERO;
            }
            numOfUserAcesWithValueOne = ZERO;
        }

        /// <summary>
        /// Depending on who is specified, deals a card to their hand
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Card DealOneCardTo(int who) {
            cardPile.Shuffle();
            Card dealtCard = cardPile.DealOneCard();
            hands[who].Add(dealtCard);
            if (who == 1) {
                totalPoints[who] = CalculateHandTotal(who);
            }
            cardPile.Shuffle();
            return dealtCard;
        }

        /// <summary>
        /// Depending on who is specified, calculates the sum of their hand
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int CalculateHandTotal(int who) {
            int total = ZERO;
            for (int i = 0; i < hands[who].GetCount(); i++) {
                if ((int)hands[who].GetCard(i).GetFaceValue() < (int)FaceValue.Jack) {
                    total += (int)hands[who].GetCard(i).GetFaceValue() + (int)FaceValue.Four;
                } else if ((int)hands[who].GetCard(i).GetFaceValue() < (int)FaceValue.Ace) {
                    total += (int)FaceValue.Queen;
                } else {
                    total += (int)FaceValue.King;
                }
            }
            return total;
        }

        /// <summary>
        /// Plays the Dealer's turn, hitting if below 17 and staying if above
        /// </summary>
        public static void PlayForDealer() {
            while (totalPoints[1] < (int)FaceValue.Ace + (int)FaceValue.Seven) {
                DealOneCardTo(1);
                DealOneCardTo(1);
            }
            if (totalPoints[0] > totalPoints[1] && totalPoints[0] < BLACK_JACK) {
                numOfGamesWon[0]++;
            } else if (totalPoints[1] > totalPoints[0] && totalPoints[1] < BLACK_JACK) {
                numOfGamesWon[1]++;
            }
        }

        /// <summary>
        /// Returns a hand given on who's specified
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }

        /// <summary>
        /// Returns the sum of the facevalue of someone's hand
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetTotalPoints(int who) {
            if (who == 0) {
                totalPoints[0] = CalculateHandTotal(who) - (numOfUserAcesWithValueOne * (int)FaceValue.Queen);
            } else {
                totalPoints[1] = CalculateHandTotal(1);
            }
            return totalPoints[who];
        }

        /// <summary>
        /// Returns the number of games won depending on who's specified
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetNumOfGamesWon(int who) {
            if (totalPoints[0] > BLACK_JACK) {
                numOfGamesWon[1]++;
            } else if (totalPoints[1] > BLACK_JACK) {
                numOfGamesWon[0]++;
            }
            return numOfGamesWon[who];
        }

        /// <summary>
        /// Returns the number of ace in the player's hand, given they're of value 1
        /// </summary>
        /// <returns></returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        /// <summary>
        /// Increments the number of player's aces specified as value 1 by 1
        /// </summary>
        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne++;
        }

        /// <summary>
        /// Resets totals for the game
        /// </summary>
        public static void ResetTotals() {
            for (int i = 0; i < hands.Length; i++) {
                hands[i] = new Hand();
                totalPoints[i] = 0;
                numOfGamesWon[i] = 0;
            }
            cardPile = new CardPile(true);
            cardPile.Shuffle();
        }
    }
}