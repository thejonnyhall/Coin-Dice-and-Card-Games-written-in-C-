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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
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

        private void cardComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int cardComboBox_selection = cardComboBox.SelectedIndex;
            if (cardComboBox_selection == 0) {
                Form Twenty_One = new Twenty_One();
                Twenty_One.Show();
            } else if (cardComboBox_selection == 1) {
                Form Crazy_Eights = new Crazy_Eights();
                Crazy_Eights.Show();
            }

        }
    }
}
