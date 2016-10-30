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

        bool playerTurn;

        /// <summary>
        /// 
        /// </summary>
        public Crazy_Eights() {
            InitializeComponent();
            Crazy_Eight_Game.SetUpGame();
            Crazy_Eights_DiscardPictureBox.Image = Images.GetBackOfCardImage();
            Crazy_Eights_InfoLabel.Text = "Click Deal to Start the Game!";
            Crazy_Eights_SortButton.Enabled = false;
            playerTurn = true;
        }


        /// <summary>
        /// 
        /// </summary>
        private void Update_Images() {
            DisplayGuiHand(Crazy_Eight_Game.GetPlayerHand(), Crazy_Eights_PlayerTable, 0);
            DisplayGuiHand(Crazy_Eight_Game.GetComputerHand(), Crazy_Eights_ComputerTable, 0);
            Crazy_Eights_DrawPictureBox.Image = Images.GetCardImage(Crazy_Eight_Game.GetDiscardPileCard()); // ??
        }


        private void Crazy_Eights_DealButton_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.DealInitialCards();
            Crazy_Eights_DealButton.Enabled = false;
            Crazy_Eights_SortButton.Enabled = true;
            Crazy_Eights_InfoLabel.Text = "Your Turn, Click on a card to play it!";
            Update_Images();
        }


        private void Crazy_Eights_SortButton_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.SortCards();
            Update_Images();
        }



        private void Crazy_Eights_DrawPictureBox_Click(object sender, EventArgs e) {
            if (!Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetPlayerHand(), Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(), Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                Crazy_Eight_Game.DealOneCardTo(0);
            } else {
                Crazy_Eights_InfoLabel.Text = "You cannot draw a card, You have playable cards in your hand";
            }

        }


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
        /// C
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
        /// 
        /// </summary>
        /// <returns></returns>
        private string ChooseSuit() {
            ChooseSuitForm chooseSuit = new ChooseSuitForm();
            var result = chooseSuit.ShowDialog();
            if (result == DialogResult.OK) {
                return chooseSuit.selection;
            } else {
                return Crazy_Eight_Game.Get_Card_Suit().ToString();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickedCard"></param>
        /// <param name="clickedFaceValue"></param>
        private void Card_Is_Eight(Card clickedCard, FaceValue clickedFaceValue) {
            string newSuit = ChooseSuit();
            if (newSuit == "Spades") {
                Crazy_Eight_Game.ChangeSuit(Suit.Spades, clickedFaceValue);
            } else if (newSuit == "Hearts") {
                Crazy_Eight_Game.ChangeSuit(Suit.Hearts, clickedFaceValue);
            } else if (newSuit == "Diamonds") {
                Crazy_Eight_Game.ChangeSuit(Suit.Diamonds, clickedFaceValue);
            } else if (newSuit == "Clubs") {
                Crazy_Eight_Game.ChangeSuit(Suit.Clubs, clickedFaceValue);
            }
            Crazy_Eight_Game.RemoveCardFromPlayer(clickedCard);
            playerTurn = false;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickedCard"></param>
        private void TryToPlayCard(Card clickedCard) {

            Suit clickedSuit = clickedCard.GetSuit();
            FaceValue clickedFaceValue = clickedCard.GetFaceValue();
            Suit topCardSuit = Crazy_Eight_Game.Get_Card_Suit();
            FaceValue topCardFaceValue = Crazy_Eight_Game.Get_Card_Number();


            if (!Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetPlayerHand(), Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(), Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                Crazy_Eights_InfoLabel.Text = "User must draw a card from the draw pile";
            }

            if (clickedFaceValue == FaceValue.Eight) {
                Card_Is_Eight(clickedCard, clickedFaceValue);
            } else if (topCardSuit == clickedSuit &&
                clickedFaceValue != FaceValue.Eight ||
                topCardFaceValue == clickedFaceValue &&
                clickedFaceValue != FaceValue.Eight) {
                Crazy_Eight_Game.RemoveCardFromPlayer(clickedCard);
                Crazy_Eights_InfoLabel.Text = "You Just Played a Card!";
                playerTurn = false;
            } else {
                Crazy_Eights_InfoLabel.Text = "You cannot play that card right now, Try another!";
            }

            // Dunno if this works
            if (Crazy_Eight_Game.CheckWinner() == "Player") {
                MessageBox.Show("Player Wins");
            } else if (Crazy_Eight_Game.CheckWinner() == "Computer") {
                MessageBox.Show("Computer Wins");
            }

            Update_Images();

            if (playerTurn == false) {
                ComputerTurn();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void ComputerTurn() {
            if (Crazy_Eight_Game.PlayableCard(Crazy_Eight_Game.GetComputerHand(), Crazy_Eight_Game.GetDiscardPileCard().GetFaceValue(), Crazy_Eight_Game.GetDiscardPileCard().GetSuit())) {
                Crazy_Eight_Game.RemoveCardFromComputer(Crazy_Eight_Game.ComputerPlayCard());
                playerTurn = true;
            } else {
                Crazy_Eight_Game.DealOneCardTo(1);
                ComputerTurn();
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

        private void Crazy_Eights_DiscardPictureBox_Click(object sender, EventArgs e) {

        }
    }
}