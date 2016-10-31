using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace ClassAssignment {
    public partial class Crazy_Eights : Form {

        bool playerTurn; // True if it is curretly the player's turn

        /// <summary>
        /// Initialises variables and sets up the initial button configurations
        /// </summary>
        public Crazy_Eights() {
            InitializeComponent();
            Crazy_Eight_Game.SetUpGame();
            Crazy_Eights_DiscardPictureBox.Image = Images.GetBackOfCardImage();
            Crazy_Eights_InfoLabel.Text = "Click Deal to Start the Game!";
            Crazy_Eights_SortButton.Enabled = false;
            Crazy_Eights_DiscardPictureBox.Enabled = false;
            playerTurn = true;
        }


        /// <summary>
        /// Updates the images of all of the face up cards
        /// </summary>
        private void Update_Images() {
            DisplayGuiHand(Crazy_Eight_Game.GetPlayerHand(), Crazy_Eights_PlayerTable, 0);
            DisplayGuiHand(Crazy_Eight_Game.GetComputerHand(), Crazy_Eights_ComputerTable, 1);
            Crazy_Eights_DrawPictureBox.Image = Images.GetCardImage(Crazy_Eight_Game.GetDiscardPileCard()); // ??
        }


        /// <summary>
        /// Deals the initial cards, disables itself, enables the sort button and the draw pile event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crazy_Eights_DealButton_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.DealInitialCards();
            Crazy_Eights_DealButton.Enabled = false;
            Crazy_Eights_SortButton.Enabled = true;
            Crazy_Eights_DiscardPictureBox.Enabled = true;
            Crazy_Eights_InfoLabel.Text = "Your Turn, Click on a card to play it!";
            Update_Images();
        }


        /// <summary>
        /// Sorts the cards in the player's hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crazy_Eights_SortButton_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.SortCards();
            Update_Images();
        }


        /// <summary>
        /// When the user clicks the draw card, this checks if the user can draw a card based on what they have on their hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crazy_Eights_DrawPictureBox_Click(object sender, EventArgs e) {
            if (!Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetPlayerHand(),
                Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(),
                Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                int playercards = Crazy_Eight_Game.GetPlayerHand().GetCount();
                if (playercards >= 13) {
                    Crazy_Eights_InfoLabel.Text = "You cannot draw a card, You have the maximum amount of cards!";
                } else {
                    try {
                        Crazy_Eight_Game.DealOneCardTo(0);
                    } catch {
                        MessageBox.Show("Tie");
                        this.Close();
                    }
                }
            } else {
                Crazy_Eights_InfoLabel.Text = "You cannot draw a card, You have playable cards in your hand";
            }
            Update_Images();
        }


        /// <summary>
        /// Sets up the card images for the user to click on and see on the computers side
        /// </summary>
        /// <param name="hand">Hand[0] for player, Hand[1] for Computer</param>
        /// <param name="tableLayoutPanel">Either the ComputerTable or the Playertable</param>
        /// <param name="who">0 For the Player, 1 for the Computer</param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int who) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Allow the user to click on a card in their hand.
                if (who == 0) {
                    // Set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // Tell the PictureBox which Card object it is a picture of.
                    pictureBox.Tag = card;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand


        /// <summary>
        /// Event Handler for clicking on a card image, only tries to play card if it is the players turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e) {
            // Which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            Card clickedCard = (Card)clickedPictureBox.Tag;
            if (playerTurn == true) {
                TryToPlayCard(clickedCard);
            } else {
                Crazy_Eights_InfoLabel.Text = " It is not your turn!";
            }
        }


        /// <summary>
        /// Opens a form to ask the user what suit they would like to change to after playing an Eight.
        /// </summary>
        /// <returns></returns>
        private string ChooseSuit() {
            string selection = "None";
            ChooseSuitForm chooseSuit = new ChooseSuitForm();
            var result = chooseSuit.ShowDialog();
            if (result == DialogResult.OK) {
                selection = chooseSuit.selection;
                chooseSuit.Close();
            }
            return selection;
        }


        /// <summary>
        /// Prompts the user to change the current suit to be played, and removes the played card from the users hand
        /// </summary>
        /// <param name="clickedCard">The Card the user has clicked on</param>
        /// <param name="clickedFaceValue">the </param>
        private void Card_Is_Eight(Card clickedCard, FaceValue currentCardFaceValue) {
            string newSuit = ChooseSuit();
            if (newSuit == "Spades") {
                Crazy_Eight_Game.ChangeSuit(Suit.Spades, currentCardFaceValue);
            } else if (newSuit == "Hearts") {
                Crazy_Eight_Game.ChangeSuit(Suit.Hearts, currentCardFaceValue);
            } else if (newSuit == "Diamonds") {
                Crazy_Eight_Game.ChangeSuit(Suit.Diamonds, currentCardFaceValue);
            } else if (newSuit == "Clubs") {
                Crazy_Eight_Game.ChangeSuit(Suit.Clubs, currentCardFaceValue);
            } else if (newSuit == "None") {
                newSuit = ChooseSuit();
            }
            Crazy_Eight_Game.RemoveCardFromPlayer(clickedCard);
            playerTurn = false;
            Update_Images();
        }


        /// <summary>
        /// Checks if either player is out of cards, alerts the player to who has won, then closes the form
        /// </summary>
        private void Check_Winner() {
            if (Crazy_Eight_Game.CheckWinner() == "Player") {
                MessageBox.Show("Player Wins");
                this.Close();
            } else if (Crazy_Eight_Game.CheckWinner() == "Computer") {
                MessageBox.Show("Computer Wins");
                this.Close();
            }
        }

        /// <summary>
        /// Attempts to match the user selected card to a card in the users hand and removes it if it is present. 
        /// Otherwise it will alert the user that they cannot play a particular card, or if they need to draw a card
        /// </summary>
        /// <param name="clickedCard"></param>
        private void TryToPlayCard(Card clickedCard) {

            Suit clickedSuit = clickedCard.GetSuit();
            FaceValue clickedFaceValue = clickedCard.GetFaceValue();
            Suit topCardSuit = Crazy_Eight_Game.Get_Card_Suit();
            FaceValue topCardFaceValue = Crazy_Eight_Game.Get_Card_Number();


            if (!Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetPlayerHand(),
                Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(),
                Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                Crazy_Eights_InfoLabel.Text = "User must draw a card from the draw pile";
            }

            if (clickedFaceValue == FaceValue.Eight) {
                Card_Is_Eight(clickedCard, clickedFaceValue);
            } else if (topCardSuit == clickedSuit &&
                clickedFaceValue != FaceValue.Eight ||
                topCardFaceValue == clickedFaceValue &&
                clickedFaceValue != FaceValue.Eight ||
                topCardFaceValue == FaceValue.Eight) {
                Crazy_Eight_Game.RemoveCardFromPlayer(clickedCard);
                Crazy_Eights_InfoLabel.Text = "You Just Played a Card!";
                playerTurn = false;
            } else {
                Crazy_Eights_InfoLabel.Text = "You cannot play that card right now, Try another!";
            }

            Check_Winner();
            Update_Images();

            if (playerTurn == false) {
                ComputerTurn();
            }
        }


        /// <summary>
        /// Checks if the computer has a playable card, if it doesn't, the computer draws a card
        /// </summary>
        private void ComputerTurn() {
            if (Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetComputerHand(),
                Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(),
                Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                Crazy_Eight_Game.RemoveCardFromComputer(Crazy_Eight_Game.ComputerPlayCard());
                playerTurn = true;
            } else {
                try {
                    Crazy_Eight_Game.DealOneCardTo(1);
                    ComputerTurn();
                } catch {
                    MessageBox.Show("Tie");
                    this.Close();
                }

            }
            Update_Images();
        }


        /// <summary>
        /// Cancel Button opens a Yes/No Dialouge for the User to choose if the window is to be closed
        /// </summary>
        private void Crazy_Eights_CancelButton_Click(object sender, EventArgs e) {
            DialogResult quit_Yes_Or_No = MessageBox.Show("Do you really want to quit?",
                                    "Quit", // The MessageBox's caption.
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (quit_Yes_Or_No == DialogResult.Yes) {
                this.Close();
            }
        }

    }
}