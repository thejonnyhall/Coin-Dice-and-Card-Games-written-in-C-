using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    public class Coin {
        private enum Coin_Face { Heads, Tails }
        private const int NUMBER_OF_SIDES = 2;

        private Coin_Face face;

        /// <summary>
        /// Random class object used to generate random numbers
        /// 
        /// Decared as static so every Coin object uses the single  
        /// sequence of random values rather than each Coin having its
        /// own sequence of random values
        /// 
        /// Look at Random class for description of methods available
        /// </summary>
        private static Random randomValue = new Random(10);


        /// <summary>
        /// Sets up the coin by flipping it initially.
        /// </summary>
        public Coin() {
            Flip();
        }//end Coin


        /// <summary>
        /// Flips the coin by randomly choosing a face value Heads or Tails
        /// </summary>
        public void Flip() {
            int value = randomValue.Next(NUMBER_OF_SIDES);
            face = (Coin_Face)value;
        }//end Flip


        /// <summary>
        /// Tests if the current face is a Head
        /// </summary>
        /// <returns> Returns true if the current face of the coin is heads 
        /// otherwise returns false</returns>
        public bool IsHeads() {
            return (face == Coin_Face.Heads);
        }//end IsHeads


        /// <summary>
        /// Returns the current face of the coin as a string.
        /// </summary>
        /// <returns>the current face</returns>
        public override string ToString() {
            return face.ToString();
        } //end ToString

    }//end Coin class
}
