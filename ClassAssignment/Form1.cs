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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Form Two_Up = new Two_Up();
        Form Which_Dice_Game = new Which_Dice_Game();
        Form Which_Card_Game = new Which_Card_Game();
        Form whichForm;

        private void groupBox1_Enter(object sender, EventArgs e) {
        }


        private void coinRadioButton_CheckedChanged(object sender, EventArgs e) {
            StartButton.Enabled = true;
            RadioButton whichGame = (RadioButton)sender;
            if (whichGame.Name == "coinRadioButton") {
                whichForm = Two_Up;
            }
        }

        private void diceRadioButton_CheckedChanged(object sender, EventArgs e) {
            StartButton.Enabled = true;
            RadioButton whichGame = (RadioButton)sender;
            if (whichGame.Name == "diceRadioButton") {
                whichForm = Which_Dice_Game;
            }
        }
        
        private void cardRadioButton_CheckedChanged(object sender, EventArgs e) {
            StartButton.Enabled = true;
            RadioButton whichGame = (RadioButton)sender;
            if (whichGame.Name == "cardRadioButton") {
                whichForm = Which_Card_Game;
            }
        }

        private void startButton_Click(object sender, EventArgs e) {
            // Shows the form that is currently selected
            whichForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Would you really like to Exit?", // The question. 
                                     "Don't Leave us!", // The MessageBox's caption.
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                // If the user clicked the Yes button
                if (result == DialogResult.Yes) {
                Close();
                } else {
            }
        }
    }
}
