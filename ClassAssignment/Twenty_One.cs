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
    public partial class Twenty_One : Form {
        private const int NUM_PLAYERS = 2;
        private const int MAX_CARDS = 8;
        private const int BLACK_JACK = 21;
        private const string WIN = "You win!";
        private const string LOSE = "You lose!";
        private const string DRAW = "It was a draw!";

        /// <summary>
        /// Main entry point of form
        /// </summary>
        public Twenty_One() {
            InitializeComponent();
            hitButton.Enabled = false;
            standButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        /// <summary>
        /// Updates all visuals when needed
        /// </summary>
        private void RestartGame() {
            TableLayoutPanel[] tableLayoutPanels = { playerTableLayoutPanel, dealerTableLayoutPanel };
            Label[] bustedLabels = { playerBustedLabel, dealerBustedLabel };
            Label[] pointsLabels = { playerPointsLabel, dealerPointsLabel };
            Label[] gamesWonScores = { playerGamesWon, dealerGamesWon };

            // Updates Table Layout, Games Label, Busted Label, Points Label and Aces Label
            for (int i = 0; i < NUM_PLAYERS; i++) {
                DisplayGuiHand(Twenty_One_Game.GetHand(i), tableLayoutPanels[i]);
                gamesWonScores[i].Text = Twenty_One_Game.GetNumOfGamesWon(i).ToString();
                bustedLabels[i].Visible = Twenty_One_Game.GetTotalPoints(i) > 21;
                pointsLabels[i].Text = Twenty_One_Game.GetTotalPoints(i).ToString();
                playerAces.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
            }
        }

        /// <summary>
        /// Depending on which hand and table to use, displays cards
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        /// <summary>
        /// First sequence of the game where both the Player and Dealer are dealt 2 cards
        /// Enables buttons for next sequence of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealButton_Click(object sender, EventArgs e) {
            Twenty_One_Game.SetUpGame();
            for (int i = 0; i < NUM_PLAYERS; i++) {
                Card playerCard = Twenty_One_Game.DealOneCardTo(0);
                Check_Ace(playerCard);
                Twenty_One_Game.DealOneCardTo(1);
            }
            RestartGame();
            if (Twenty_One_Game.GetTotalPoints(1) == BLACK_JACK) {
                Twenty_One_Game.PlayForDealer();
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                standButton.Enabled = false;
                cancelButton.Enabled = true;
            } else {
                dealButton.Enabled = false;
                hitButton.Enabled = true;
                standButton.Enabled = true;
                cancelButton.Enabled = true;
            }
        }

        /// <summary>
        /// Exits the game, tells user whether they've won, lost, or drawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelbutton_Click(object sender, EventArgs e) {
            Close();
            MessageBox.Show((Twenty_One_Game.GetNumOfGamesWon(0) > Twenty_One_Game.GetNumOfGamesWon(1) ? WIN : Twenty_One_Game.GetNumOfGamesWon(1) > Twenty_One_Game.GetNumOfGamesWon(0) ? LOSE : DRAW));
            Twenty_One_Game.ResetTotals();
        }

        /// <summary>
        /// One of three possible options for the second sequence of the game
        /// Deals one card to the player and checks if it's an ace
        /// Enables and disables buttons depending on whether the player has busted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e) {
            Card playerCard = Twenty_One_Game.DealOneCardTo(0);
            Check_Ace(playerCard);
            RestartGame();
            if (Twenty_One_Game.GetHand(0).GetCount() == MAX_CARDS) {
                hitButton.Enabled = false;
            } else if (Twenty_One_Game.GetTotalPoints(0) > BLACK_JACK) {
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            }
        }

        /// <summary>
        /// One of three possible options for the second sequence of the game
        /// Stands for the player, allowing the Dealer to take a turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e) {
            Twenty_One_Game.PlayForDealer();
            RestartGame();
            dealButton.Enabled = true;
            hitButton.Enabled = false;
            standButton.Enabled = false;
        }

        /// <summary>
        /// Checks for ace depending on a given card
        /// Asks the user for which value they want to assign it
        /// </summary>
        /// <param name="card"></param>
        private void Check_Ace(Card card) {
            if (card.GetFaceValue() == FaceValue.Ace) {
                DialogResult Ace = MessageBox.Show("Count Ace as 1?",
                                   "Ace",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (Ace == DialogResult.Yes) {
                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                }
                RestartGame();
            }
        }
    }
}