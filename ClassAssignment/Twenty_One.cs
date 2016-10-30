using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace ClassAssignment {
    public partial class Twenty_One : Form {
        public Twenty_One() {
            InitializeComponent();

            Twenty_One_Game.SetUpGame();

            TableLayoutPanel[] tableLayoutPanels;
            Label[] bustedLabels;
            Label[] pointsLabels;
            Label[] gamesWonLabels;

            tableLayoutPanels = new TableLayoutPanel[Twenty_One_Game.NUM_OF_PLAYERS] { playerTableLayoutPanel, dealerTableLayoutPanel };
            bustedLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { playerBustedLabel, dealerBustedLabel };
            pointsLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { playerPointsLabel, dealerPointsLabel };
            gamesWonLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { playerGamesWonLabel, dealerGamesWonLabel };
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear();

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

        private void Twenty_One_FormClosing(object sender, FormClosingEventArgs e) {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void testButton_Click(object sender, EventArgs e) {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;

            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();

            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));

            DisplayGuiHand(testHandForDealer, dealerTableLayoutPanel);
            DisplayGuiHand(testHandForPlayer, playerTableLayoutPanel);
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            MessageBox.Show("End Game Result:");
        }

        private void dealButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < 2; i++) {
                Twenty_One_Game.DealOneCardTo(0);
                Twenty_One_Game.DealOneCardTo(1);
            }
            dealButton.Enabled = false;

            DisplayGuiHand(Twenty_One_Game.GetHand(0), playerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(1), dealerTableLayoutPanel);

        }

        private void hitButton_Click(object sender, EventArgs e) {

        }
    }
}
