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
            this.diamondRadioButton = new System.Windows.Forms.RadioButton();
            this.heartsRadioButton = new System.Windows.Forms.RadioButton();
            this.spadesRadioButton = new System.Windows.Forms.RadioButton();
            this.clubsRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diamondRadioButton);
            this.groupBox1.Controls.Add(this.heartsRadioButton);
            this.groupBox1.Controls.Add(this.spadesRadioButton);
            this.groupBox1.Controls.Add(this.clubsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose A Suit";
            // 
            // diamondRadioButton
            // 
            this.diamondRadioButton.AutoSize = true;
            this.diamondRadioButton.Location = new System.Drawing.Point(30, 132);
            this.diamondRadioButton.Name = "diamondRadioButton";
            this.diamondRadioButton.Size = new System.Drawing.Size(67, 17);
            this.diamondRadioButton.TabIndex = 3;
            this.diamondRadioButton.TabStop = true;
            this.diamondRadioButton.Text = "Diamond";
            this.diamondRadioButton.UseVisualStyleBackColor = true;
            // 
            // heartsRadioButton
            // 
            this.heartsRadioButton.AutoSize = true;
            this.heartsRadioButton.Location = new System.Drawing.Point(30, 100);
            this.heartsRadioButton.Name = "heartsRadioButton";
            this.heartsRadioButton.Size = new System.Drawing.Size(56, 17);
            this.heartsRadioButton.TabIndex = 2;
            this.heartsRadioButton.TabStop = true;
            this.heartsRadioButton.Text = "Hearts";
            this.heartsRadioButton.UseVisualStyleBackColor = true;
            // 
            // spadesRadioButton
            // 
            this.spadesRadioButton.AutoSize = true;
            this.spadesRadioButton.Location = new System.Drawing.Point(30, 66);
            this.spadesRadioButton.Name = "spadesRadioButton";
            this.spadesRadioButton.Size = new System.Drawing.Size(61, 17);
            this.spadesRadioButton.TabIndex = 1;
            this.spadesRadioButton.TabStop = true;
            this.spadesRadioButton.Text = "Spades";
            this.spadesRadioButton.UseVisualStyleBackColor = true;
            // 
            // clubsRadioButton
            // 
            this.clubsRadioButton.AutoSize = true;
            this.clubsRadioButton.Location = new System.Drawing.Point(30, 33);
            this.clubsRadioButton.Name = "clubsRadioButton";
            this.clubsRadioButton.Size = new System.Drawing.Size(51, 17);
            this.clubsRadioButton.TabIndex = 0;
            this.clubsRadioButton.TabStop = true;
            this.clubsRadioButton.Text = "Clubs";
            this.clubsRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.RadioButton diamondRadioButton;
        private System.Windows.Forms.RadioButton heartsRadioButton;
        private System.Windows.Forms.RadioButton spadesRadioButton;
        private System.Windows.Forms.RadioButton clubsRadioButton;
        private System.Windows.Forms.Button button1;
    }
}