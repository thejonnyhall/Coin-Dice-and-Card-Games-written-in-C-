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

        public string selection;

        public ChooseSuitForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (Crazy_Eights_RadioClubs.Checked) {
                selection = "Clubs";
            } else if (Crazy_Eights_RadioDiamond.Checked) {
                selection = "Diamonds";
            } else if (Crazy_Eights_RadioHearts.Checked) {
                selection = "Hearts";
            } else if (Crazy_Eights_RadioSpades.Checked) {
                selection = "Spades";
            } else {
                MessageBox.Show("Please Select A Suit!");
            }
            this.Close();
        }
    }
}
