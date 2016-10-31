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

namespace ClassAssignment {
    public partial class Two_Up : Form {

        bool tempCoinState = false; // The Temporary state of each coin during the 'flip' animation
        int timerClickCounter; // Keeps track of the number of flip animations

        /// <summary>
        /// Initialises class variables and initilises the default coin images
        /// </summary>
        public Two_Up() {
            InitializeComponent();
            Two_Up_Game.SetUpGame();
            UpdateImages();
        }

        /// <summary>
        /// Updates the images in the picture box based on the its parameters
        /// specifying which box to affect and if the coin is heads or not.
        /// </summary>
        /// <param name="whichPB"></param>
        /// <param name="isHeads"></param>
        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads) {
            whichPB.Image = Images.GetCoinImage(isHeads);
        }// End of UpdatePictureBoxImage method


        /// <summary>
        /// Updates Images in both boxes using the UpdatePictureBoxImage method
        /// </summary>
        private void UpdateImages() {
            UpdatePictureBoxImage(Two_Up_CoinBox_1, Two_Up_Game.IsHeads(1));
            UpdatePictureBoxImage(Two_Up_CoinBox_2, Two_Up_Game.IsHeads(2));
        } // End of UpdateImages Method


        // Closes the form
        private void Two_Up_CancelGame_Button_Click(object sender, EventArgs e) {
            this.Close();
        } // End of Two_Up_CancelGame_Button_Click method


        // Clicking the 'Play Again' Button enables the 'Throw Coin' Button and makes itself invisible
        private void Two_Up_PlayAgain_Button_Click(object sender, EventArgs e) {
            Two_Up_ThrowCoin_Button.Enabled = true;
            Two_Up_PlayAgain_Button.Visible = false;
        } // End of Two_Up_PlayAgain_Button_Click method


        // Event Handler that initialises the coin animation timer
        private void Two_Up_ThrowCoin_Button_Click(object sender, EventArgs e) {
            timerClickCounter = 0;
            Two_Up_ThrowCoin_Button.Enabled = false;
            Two_Up_Timer.Start();
        } // End of Two_Up_ThrowCoin_Button_Click method


        /// <summary>
        /// Tosses both coins and displays the outcome, adding points to the winners score
        /// and updating the coin images to their relevant faces. 
        /// </summary>
        private void Play_Two_Up() {
            Two_Up_Game.TossCoins();
            Two_Up_Outcome_Label.Visible = true;
            Two_Up_Outcome_Label.Text = Two_Up_Game.TossOutcome();
            Two_Up_ComputerScore_Number.Text = Two_Up_Game.GetComputersScore().ToString();
            Two_Up_PlayerScore_Number.Text = Two_Up_Game.GetPlayersScore().ToString();
            UpdateImages();
            if (Two_Up_Game.TossOutcome() != "Odds") {
                Two_Up_PlayAgain_Button.Visible = true;
                Two_Up_ThrowCoin_Button.Enabled = false;
            }
        }

        /// <summary>
        /// Event handler for the timer which creates the delay for the coin flip animation 
        /// and calls the Play_Two_Up function at the end
        /// </summary>
        private void Two_Up_Timer_Tick(object sender, EventArgs e) {
            UpdatePictureBoxImage(Two_Up_CoinBox_1, tempCoinState);
            UpdatePictureBoxImage(Two_Up_CoinBox_2, !tempCoinState);
            tempCoinState = !tempCoinState;
            if (timerClickCounter == 10) {
                Play_Two_Up();
                Two_Up_ThrowCoin_Button.Enabled = true;
                Two_Up_Timer.Stop();
            } else {
                timerClickCounter++;
            }
        } // End of Two_Up_Timer_Tick method


    }
}
