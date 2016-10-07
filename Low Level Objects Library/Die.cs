using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    class Die {
        private static Random randomNumber = new Random();

        private const int SIX_SIDED = 6;
        private const int DEFAULT_FACE_VALUE = 1;
        private const int MIN_NUMBER = 3;

        private int numFaces; //number of sides on die
        private int faceValue; // which side is showing
                              

        public Die() {
            numFaces = SIX_SIDED;
            faceValue = DEFAULT_FACE_VALUE;
        }

        public Die(int faces) {
            if (faces >= MIN_NUMBER) {
                numFaces = faces;
            } else {
                numFaces = SIX_SIDED;
            }
            RollDie();
        }

        public void RollDie() {
            faceValue = randomNumber.Next(1, numFaces + 1);
        } // end RollDie


        public int GetFaceValue() {
            return faceValue;
        } //end GetFaceValue


    }//end class Die
}
