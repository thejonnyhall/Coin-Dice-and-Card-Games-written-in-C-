using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Crazy_Eight_Game {

        private static CardPile[] pile = new CardPile[2];
        private static Hand[] hands;
        private static int[] numOfCards;


        /// <summary>
        /// Sets Up variables at the start of a game
        /// </summary>
        public static void SetUpGame() {
            pile[0] = new CardPile(true);
            pile[1] = new CardPile();
            hands = new Hand[2];
            numOfCards = new int[2];
            pile[0].Shuffle(); // shuffle the deal deck
            for (int i = 0; i < hands.Length; i++) {
                hands[i] = new Hand();
            }
        }


        /// <summary>
        /// Sorts the cards in the player's hand
        /// </summary>
        public static void SortCards() {
            hands[0].Sort();
        }


        /// <summary>
        /// Deals one card to the hand selected
        /// </summary>
        /// <param name="who">0 for player, 1 for computer</param>
        /// <returns></returns>
        public static Card DealOneCardTo(int hand) {
            if (pile[0].GetCount() == 0) {
                pile[0] = pile[1];
            }
            //deal a card from draw pile
            Card dealtCard = pile[0].DealOneCard(); 
            hands[hand].Add(dealtCard);
            return dealtCard;
        } // Returns card for image function later on

        /// <summary>
        /// Deals a card to the discard pile
        /// </summary>
        /// <returns>The Dealt Card</returns>
        public static Card DealDiscardCard() {
            Card dealtCard = pile[0].DealOneCard();
            return dealtCard;
        }


        /// <summary>
        /// Deals the cards at the start of the game
        /// </summary>
        public static void DealInitialCards() {
            for (int i = 0; i <= 8; i++) {
                DealOneCardTo(0);
                DealOneCardTo(1);
            }
            pile[1].Add(DealDiscardCard());
        }


        /// <returns>The last card of the draw pile for the GUI Image</returns>
        public static Card GetDrawPileCard() {
            return pile[0].GetLastCardInPile();
        }


        /// <returns>Returns the last card in the discard pile</returns>
        public static Card GetDiscardPileCard() {
            return pile[1].GetLastCardInPile();
        }


        /// <returns>The Computer's Current Hand Object</returns>
        public static Hand GetComputerHand() {
            return hands[1];
        }


        /// <returns>The Player's Current Hand Object</returns>
        public static Hand GetPlayerHand() {
            return hands[0];
        }


        /// <returns>The Current Draw Card FaceValue</returns>
        public static FaceValue Get_Card_Number() {
            Card card = GetDiscardPileCard();
            FaceValue face = card.GetFaceValue();
            return face;
        }

        /// <returns>The Current Draw Card Suit</returns>
        public static Suit Get_Card_Suit() {
            Card card = GetDiscardPileCard();
            Suit suit = card.GetSuit();
            return suit;
        }


        /// <summary>
        /// Changes the suit by adding another card to the top of the discard pile
        /// </summary>
        /// <param name="newSuit"></param>
        /// <param name="oldFaceValue"></param>
        public static void ChangeSuit(Suit newSuit, FaceValue oldFaceValue) {
            Card newCard;
            newCard = new Card(newSuit, oldFaceValue);
            pile[1].Add(newCard);
        }


        /// <summary>
        /// Checks if a hand has a playable card in it
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        /// <returns>True if a Card is Playable</returns>
        public static bool PlayableCard(Hand hand, FaceValue face, Suit suit) {
            bool playable = false;
            int handCount = hand.GetCount();
            Card[] card = new Card[handCount];

            for (int i = 0; i < handCount; i++) {
                card[i] = hand.GetCard(i);
                if (card[i].GetSuit() == suit) {
                    playable = true;
                    break;
                } else if (card[i].GetFaceValue() == face) {
                    playable = true;
                    break;
                } else if (card[i].GetFaceValue() == FaceValue.Eight) {
                    playable = true;
                    break;
                } else {
                    playable = false;
                }
            }
            return playable;
        }


        /// <summary>
        /// Logic for the computer's playing habits, 
        /// plays any cards of the same FaceValue, Suit, 
        /// or a card with a value of eight in that order
        /// </summary>
        /// <returns></returns>
        public static Card ComputerPlayCard() {
            int handCount = hands[1].GetCount();
            Card[] card = new Card[handCount];
            Card playCard = new Card();
            for (int i = 0; i < handCount; i++) {
                card[i] = hands[1].GetCard(i);
                if (card[i].GetFaceValue() == GetDiscardPileCard().GetFaceValue()) {
                    playCard = card[i];
                } else if (card[i].GetSuit() == GetDiscardPileCard().GetSuit() && card[i].GetFaceValue() != FaceValue.Eight) {
                    playCard = card[i];
                }
            }
            return playCard;
        }

        /// <summary>
        /// Removes the specified card from the player's hand and adds it to the discard Pile
        /// </summary>
        /// <param name="clickedCard"></param>
        public static void RemoveCardFromPlayer(Card clickedCard) {
            FaceValue face = clickedCard.GetFaceValue();
            pile[1].Add(clickedCard);
            hands[0].Remove(clickedCard);

        }


        /// <summary>
        /// Removes the specified card from the Computer's hand
        /// and adds it to the discard Pile
        /// </summary>
        /// <param name="clickedCard"></param>
        public static void RemoveCardFromComputer(Card clickedCard) {

            pile[1].Add(clickedCard);
            hands[1].Remove(clickedCard);

        }


        /// <summary>
        /// Checks to see if any player has no cards in their hands
        /// </summary>
        /// <returns>Name of Winner as a String, i.e. "Player", "Computer", "None"</returns>
        public static string CheckWinner() {
            if (hands[0].GetCount() == 0) {
                return "Player";
            } else if (hands[1].GetCount() == 0) {
                return "Computer";
            } else {
                return "None";
            }
        }


    }
}