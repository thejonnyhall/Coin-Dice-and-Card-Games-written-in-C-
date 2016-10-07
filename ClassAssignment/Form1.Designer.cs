namespace ClassAssignment {
    partial class Form1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameGroupBox = new System.Windows.Forms.GroupBox();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.diceRadioButton = new System.Windows.Forms.RadioButton();
            this.coinRadioButton = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.GameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GameCentre";
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Controls.Add(this.cardRadioButton);
            this.GameGroupBox.Controls.Add(this.diceRadioButton);
            this.GameGroupBox.Controls.Add(this.coinRadioButton);
            this.GameGroupBox.Location = new System.Drawing.Point(88, 126);
            this.GameGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.GameGroupBox.Size = new System.Drawing.Size(204, 190);
            this.GameGroupBox.TabIndex = 1;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Select Game Type";
            this.GameGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(44, 134);
            this.cardRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(101, 21);
            this.cardRadioButton.TabIndex = 2;
            this.cardRadioButton.Text = "Card Game";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.cardRadioButton_CheckedChanged);
            // 
            // diceRadioButton
            // 
            this.diceRadioButton.AutoSize = true;
            this.diceRadioButton.Location = new System.Drawing.Point(44, 85);
            this.diceRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.diceRadioButton.Name = "diceRadioButton";
            this.diceRadioButton.Size = new System.Drawing.Size(99, 21);
            this.diceRadioButton.TabIndex = 1;
            this.diceRadioButton.Text = "Dice Game";
            this.diceRadioButton.UseVisualStyleBackColor = true;
            this.diceRadioButton.CheckedChanged += new System.EventHandler(this.diceRadioButton_CheckedChanged);
            // 
            // coinRadioButton
            // 
            this.coinRadioButton.AutoSize = true;
            this.coinRadioButton.Location = new System.Drawing.Point(44, 39);
            this.coinRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.coinRadioButton.Name = "coinRadioButton";
            this.coinRadioButton.Size = new System.Drawing.Size(99, 21);
            this.coinRadioButton.TabIndex = 0;
            this.coinRadioButton.Text = "Coin Game";
            this.coinRadioButton.UseVisualStyleBackColor = true;
            this.coinRadioButton.CheckedChanged += new System.EventHandler(this.coinRadioButton_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(116, 342);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 27);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(116, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 495);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Games";
            this.GameGroupBox.ResumeLayout(false);
            this.GameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton diceRadioButton;
        private System.Windows.Forms.RadioButton coinRadioButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button exitButton;
    }
}

