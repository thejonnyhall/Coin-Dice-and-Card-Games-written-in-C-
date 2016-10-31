using Games_Logic_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment {
    public partial class Snake_Eyes : Form {
        bool secondRoll = false;
        bool anotherRoll = false;

        public Snake_Eyes() {
            InitializeComponent();
            continueButton.Enabled = false;
            cancelButton.Enabled = false;
            Snake_Eyes_Game.SetUpGame();
            label5.Text = "0";
            label6.Text = "0";
        }

        private void UpdatePictures() {
            PictureBox[] pictures = { pictureBox1, pictureBox2 };
            for (int i = 0; i < pictures.Length; i++) {
                pictures[i].Image = Images.GetDieImage(Snake_Eyes_Game.GetDieFacevalue(i));
            }
        }
        /// <summary>
        //First Roll
        //            => sum = 4
        //		=> needs a 2nd rolls
        //Second Roll
        //    => sum = 4
        //		=> needs a NEW roll
        //        => playerPoints += 4
        //First Roll
        //    => sum = 2
        //		=> news a NEW roll
        //        => playerPoints += 2
        //First Roll
        //    => sum = 5
        //		=> needs a 2nd roll
        //Second Roll
        //    => sum = 5
        //		=> needs a NEW roll
        //First Roll
        //    => sum = 6
        //		=> needs a 2nd roll
        //Second Roll
        //    => sum = 7
        //		=> needs a NEW roll
        //First Roll
        //    => sum = 2
        //		=> news a NEW roll
        //First Roll
        //    => sum = 2
        //		=> news a NEW roll
        //First Roll
        //    => sum = 2
        //		=> news a NEW roll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            string win = "Congratulations you won!";
            string lose = "Sorry you lost!";
            string draw = "It was a draw!";
            string rollAgain = "Roll Dice Again";
            string requiredPoints = "you need to roll {0} points";
            string pointsWon = "You get {0} points";
            string pointsLost = "House gets {0} points";
            string nothing = "Nothing happened!";
            if (!secondRoll) {
                secondRoll = Snake_Eyes_Game.FirstRoll();
                if (!secondRoll) {
                    label1.Text = (Snake_Eyes_Game.GetPlayerPoints() > 0) ? win : (Snake_Eyes_Game.GetHousePoints() > 0) ? lose : draw;
                    if (Snake_Eyes_Game.GetRollTotal() == 2) {
                        label2.Text = string.Format(pointsWon, 2);
                    } else if (Snake_Eyes_Game.GetRollTotal() == 7 || Snake_Eyes_Game.GetRollTotal() == 11) {
                        label2.Text = string.Format(pointsWon, 1);
                    } else if (Snake_Eyes_Game.GetRollTotal() == 3 || Snake_Eyes_Game.GetRollTotal() == 12) {
                        label2.Text = string.Format(pointsLost, 2);
                    }
                } else {
                    label1.Text = rollAgain;
                    label2.Text = string.Format(requiredPoints, Snake_Eyes_Game.GetPossiblePoints());
                    continueButton.Enabled = true;
                }
            } else {
                anotherRoll = Snake_Eyes_Game.AnotherRoll();
                secondRoll = false;
                label1.Text = (Snake_Eyes_Game.GetPlayerPoints() > 0) ? win : (Snake_Eyes_Game.GetHousePoints() > 0) ? lose : draw;
                if (!anotherRoll) {
                    label2.Text = string.Format(pointsWon, Snake_Eyes_Game.GetPossiblePoints());
                } else if (Snake_Eyes_Game.GetRollTotal() == 7) {
                    label2.Text = string.Format(pointsLost, 2);
                } else {
                    label2.Text = nothing;
                }
            }
            label2.Visible = true;
            label5.Text = Snake_Eyes_Game.GetPlayerPoints().ToString();
            label6.Text = Snake_Eyes_Game.GetHousePoints().ToString();
            continueButton.Enabled = true;
            rollDiceButton.Enabled = false;
            cancelButton.Enabled = true;

            UpdatePictures();
        }

        private void continueButton_Click(object sender, EventArgs e) {
            rollDiceButton.Enabled = true;
            continueButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
            MessageBox.Show(Snake_Eyes_Game.GetRollOutcome());
        }
    }
}