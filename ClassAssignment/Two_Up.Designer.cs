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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.gameWonLabel = new System.Windows.Forms.Label();
            this.coinThrowButton = new System.Windows.Forms.Button();
            this.replayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(235, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player\'s Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computer\'s Score";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.BackColor = System.Drawing.Color.White;
            this.computerScoreLabel.Location = new System.Drawing.Point(328, 220);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.computerScoreLabel.TabIndex = 4;
            this.computerScoreLabel.Text = "0";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.Color.White;
            this.playerScoreLabel.Location = new System.Drawing.Point(123, 220);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.playerScoreLabel.TabIndex = 5;
            this.playerScoreLabel.Text = "0";
            // 
            // gameWonLabel
            // 
            this.gameWonLabel.AutoSize = true;
            this.gameWonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameWonLabel.Location = new System.Drawing.Point(402, 114);
            this.gameWonLabel.Name = "gameWonLabel";
            this.gameWonLabel.Size = new System.Drawing.Size(66, 24);
            this.gameWonLabel.TabIndex = 6;
            this.gameWonLabel.Text = "label3";
            this.gameWonLabel.Visible = false;
            // 
            // coinThrowButton
            // 
            this.coinThrowButton.Location = new System.Drawing.Point(50, 265);
            this.coinThrowButton.Name = "coinThrowButton";
            this.coinThrowButton.Size = new System.Drawing.Size(75, 23);
            this.coinThrowButton.TabIndex = 7;
            this.coinThrowButton.Text = "Throw Coins";
            this.coinThrowButton.UseVisualStyleBackColor = true;
            this.coinThrowButton.Click += new System.EventHandler(this.coinThrowButton_Click);
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(183, 265);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(75, 23);
            this.replayButton.TabIndex = 8;
            this.replayButton.Text = "Play Again";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(310, 265);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 345);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.coinThrowButton);
            this.Controls.Add(this.gameWonLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Two_Up_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label gameWonLabel;
        private System.Windows.Forms.Button coinThrowButton;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button cancelButton;
    }
}