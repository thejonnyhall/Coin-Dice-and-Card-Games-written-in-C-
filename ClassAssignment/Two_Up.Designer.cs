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
            this.Two_Up_CoinBox_2 = new System.Windows.Forms.PictureBox();
            this.Two_Up_CoinBox_1 = new System.Windows.Forms.PictureBox();
            this.Two_Up_ThrowCoin_Button = new System.Windows.Forms.Button();
            this.Two_Up_PlayAgain_Button = new System.Windows.Forms.Button();
            this.Two_Up_CancelGame_Button = new System.Windows.Forms.Button();
            this.Two_Up_PlayerScore_Label = new System.Windows.Forms.Label();
            this.Two_Up_ComputerScore_Label = new System.Windows.Forms.Label();
            this.Two_Up_PlayerScore_Number = new System.Windows.Forms.Label();
            this.Two_Up_ComputerScore_Number = new System.Windows.Forms.Label();
            this.Two_Up_Outcome_Label = new System.Windows.Forms.Label();
            this.Two_Up_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Two_Up_CoinBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Two_Up_CoinBox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Two_Up_CoinBox_2
            // 
            this.Two_Up_CoinBox_2.Location = new System.Drawing.Point(326, 27);
            this.Two_Up_CoinBox_2.Name = "Two_Up_CoinBox_2";
            this.Two_Up_CoinBox_2.Size = new System.Drawing.Size(150, 150);
            this.Two_Up_CoinBox_2.TabIndex = 0;
            this.Two_Up_CoinBox_2.TabStop = false;
            // 
            // Two_Up_CoinBox_1
            // 
            this.Two_Up_CoinBox_1.Location = new System.Drawing.Point(36, 27);
            this.Two_Up_CoinBox_1.Name = "Two_Up_CoinBox_1";
            this.Two_Up_CoinBox_1.Size = new System.Drawing.Size(150, 150);
            this.Two_Up_CoinBox_1.TabIndex = 1;
            this.Two_Up_CoinBox_1.TabStop = false;
            // 
            // Two_Up_ThrowCoin_Button
            // 
            this.Two_Up_ThrowCoin_Button.Location = new System.Drawing.Point(36, 281);
            this.Two_Up_ThrowCoin_Button.Name = "Two_Up_ThrowCoin_Button";
            this.Two_Up_ThrowCoin_Button.Size = new System.Drawing.Size(86, 36);
            this.Two_Up_ThrowCoin_Button.TabIndex = 2;
            this.Two_Up_ThrowCoin_Button.Text = "Throw Coin";
            this.Two_Up_ThrowCoin_Button.UseVisualStyleBackColor = true;
            this.Two_Up_ThrowCoin_Button.Click += new System.EventHandler(this.Two_Up_ThrowCoin_Button_Click);
            // 
            // Two_Up_PlayAgain_Button
            // 
            this.Two_Up_PlayAgain_Button.Location = new System.Drawing.Point(211, 281);
            this.Two_Up_PlayAgain_Button.Name = "Two_Up_PlayAgain_Button";
            this.Two_Up_PlayAgain_Button.Size = new System.Drawing.Size(87, 36);
            this.Two_Up_PlayAgain_Button.TabIndex = 3;
            this.Two_Up_PlayAgain_Button.Text = "Play Again";
            this.Two_Up_PlayAgain_Button.UseVisualStyleBackColor = true;
            this.Two_Up_PlayAgain_Button.Visible = false;
            this.Two_Up_PlayAgain_Button.Click += new System.EventHandler(this.Two_Up_PlayAgain_Button_Click);
            // 
            // Two_Up_CancelGame_Button
            // 
            this.Two_Up_CancelGame_Button.Location = new System.Drawing.Point(387, 281);
            this.Two_Up_CancelGame_Button.Name = "Two_Up_CancelGame_Button";
            this.Two_Up_CancelGame_Button.Size = new System.Drawing.Size(89, 36);
            this.Two_Up_CancelGame_Button.TabIndex = 4;
            this.Two_Up_CancelGame_Button.Text = "Cancel Game";
            this.Two_Up_CancelGame_Button.UseVisualStyleBackColor = true;
            this.Two_Up_CancelGame_Button.Click += new System.EventHandler(this.Two_Up_CancelGame_Button_Click);
            // 
            // Two_Up_PlayerScore_Label
            // 
            this.Two_Up_PlayerScore_Label.AutoSize = true;
            this.Two_Up_PlayerScore_Label.Location = new System.Drawing.Point(33, 220);
            this.Two_Up_PlayerScore_Label.Name = "Two_Up_PlayerScore_Label";
            this.Two_Up_PlayerScore_Label.Size = new System.Drawing.Size(72, 13);
            this.Two_Up_PlayerScore_Label.TabIndex = 6;
            this.Two_Up_PlayerScore_Label.Text = "Players Score";
            // 
            // Two_Up_ComputerScore_Label
            // 
            this.Two_Up_ComputerScore_Label.AutoSize = true;
            this.Two_Up_ComputerScore_Label.Location = new System.Drawing.Point(367, 220);
            this.Two_Up_ComputerScore_Label.Name = "Two_Up_ComputerScore_Label";
            this.Two_Up_ComputerScore_Label.Size = new System.Drawing.Size(90, 13);
            this.Two_Up_ComputerScore_Label.TabIndex = 7;
            this.Two_Up_ComputerScore_Label.Text = "Computer\'s Score";
            // 
            // Two_Up_PlayerScore_Number
            // 
            this.Two_Up_PlayerScore_Number.AutoSize = true;
            this.Two_Up_PlayerScore_Number.BackColor = System.Drawing.Color.White;
            this.Two_Up_PlayerScore_Number.Location = new System.Drawing.Point(104, 220);
            this.Two_Up_PlayerScore_Number.Name = "Two_Up_PlayerScore_Number";
            this.Two_Up_PlayerScore_Number.Size = new System.Drawing.Size(13, 13);
            this.Two_Up_PlayerScore_Number.TabIndex = 8;
            this.Two_Up_PlayerScore_Number.Text = "0";
            // 
            // Two_Up_ComputerScore_Number
            // 
            this.Two_Up_ComputerScore_Number.AutoSize = true;
            this.Two_Up_ComputerScore_Number.BackColor = System.Drawing.Color.White;
            this.Two_Up_ComputerScore_Number.Location = new System.Drawing.Point(463, 220);
            this.Two_Up_ComputerScore_Number.Name = "Two_Up_ComputerScore_Number";
            this.Two_Up_ComputerScore_Number.Size = new System.Drawing.Size(13, 13);
            this.Two_Up_ComputerScore_Number.TabIndex = 9;
            this.Two_Up_ComputerScore_Number.Text = "0";
            // 
            // Two_Up_Outcome_Label
            // 
            this.Two_Up_Outcome_Label.AutoSize = true;
            this.Two_Up_Outcome_Label.Location = new System.Drawing.Point(234, 103);
            this.Two_Up_Outcome_Label.Name = "Two_Up_Outcome_Label";
            this.Two_Up_Outcome_Label.Size = new System.Drawing.Size(35, 13);
            this.Two_Up_Outcome_Label.TabIndex = 5;
            this.Two_Up_Outcome_Label.Text = "label1";
            this.Two_Up_Outcome_Label.Visible = false;
            // 
            // Two_Up_Timer
            // 
            this.Two_Up_Timer.Tick += new System.EventHandler(this.Two_Up_Timer_Tick);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 346);
            this.Controls.Add(this.Two_Up_ComputerScore_Number);
            this.Controls.Add(this.Two_Up_PlayerScore_Number);
            this.Controls.Add(this.Two_Up_ComputerScore_Label);
            this.Controls.Add(this.Two_Up_PlayerScore_Label);
            this.Controls.Add(this.Two_Up_Outcome_Label);
            this.Controls.Add(this.Two_Up_CancelGame_Button);
            this.Controls.Add(this.Two_Up_PlayAgain_Button);
            this.Controls.Add(this.Two_Up_ThrowCoin_Button);
            this.Controls.Add(this.Two_Up_CoinBox_1);
            this.Controls.Add(this.Two_Up_CoinBox_2);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            ((System.ComponentModel.ISupportInitialize)(this.Two_Up_CoinBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Two_Up_CoinBox_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Two_Up_CoinBox_2;
        private System.Windows.Forms.PictureBox Two_Up_CoinBox_1;
        private System.Windows.Forms.Button Two_Up_ThrowCoin_Button;
        private System.Windows.Forms.Button Two_Up_PlayAgain_Button;
        private System.Windows.Forms.Button Two_Up_CancelGame_Button;
        private System.Windows.Forms.Label Two_Up_PlayerScore_Label;
        private System.Windows.Forms.Label Two_Up_ComputerScore_Label;
        private System.Windows.Forms.Label Two_Up_PlayerScore_Number;
        private System.Windows.Forms.Label Two_Up_ComputerScore_Number;
        private System.Windows.Forms.Label Two_Up_Outcome_Label;
        private System.Windows.Forms.Timer Two_Up_Timer;
    }
}