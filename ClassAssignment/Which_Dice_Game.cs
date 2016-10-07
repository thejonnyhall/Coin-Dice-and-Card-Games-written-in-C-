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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
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

        // This opens the form that the user selects from the comboBox
        private void diceComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int diceComboBox_selection = diceComboBox.SelectedIndex;

            if (diceComboBox_selection == 0) {
                Form Snake_Eyes = new Snake_Eyes();
                Snake_Eyes.Show();
            } else if (diceComboBox_selection == 1) {
                Form Ship_Captain_Crew = new Ship_Captain_Crew();
                Ship_Captain_Crew.Show();
            }
        }
    }
}
