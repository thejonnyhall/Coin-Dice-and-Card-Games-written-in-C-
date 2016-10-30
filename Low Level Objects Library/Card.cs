using System;

namespace Low_Level_Objects_Library {
    public enum Suit { Clubs, Diamonds, Hearts, Spades }

    public enum FaceValue {
        Two, Three, Four, Five, Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King, Ace
    }

    /// <summary>
    /// Class to represent playing card with a Suit and FaceValue (pips).
    /// 
    /// Based on an earlier Java program written in 2002 for Software Development 1 (ITB410)
    /// 
    /// Converted to C# for INB270/INN270 Programming
    /// 
    /// Default Constructor allows application to have "blank" cards 
    /// 
    /// Mike Roggenkamp & Jim Reye 2009 onwards
    /// </summary>
    public class Card : IEquatable<Card>, IComparable<Card> {
        // IEquatable allows Card objects to be compared to see if two cards have the same value.
        // IComparable allows Card objects to be sorted easily.
        // While the precise details of IEquatable and IComparable are unimportant for this assignment,
        // they are needed so that the Hand class's Sort and Contains methods work correctly.
    
        private Suit suit;
        private FaceValue faceValue;

       // Default constructor: Card is "blank" 
        public Card() {
        }

        // The constructor normally used when you know its Suit and FaceValue values.
        public Card(Suit suit, FaceValue faceValue) {
            this.suit = suit;
            this.faceValue = faceValue;
        }


        // An accessor.
        public Suit GetSuit() {
            return suit;
        }

        // Another accessor.
        public FaceValue GetFaceValue() {
            return faceValue;
        }

       

        // Needed so that the Hand class's Contains method works correctly.
        //
        // You should NOT need to call this Equals method directly in your own code.
        //
        // Returns True if one card is equal to another, e.g. myCard.Equals(anotherCard).
        // Otherwise, returns False.
        public bool Equals(Card anotherCard) {
            return (this.suit == anotherCard.suit && this.faceValue == anotherCard.faceValue);
        }//end Equals

        // Needed so that the Hand class's Sort method works correctly.
        // You should NOT need to call this CompareTo method directly in your own code.
        // Returns:
        //      -1 if the current card precedes anotherCard in the sort order;
        //       0 if the current card is in the same position as anotherCard in the sort order;
        //      +1 if the current card follows anotherCard in the sort order.
        public int CompareTo(Card anotherCard) {

            if (this.suit < anotherCard.suit) {
                return -1;
            } else if (this.suit > anotherCard.suit) {
                return 1;
            } else {
                if (this.faceValue < anotherCard.faceValue) {
                    return -1;
                } else if (this.faceValue > anotherCard.faceValue) {
                    return 1;
                } else {
                    return 0;
                }
            }
        }//end CompareTo



        // This method has been provided solely for debugging purposes
        //   
        //    you are not required to use it
        //
        // it does not have a direct involvement in the functionality of any Card based game
        //
        // Returns a string that describes the card's value.
        //
        // When shortFormat is False, the card's FaceValue is returned as its full name, 
        //      e.g. Two, Three, ..., King, Ace.
        // When shortFormat is True, the card's FaceValue is returned as one or two characters, 
        //      e.g. 2, 3, ... 10, J, Q, K, A.
        //
        // When displaySuit is False, the card's Suit is ignored.
        // When displaySuit is True, the card's Suit is added on the end, 
        //      e.g. " of Clubs" when shortFormat is False,
        //                or "C" when shortFormat is True, as in "2C".
        public string ToString(bool shortFormat, bool displaySuit) {
            string returnString;

            // Describe the FaceValue.
            FaceValue faceValue = GetFaceValue();
            string faceValueAsString = faceValue.ToString();
            if (shortFormat) {
                if (faceValue <= FaceValue.Ten) {
                    faceValueAsString = (faceValue - FaceValue.Two + 2).ToString();
                } else {
                    faceValueAsString = faceValueAsString.Substring(0, 1);
                }
            }

            returnString = faceValueAsString;

            // Describe the Suit.
            if (displaySuit) {
                string suit = GetSuit().ToString();
                if (shortFormat) {
                    suit = suit.Substring(0, 1);
                    returnString += suit;
                } else {
                    returnString += " of " + suit;
                }
            }

            return returnString;
        }//end To String
    } //end class Card
}//end namespace
