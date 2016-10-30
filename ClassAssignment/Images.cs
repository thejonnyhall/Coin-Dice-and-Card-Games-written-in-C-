using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace ClassAssignment {
    /// <summary>
    /// Provides easy access to the coin and card images, 
    /// via the GetCoinImage, GetCardImage and GetBackOfCardImage methods.
    /// 
    /// For your assignment, it is not important to understand all the finer details 
    /// of all the methods in this class.
    /// 
    /// Do not confuse this class with the Microsoft-supplied class, Image, which has a similar name.
    /// </summary>
    public static class Images {

        private static Bitmap heads;
        private static Bitmap tails;

        private static Bitmap backOfCardImage;
        private static Bitmap[,] cardImages;

        private static Bitmap[] dieImages;


        /// <summary>
        /// Constructor - Loads images from disk files.
        /// </summary>
        static Images() {
            // Load coin images.
            heads = LoadImage("Coins", "Heads150");
            tails = LoadImage("Coins", "Tails150");


            // Load card images.
            backOfCardImage = Images.LoadImage("Cards", "CardBack_Red");
            cardImages = new Bitmap[CardPile.NUM_SUITS, CardPile.NUM_CARDS_PER_SUIT];

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++) {
                for (FaceValue faceValue = FaceValue.Two; faceValue <= FaceValue.Ace; faceValue++) {
                    Card card = new Card(suit, faceValue);
                    string cardImageName = GetCardImageName(card);
                    cardImages[(int)card.GetSuit(), (int)card.GetFaceValue()] = LoadImage("Cards", cardImageName);
                }
            } //end for ( Suit suit ...

            //Load die images
            dieImages = new Bitmap[7];

            for (int i = 1; i < dieImages.Length; i++) {
                string dieImageName = "Face_";
                dieImageName = dieImageName + i;
                dieImages[i] = LoadImage("Dice", dieImageName);
            }
        }//end Images


        /// <summary>
        /// Returns a head or tails coin image.
        /// </summary>
        /// <param name="Heads"> boolean</param>
        /// <returns>the heads image if parameter Heads is true; otherwise returns tails image</returns>
        public static Bitmap GetCoinImage(bool Heads) {
            if (Heads) {
                return heads;
            } else {
                return tails;
            }
        }

        /// <summary>
        /// Returns the image for a given Card.
        /// </summary>
        /// <param name="card"></param>
        /// <returns>the image for the Card specified by the parameter.</returns>
        public static Bitmap GetCardImage(Card card) {
            return cardImages[(int)card.GetSuit(), (int)card.GetFaceValue()];
        }


        /// <summary>
        /// Returns the image for the back (i.e. reverse side) of each card.
        /// </summary>
        /// <returns>the image for the back of each card.</returns>
        public static Bitmap GetBackOfCardImage() {
            return backOfCardImage;
        }

        public static Bitmap GetDieImage(int faceValue) {
            return dieImages[faceValue];
        }


        /// <summary>
        /// Used by the constructor in this class only.  Do NOT use elsewhere.
        /// </summary>
        private static string GetCardImageName(Card card) {
            Suit suit = card.GetSuit();
            FaceValue faceValue = card.GetFaceValue();
            return string.Format("{0}{1}", suit.ToString().TrimEnd('s'), faceValue);
        }


        /// <summary>
        /// Used by the constructor in this class only.  Do NOT use elsewhere.
        /// </summary>
        private static Bitmap LoadImage(string subfolderName, string imageName) {
            string fileSpec = string.Format(@".\Images\{0}\{1}.png", subfolderName, imageName);
            Bitmap bitmap = new Bitmap(fileSpec);
            return bitmap;
        }
    }
}
