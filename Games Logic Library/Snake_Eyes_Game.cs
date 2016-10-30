using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    static public class Snake_Eyes_Game {

        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoints;
        private static Die[] dice = new Die[2];

        /// <summary>
        /// Initialises class variables at the beginning of a new game
        /// </summary>
        public static void SetUpGame() {
            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
            rollTotal = 0;
            playerTotal = 0;
            houseTotal = 0;
            possiblePoints = 0;
        } /// End of SetUpGame Method


        /// <summary>
        /// plays the first roll, determines if the user has to roll again based on the outcome of the previous roll
        /// </summary>
        /// <returns>A boolean indicating that another roll is requried when true</returns>
        public static bool FirstRoll() {
            bool anotherRollRequired;
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();
            }
            rollTotal = GetRollTotal();
            anotherRollRequired = (new[] { 4, 5, 6, 8, 9, 10 }.Contains(rollTotal));
            return anotherRollRequired;
        } // End of FirstRoll Method


        /// <summary>
        /// Plays yet another roll, and similar to FirstRoll, determines if another roll is required
        /// </summary>
        /// <returns>A boolean indicating that another roll is requried when true</returns>
        public static bool AnotherRoll() {
            bool newRoll;
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();
            }
            possiblePoints = GetPossiblePoints();
            newRoll = (possiblePoints != rollTotal);
            return newRoll;
        } // End of AnotherRoll method


        /// <returns>Face Value of The specified die in whichDie</returns>
        public static int GetDieFacevalue(int whichDie) {
            return dice[whichDie].GetFaceValue();
        } // End of GetDieFacevalue method


        /// <returns>The Players total points as an int</returns>
        public static int GetPlayerPoints() {
            if (rollTotal == 2) {
                playerTotal += 2;
            } else if (rollTotal == 7 || rollTotal == 11) {
                playerTotal += 1;
            } else if (rollTotal == possiblePoints) {
                playerTotal += possiblePoints;
            } else {
                playerTotal += 0;
            }
            return playerTotal;
        } // End of GetPlayerPoints Method


        /// <returns>Returns the House's Points as an int</returns>
        public static int GetHousePoints() {
            if (rollTotal == 3 || rollTotal == 12) {
                houseTotal += 2;
            } else if ((new[] { 4, 5, 6, 8, 9, 10 }.Contains(rollTotal)) && possiblePoints == 7) {
                houseTotal += 2;
            } else {
                houseTotal += 0;
            }
            return houseTotal;
        } //  End of GetHousePoints Method


        /// <returns>The Possible Points that the player must roll to win the round, as an int</returns>
        public static int GetPossiblePoints() {
            return GetRollTotal();
        } // End of GetPossiblePoints Method


        /// <returns>The current of the total roll as an int</returns>
        public static int GetRollTotal() {
            int sum = 0;
            for (int i = 0; i < dice.Length; i++) {
                sum += GetDieFacevalue(i);
            }
            return sum;
        } //End of GetRollTotal Method


        /// <returns>The roll outcome as a string (i.e. "You win!", "You lost!", "Draw!")</returns>
        public static string GetRollOutcome() {
            playerTotal = GetPlayerPoints();
            houseTotal = GetHousePoints();
            string win = "You win!";
            string lose = "You lost!";
            string draw = "Draw!";
            return (playerTotal > houseTotal) ? win : (houseTotal > playerTotal) ? lose : draw;
        } // End of GetRollOutcome Method


    }
}