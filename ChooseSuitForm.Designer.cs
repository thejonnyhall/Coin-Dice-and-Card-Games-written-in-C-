namespace ClassAssignment {
    partial class ChooseSuitForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Crazy_Eights_RadioDiamond = new System.Windows.Forms.RadioButton();
            this.Crazy_Eights_RadioHearts = new System.Windows.Forms.RadioButton();
            this.Crazy_Eights_RadioSpades = new System.Windows.Forms.RadioButton();
            this.Crazy_Eights_RadioClubs = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Crazy_Eights_RadioDiamond);
            this.groupBox1.Controls.Add(this.Crazy_Eights_RadioHearts);
            this.groupBox1.Controls.Add(this.Crazy_Eights_RadioSpades);
            this.groupBox1.Controls.Add(this.Crazy_Eights_RadioClubs);
            this.groupBox1.Location = new System.Drawing.Point(42, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose A Suit";
            // 
            // Crazy_Eights_RadioDiamond
            // 
            this.Crazy_Eights_RadioDiamond.AutoSize = true;
            this.Crazy_Eights_RadioDiamond.Location = new System.Drawing.Point(30, 132);
            this.Crazy_Eights_RadioDiamond.Name = "Crazy_Eights_RadioDiamond";
            this.Crazy_Eights_RadioDiamond.Size = new System.Drawing.Size(67, 17);
            this.Crazy_Eights_RadioDiamond.TabIndex = 3;
            this.Crazy_Eights_RadioDiamond.TabStop = true;
            this.Crazy_Eights_RadioDiamond.Text = "Diamond";
            this.Crazy_Eights_RadioDiamond.UseVisualStyleBackColor = true;
            // 
            // Crazy_Eights_RadioHearts
            // 
            this.Crazy_Eights_RadioHearts.AutoSize = true;
            this.Crazy_Eights_RadioHearts.Location = new System.Drawing.Point(30, 100);
            this.Crazy_Eights_RadioHearts.Name = "Crazy_Eights_RadioHearts";
            this.Crazy_Eights_RadioHearts.Size = new System.Drawing.Size(56, 17);
            this.Crazy_Eights_RadioHearts.TabIndex = 2;
            this.Crazy_Eights_RadioHearts.TabStop = true;
            this.Crazy_Eights_RadioHearts.Text = "Hearts";
            this.Crazy_Eights_RadioHearts.UseVisualStyleBackColor = true;
            // 
            // Crazy_Eights_RadioSpades
            // 
            this.Crazy_Eights_RadioSpades.AutoSize = true;
            this.Crazy_Eights_RadioSpades.Location = new System.Drawing.Point(30, 66);
            this.Crazy_Eights_RadioSpades.Name = "Crazy_Eights_RadioSpades";
            this.Crazy_Eights_RadioSpades.Size = new System.Drawing.Size(61, 17);
            this.Crazy_Eights_RadioSpades.TabIndex = 1;
            this.Crazy_Eights_RadioSpades.TabStop = true;
            this.Crazy_Eights_RadioSpades.Text = "Spades";
            this.Crazy_Eights_RadioSpades.UseVisualStyleBackColor = true;
            // 
            // Crazy_Eights_RadioClubs
            // 
            this.Crazy_Eights_RadioClubs.AutoSize = true;
            this.Crazy_Eights_RadioClubs.Location = new System.Drawing.Point(30, 33);
            this.Crazy_Eights_RadioClubs.Name = "Crazy_Eights_RadioClubs";
            this.Crazy_Eights_RadioClubs.Size = new System.Drawing.Size(51, 17);
            this.Crazy_Eights_RadioClubs.TabIndex = 0;
            this.Crazy_Eights_RadioClubs.TabStop = true;
            this.Crazy_Eights_RadioClubs.Text = "Clubs";
            this.Crazy_Eights_RadioClubs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ChooseSuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChooseSuitForm";
            this.Text = "ChooseSuitForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Crazy_Eights_RadioDiamond;
        private System.Windows.Forms.RadioButton Crazy_Eights_RadioHearts;
        private System.Windows.Forms.RadioButton Crazy_Eights_RadioSpades;
        private System.Windows.Forms.RadioButton Crazy_Eights_RadioClubs;
        private System.Windows.Forms.Button button1;
    }
}