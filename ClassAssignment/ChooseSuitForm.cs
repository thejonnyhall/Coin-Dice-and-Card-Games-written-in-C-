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
    public partial class ChooseSuitForm : Form {

        // String Variable used to decide what suit
        public string selection;

        public ChooseSuitForm() {
            InitializeComponent();
            // Initially the radio buttons are not checked
            clubsRadioButton.Checked = false;
            heartsRadioButton.Checked = false;
            spadesRadioButton.Checked = false;
            diamondRadioButton.Checked = false;
            // Defining the Button into an "OK" button
            button1.DialogResult = DialogResult.OK;
    }

        private void button1_Click(object sender, EventArgs e) {
            if (clubsRadioButton.Checked) {
                selection = "Clubs";
            } else if (diamondRadioButton.Checked) {
                selection = "Diamonds";
            } else if (heartsRadioButton.Checked) {
                selection = "Hearts";
            } else if (spadesRadioButton.Checked) {
                selection = "Spades";
            } else {
                MessageBox.Show("Please Select A Suit!");
            }
        }
    }
}
