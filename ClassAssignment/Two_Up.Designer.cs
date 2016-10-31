namespace ClassAssignment {
    partial class Two_Up {
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
            this.components = new System.ComponentModel.Container();
            this.TwoUpCoinBox2 = new System.Windows.Forms.PictureBox();
            this.TwoUpCoinBox1 = new System.Windows.Forms.PictureBox();
            this.TwoUpThrowCoinButton = new System.Windows.Forms.Button();
            this.TwoUpPlayAgainButton = new System.Windows.Forms.Button();
            this.TwoUpCancelGameButton = new System.Windows.Forms.Button();
            this.TwoUpPlayerScoreLabel = new System.Windows.Forms.Label();
            this.TwoUpComputerScoreLabel = new System.Windows.Forms.Label();
            this.TwoUpPlayerScoreNumber = new System.Windows.Forms.Label();
            this.TwoUpComputerScoreNumber = new System.Windows.Forms.Label();
            this.TwoUpOutcomeLabel = new System.Windows.Forms.Label();
            this.TwoUpTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TwoUpCoinBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoUpCoinBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TwoUpCoinBox2
            // 
            this.TwoUpCoinBox2.Location = new System.Drawing.Point(326, 27);
            this.TwoUpCoinBox2.Name = "Two_Up_CoinBox_2";
            this.TwoUpCoinBox2.Size = new System.Drawing.Size(150, 150);
            this.TwoUpCoinBox2.TabIndex = 0;
            this.TwoUpCoinBox2.TabStop = false;
            // 
            // TwoUpCoinBox1
            // 
            this.TwoUpCoinBox1.Location = new System.Drawing.Point(36, 27);
            this.TwoUpCoinBox1.Name = "Two_Up_CoinBox_1";
            this.TwoUpCoinBox1.Size = new System.Drawing.Size(150, 150);
            this.TwoUpCoinBox1.TabIndex = 1;
            this.TwoUpCoinBox1.TabStop = false;
            // 
            // TwoUpThrowCoinButton
            // 
            this.TwoUpThrowCoinButton.Location = new System.Drawing.Point(36, 281);
            this.TwoUpThrowCoinButton.Name = "Two_Up_ThrowCoin_Button";
            this.TwoUpThrowCoinButton.Size = new System.Drawing.Size(86, 36);
            this.TwoUpThrowCoinButton.TabIndex = 2;
            this.TwoUpThrowCoinButton.Text = "Throw Coin";
            this.TwoUpThrowCoinButton.UseVisualStyleBackColor = true;
            this.TwoUpThrowCoinButton.Click += new System.EventHandler(this.Two_Up_ThrowCoin_Button_Click);
            // 
            // TwoUpPlayAgainButton
            // 
            this.TwoUpPlayAgainButton.Location = new System.Drawing.Point(211, 281);
            this.TwoUpPlayAgainButton.Name = "Two_Up_PlayAgain_Button";
            this.TwoUpPlayAgainButton.Size = new System.Drawing.Size(87, 36);
            this.TwoUpPlayAgainButton.TabIndex = 3;
            this.TwoUpPlayAgainButton.Text = "Play Again";
            this.TwoUpPlayAgainButton.UseVisualStyleBackColor = true;
            this.TwoUpPlayAgainButton.Visible = false;
            this.TwoUpPlayAgainButton.Click += new System.EventHandler(this.Two_Up_PlayAgain_Button_Click);
            // 
            // TwoUpCancelGameButton
            // 
            this.TwoUpCancelGameButton.Location = new System.Drawing.Point(387, 281);
            this.TwoUpCancelGameButton.Name = "Two_Up_CancelGame_Button";
            this.TwoUpCancelGameButton.Size = new System.Drawing.Size(89, 36);
            this.TwoUpCancelGameButton.TabIndex = 4;
            this.TwoUpCancelGameButton.Text = "Cancel Game";
            this.TwoUpCancelGameButton.UseVisualStyleBackColor = true;
            this.TwoUpCancelGameButton.Click += new System.EventHandler(this.Two_Up_CancelGame_Button_Click);
            // 
            // TwoUpPlayerScoreLabel
            // 
            this.TwoUpPlayerScoreLabel.AutoSize = true;
            this.TwoUpPlayerScoreLabel.Location = new System.Drawing.Point(33, 220);
            this.TwoUpPlayerScoreLabel.Name = "Two_Up_PlayerScore_Label";
            this.TwoUpPlayerScoreLabel.Size = new System.Drawing.Size(72, 13);
            this.TwoUpPlayerScoreLabel.TabIndex = 6;
            this.TwoUpPlayerScoreLabel.Text = "Players Score";
            // 
            // TwoUpComputerScoreLabel
            // 
            this.TwoUpComputerScoreLabel.AutoSize = true;
            this.TwoUpComputerScoreLabel.Location = new System.Drawing.Point(367, 220);
            this.TwoUpComputerScoreLabel.Name = "Two_Up_ComputerScore_Label";
            this.TwoUpComputerScoreLabel.Size = new System.Drawing.Size(90, 13);
            this.TwoUpComputerScoreLabel.TabIndex = 7;
            this.TwoUpComputerScoreLabel.Text = "Computer\'s Score";
            // 
            // TwoUpPlayerScoreNumber
            // 
            this.TwoUpPlayerScoreNumber.AutoSize = true;
            this.TwoUpPlayerScoreNumber.BackColor = System.Drawing.Color.White;
            this.TwoUpPlayerScoreNumber.Location = new System.Drawing.Point(104, 220);
            this.TwoUpPlayerScoreNumber.Name = "Two_Up_PlayerScore_Number";
            this.TwoUpPlayerScoreNumber.Size = new System.Drawing.Size(13, 13);
            this.TwoUpPlayerScoreNumber.TabIndex = 8;
            this.TwoUpPlayerScoreNumber.Text = "0";
            // 
            // TwoUpComputerScoreNumber
            // 
            this.TwoUpComputerScoreNumber.AutoSize = true;
            this.TwoUpComputerScoreNumber.BackColor = System.Drawing.Color.White;
            this.TwoUpComputerScoreNumber.Location = new System.Drawing.Point(463, 220);
            this.TwoUpComputerScoreNumber.Name = "Two_Up_ComputerScore_Number";
            this.TwoUpComputerScoreNumber.Size = new System.Drawing.Size(13, 13);
            this.TwoUpComputerScoreNumber.TabIndex = 9;
            this.TwoUpComputerScoreNumber.Text = "0";
            // 
            // TwoUpOutcomeLabel
            // 
            this.TwoUpOutcomeLabel.AutoSize = true;
            this.TwoUpOutcomeLabel.Location = new System.Drawing.Point(234, 103);
            this.TwoUpOutcomeLabel.Name = "Two_Up_Outcome_Label";
            this.TwoUpOutcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.TwoUpOutcomeLabel.TabIndex = 5;
            this.TwoUpOutcomeLabel.Text = "label1";
            this.TwoUpOutcomeLabel.Visible = false;
            // 
            // TwoUpTimer
            // 
            this.TwoUpTimer.Tick += new System.EventHandler(this.Two_Up_Timer_Tick);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 346);
            this.Controls.Add(this.TwoUpComputerScoreNumber);
            this.Controls.Add(this.TwoUpPlayerScoreNumber);
            this.Controls.Add(this.TwoUpComputerScoreLabel);
            this.Controls.Add(this.TwoUpPlayerScoreLabel);
            this.Controls.Add(this.TwoUpOutcomeLabel);
            this.Controls.Add(this.TwoUpCancelGameButton);
            this.Controls.Add(this.TwoUpPlayAgainButton);
            this.Controls.Add(this.TwoUpThrowCoinButton);
            this.Controls.Add(this.TwoUpCoinBox1);
            this.Controls.Add(this.TwoUpCoinBox2);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            ((System.ComponentModel.ISupportInitialize)(this.TwoUpCoinBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoUpCoinBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TwoUpCoinBox2;
        private System.Windows.Forms.PictureBox TwoUpCoinBox1;
        private System.Windows.Forms.Button TwoUpThrowCoinButton;
        private System.Windows.Forms.Button TwoUpPlayAgainButton;
        private System.Windows.Forms.Button TwoUpCancelGameButton;
        private System.Windows.Forms.Label TwoUpPlayerScoreLabel;
        private System.Windows.Forms.Label TwoUpComputerScoreLabel;
        private System.Windows.Forms.Label TwoUpPlayerScoreNumber;
        private System.Windows.Forms.Label TwoUpComputerScoreNumber;
        private System.Windows.Forms.Label TwoUpOutcomeLabel;
        private System.Windows.Forms.Timer TwoUpTimer;
    }
}