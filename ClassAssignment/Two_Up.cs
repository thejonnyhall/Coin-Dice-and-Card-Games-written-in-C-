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

namespace ClassAssignment
{
    public partial class Two_Up : Form
    {
        public Two_Up()
        {
            InitializeComponent();

            Two_Up_Game.SetUpGame();
            UpdateImages();
        }

        private void UpdateImages()
        {
            UpdatePictureBoxImage(pictureBox1, Two_Up_Game.IsHeads(1));
            UpdatePictureBoxImage(pictureBox2, Two_Up_Game.IsHeads(2));
        }

        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads)
        {
            whichPB.Image = Images.GetCoinImage(isHeads);
        }

        private void UpdateScores()
        {
            playerScoreLabel.Text = Two_Up_Game.GetPlayersScore().ToString();
            computerScoreLabel.Text = Two_Up_Game.GetComputersScore().ToString();
        }

        private void ResetForm()
        {
            Two_Up_Game.SetUpGame();
            UpdateScores();
            gameWonLabel.Visible = false;
        }

        private void Two_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            ResetForm();
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            coinThrowButton.Enabled = true;
            replayButton.Enabled = false;
            replayButton.Visible = false;
        }

        private void coinThrowButton_Click(object sender, EventArgs e)
        {
            coinThrowButton.Enabled = false;
            replayButton.Enabled = true;
            replayButton.Visible = true;

            Two_Up_Game.TossCoins();
            gameWonLabel.Visible = true;
            gameWonLabel.Text = Two_Up_Game.TossOutcome();
            UpdateScores();
            UpdateImages();
        }
    }
}