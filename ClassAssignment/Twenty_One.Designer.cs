namespace ClassAssignment {
    partial class Twenty_One {
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
            this.dealerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.dealerPointsLabel = new System.Windows.Forms.Label();
            this.dealerGamesWonLabel = new System.Windows.Forms.Label();
            this.dealerGamesWon = new System.Windows.Forms.Label();
            this.playerGamesWon = new System.Windows.Forms.Label();
            this.playerGamesWonLabel = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.playerAces = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerTableLayoutPanel
            // 
            this.dealerTableLayoutPanel.ColumnCount = 8;
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.Location = new System.Drawing.Point(14, 70);
            this.dealerTableLayoutPanel.Name = "dealerTableLayoutPanel";
            this.dealerTableLayoutPanel.RowCount = 1;
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.dealerTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.dealerTableLayoutPanel.TabIndex = 0;
            // 
            // playerTableLayoutPanel
            // 
            this.playerTableLayoutPanel.ColumnCount = 8;
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.Location = new System.Drawing.Point(14, 199);
            this.playerTableLayoutPanel.Name = "playerTableLayoutPanel";
            this.playerTableLayoutPanel.RowCount = 1;
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.playerTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.playerTableLayoutPanel.TabIndex = 1;
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(153, 19);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.dealerBustedLabel.TabIndex = 2;
            this.dealerBustedLabel.Text = "BUSTED";
            this.dealerBustedLabel.Visible = false;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.Location = new System.Drawing.Point(256, 19);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(81, 25);
            this.dealerLabel.TabIndex = 3;
            this.dealerLabel.Text = "Dealer";
            // 
            // dealerPointsLabel
            // 
            this.dealerPointsLabel.AutoSize = true;
            this.dealerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerPointsLabel.Location = new System.Drawing.Point(353, 22);
            this.dealerPointsLabel.Name = "dealerPointsLabel";
            this.dealerPointsLabel.Size = new System.Drawing.Size(67, 20);
            this.dealerPointsLabel.TabIndex = 4;
            this.dealerPointsLabel.Text = "POINTS";
            // 
            // dealerGamesWonLabel
            // 
            this.dealerGamesWonLabel.AutoSize = true;
            this.dealerGamesWonLabel.Location = new System.Drawing.Point(459, 27);
            this.dealerGamesWonLabel.Name = "dealerGamesWonLabel";
            this.dealerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.dealerGamesWonLabel.TabIndex = 5;
            this.dealerGamesWonLabel.Text = "Games won";
            // 
            // dealerGamesWon
            // 
            this.dealerGamesWon.AutoSize = true;
            this.dealerGamesWon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dealerGamesWon.Location = new System.Drawing.Point(528, 27);
            this.dealerGamesWon.Name = "dealerGamesWon";
            this.dealerGamesWon.Size = new System.Drawing.Size(13, 13);
            this.dealerGamesWon.TabIndex = 6;
            this.dealerGamesWon.Text = "0";
            // 
            // playerGamesWon
            // 
            this.playerGamesWon.AutoSize = true;
            this.playerGamesWon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerGamesWon.Location = new System.Drawing.Point(528, 325);
            this.playerGamesWon.Name = "playerGamesWon";
            this.playerGamesWon.Size = new System.Drawing.Size(13, 13);
            this.playerGamesWon.TabIndex = 11;
            this.playerGamesWon.Text = "0";
            // 
            // playerGamesWonLabel
            // 
            this.playerGamesWonLabel.AutoSize = true;
            this.playerGamesWonLabel.Location = new System.Drawing.Point(459, 325);
            this.playerGamesWonLabel.Name = "playerGamesWonLabel";
            this.playerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.playerGamesWonLabel.TabIndex = 10;
            this.playerGamesWonLabel.Text = "Games won";
            // 
            // playerPointsLabel
            // 
            this.playerPointsLabel.AutoSize = true;
            this.playerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPointsLabel.Location = new System.Drawing.Point(353, 320);
            this.playerPointsLabel.Name = "playerPointsLabel";
            this.playerPointsLabel.Size = new System.Drawing.Size(67, 20);
            this.playerPointsLabel.TabIndex = 9;
            this.playerPointsLabel.Text = "POINTS";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(258, 317);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(79, 25);
            this.playerLabel.TabIndex = 8;
            this.playerLabel.Text = "Player";
            // 
            // playerBustedLabel
            // 
            this.playerBustedLabel.AutoSize = true;
            this.playerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerBustedLabel.Location = new System.Drawing.Point(153, 317);
            this.playerBustedLabel.Name = "playerBustedLabel";
            this.playerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.playerBustedLabel.TabIndex = 7;
            this.playerBustedLabel.Text = "BUSTED";
            this.playerBustedLabel.Visible = false;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(60, 376);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 12;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(187, 376);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 13;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(317, 376);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 14;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(442, 376);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // playerAces
            // 
            this.playerAces.AutoSize = true;
            this.playerAces.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerAces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAces.Location = new System.Drawing.Point(258, 348);
            this.playerAces.Name = "playerAces";
            this.playerAces.Size = new System.Drawing.Size(16, 18);
            this.playerAces.TabIndex = 17;
            this.playerAces.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Aces with value 1";
            // 
            // Twenty_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerAces);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.playerGamesWon);
            this.Controls.Add(this.playerGamesWonLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.dealerGamesWon);
            this.Controls.Add(this.dealerGamesWonLabel);
            this.Controls.Add(this.dealerPointsLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.playerTableLayoutPanel);
            this.Controls.Add(this.dealerTableLayoutPanel);
            this.Name = "Twenty_One";
            this.Text = "Twenty One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dealerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel playerTableLayoutPanel;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label dealerPointsLabel;
        private System.Windows.Forms.Label dealerGamesWonLabel;
        private System.Windows.Forms.Label dealerGamesWon;
        private System.Windows.Forms.Label playerGamesWon;
        private System.Windows.Forms.Label playerGamesWonLabel;
        private System.Windows.Forms.Label playerPointsLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label playerAces;
        private System.Windows.Forms.Label label2;
    }
}