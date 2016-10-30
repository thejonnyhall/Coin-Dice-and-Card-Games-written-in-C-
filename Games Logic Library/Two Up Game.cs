using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Two_Up_Game {

        private static Coin coin1;
        private static Coin coin2;
        private static int playersScore;
        private static int computersScore;

        /// <summary>
        /// Initialises class variables at the beginning of a new game
        /// </summary>
        public static void SetUpGame() {
            coin1 = new Coin();
            coin2 = new Coin();
            playersScore = 0;
            computersScore = 0;
        } // End of SetUpGame Method


        /// <summary>
        /// Flips Both Coins
        /// </summary>
        static public void TossCoins() {
            coin1.Flip();
            coin2.Flip();
        } // End of TossCoins Method


        /// <summary>
        /// Recieves the result of the flip and returns the appropriate response
        /// </summary>
        /// <returns>A String, Being either "Heads", "Tails", or "Odds"</returns>
        static public string TossOutcome() {
            if (coin1.IsHeads() && coin2.IsHeads()) {
                return "Heads";
            } else if (!coin1.IsHeads() && !coin2.IsHeads()) {
                return "Tails";
            } else {
                return "Odds";
            }
        } // End of TossOutcome Method


        /// <summary>
        /// Checks the flip state of one coin, decided by the paramater 'whichCoin'
        /// </summary>
        /// <param name="whichCoin"></param>
        /// <returns>True if the coin is heads, False otherwises</returns>
        static public bool IsHeads(int whichCoin) {
            if (whichCoin == 1) {
                return coin1.IsHeads();
                //   return false;
            }
            return coin2.IsHeads();
        } // End of IsHeads Method


        /// <returns>The Player's Score as an int</returns>
        static public int GetPlayersScore() {
            if (coin1.IsHeads() && coin2.IsHeads()) {
                playersScore = playersScore + 1;
            }
            return playersScore;
        } //  End of GetPlayersScore Method


        /// <returns>The Compuer's Score as an int</returns>
        static public int GetComputersScore() {
            if (!coin1.IsHeads() && !coin2.IsHeads()) {
                computersScore = computersScore + 1;
            }
            return computersScore;
        } // End of GetComputersScore Method

    }
}