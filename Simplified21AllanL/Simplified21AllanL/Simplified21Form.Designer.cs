namespace Simplified21AllanL
{
    partial class frmSimplified21
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHit = new System.Windows.Forms.Button();
            this.lblUserTotal = new System.Windows.Forms.Label();
            this.lblDealTotal = new System.Windows.Forms.Label();
            this.lblUserCards = new System.Windows.Forms.Label();
            this.lblDealCards = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.picUserCard1 = new System.Windows.Forms.PictureBox();
            this.picUserCard3 = new System.Windows.Forms.PictureBox();
            this.picDealCard1 = new System.Windows.Forms.PictureBox();
            this.picDealCard2 = new System.Windows.Forms.PictureBox();
            this.picDealCard3 = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.picUserCard2 = new System.Windows.Forms.PictureBox();
            this.lblNumOfWins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWinCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(607, 591);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(118, 120);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblUserTotal
            // 
            this.lblUserTotal.AutoSize = true;
            this.lblUserTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblUserTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTotal.Location = new System.Drawing.Point(1084, 418);
            this.lblUserTotal.Name = "lblUserTotal";
            this.lblUserTotal.Size = new System.Drawing.Size(0, 18);
            this.lblUserTotal.TabIndex = 1;
            // 
            // lblDealTotal
            // 
            this.lblDealTotal.AutoSize = true;
            this.lblDealTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblDealTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealTotal.Location = new System.Drawing.Point(1140, 111);
            this.lblDealTotal.Name = "lblDealTotal";
            this.lblDealTotal.Size = new System.Drawing.Size(35, 18);
            this.lblDealTotal.TabIndex = 4;
            this.lblDealTotal.Text = "???";
            // 
            // lblUserCards
            // 
            this.lblUserCards.AutoSize = true;
            this.lblUserCards.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCards.Location = new System.Drawing.Point(685, 340);
            this.lblUserCards.Name = "lblUserCards";
            this.lblUserCards.Size = new System.Drawing.Size(93, 18);
            this.lblUserCards.TabIndex = 5;
            this.lblUserCards.Text = "Your Cards";
            // 
            // lblDealCards
            // 
            this.lblDealCards.AutoSize = true;
            this.lblDealCards.BackColor = System.Drawing.Color.Transparent;
            this.lblDealCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealCards.ForeColor = System.Drawing.Color.Black;
            this.lblDealCards.Location = new System.Drawing.Point(685, 198);
            this.lblDealCards.Name = "lblDealCards";
            this.lblDealCards.Size = new System.Drawing.Size(116, 18);
            this.lblDealCards.TabIndex = 6;
            this.lblDealCards.Text = "Dealers Cards";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(693, 262);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 31);
            this.lblWinner.TabIndex = 7;
            // 
            // picUserCard1
            // 
            this.picUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard1.Location = new System.Drawing.Point(565, 361);
            this.picUserCard1.Name = "picUserCard1";
            this.picUserCard1.Size = new System.Drawing.Size(105, 146);
            this.picUserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserCard1.TabIndex = 11;
            this.picUserCard1.TabStop = false;
            this.picUserCard1.Click += new System.EventHandler(this.picUserCard1_Click);
            // 
            // picUserCard3
            // 
            this.picUserCard3.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard3.Location = new System.Drawing.Point(811, 361);
            this.picUserCard3.Name = "picUserCard3";
            this.picUserCard3.Size = new System.Drawing.Size(105, 146);
            this.picUserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserCard3.TabIndex = 12;
            this.picUserCard3.TabStop = false;
            this.picUserCard3.Click += new System.EventHandler(this.picUserCard3_Click);
            // 
            // picDealCard1
            // 
            this.picDealCard1.Image = global::Simplified21AllanL.Properties.Resources.CardBack;
            this.picDealCard1.Location = new System.Drawing.Point(516, 49);
            this.picDealCard1.Name = "picDealCard1";
            this.picDealCard1.Size = new System.Drawing.Size(105, 146);
            this.picDealCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard1.TabIndex = 13;
            this.picDealCard1.TabStop = false;
            this.picDealCard1.Click += new System.EventHandler(this.picdealCard1_Click);
            // 
            // picDealCard2
            // 
            this.picDealCard2.Image = global::Simplified21AllanL.Properties.Resources.CardBack;
            this.picDealCard2.Location = new System.Drawing.Point(687, 49);
            this.picDealCard2.Name = "picDealCard2";
            this.picDealCard2.Size = new System.Drawing.Size(105, 146);
            this.picDealCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard2.TabIndex = 14;
            this.picDealCard2.TabStop = false;
            this.picDealCard2.Click += new System.EventHandler(this.picdealCard2_Click);
            // 
            // picDealCard3
            // 
            this.picDealCard3.Image = global::Simplified21AllanL.Properties.Resources.CardBack;
            this.picDealCard3.Location = new System.Drawing.Point(857, 49);
            this.picDealCard3.Name = "picDealCard3";
            this.picDealCard3.Size = new System.Drawing.Size(105, 146);
            this.picDealCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealCard3.TabIndex = 15;
            this.picDealCard3.TabStop = false;
            this.picDealCard3.Click += new System.EventHandler(this.picdealCard3_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(1257, 591);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(118, 120);
            this.btnPlayAgain.TabIndex = 16;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(731, 591);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(118, 120);
            this.btnStay.TabIndex = 17;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // picUserCard2
            // 
            this.picUserCard2.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard2.Location = new System.Drawing.Point(687, 361);
            this.picUserCard2.Name = "picUserCard2";
            this.picUserCard2.Size = new System.Drawing.Size(105, 146);
            this.picUserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserCard2.TabIndex = 18;
            this.picUserCard2.TabStop = false;
            // 
            // lblNumOfWins
            // 
            this.lblNumOfWins.AutoSize = true;
            this.lblNumOfWins.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfWins.Location = new System.Drawing.Point(216, 115);
            this.lblNumOfWins.Name = "lblNumOfWins";
            this.lblNumOfWins.Size = new System.Drawing.Size(17, 18);
            this.lblNumOfWins.TabIndex = 19;
            this.lblNumOfWins.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(935, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your Card Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(984, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dealers Card Total";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(132, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblWinCounter
            // 
            this.lblWinCounter.AutoSize = true;
            this.lblWinCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblWinCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinCounter.Location = new System.Drawing.Point(93, 115);
            this.lblWinCounter.Name = "lblWinCounter";
            this.lblWinCounter.Size = new System.Drawing.Size(113, 20);
            this.lblWinCounter.TabIndex = 23;
            this.lblWinCounter.Text = "Win Counter:";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simplified21AllanL.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 746);
            this.Controls.Add(this.lblWinCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumOfWins);
            this.Controls.Add(this.picUserCard2);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.picDealCard3);
            this.Controls.Add(this.picDealCard2);
            this.Controls.Add(this.picDealCard1);
            this.Controls.Add(this.picUserCard3);
            this.Controls.Add(this.picUserCard1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblDealCards);
            this.Controls.Add(this.lblUserCards);
            this.Controls.Add(this.lblDealTotal);
            this.Controls.Add(this.lblUserTotal);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Allan L";
            this.Load += new System.EventHandler(this.frmSimplified21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblUserTotal;
        private System.Windows.Forms.Label lblDealTotal;
        private System.Windows.Forms.Label lblUserCards;
        private System.Windows.Forms.Label lblDealCards;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox picUserCard1;
        private System.Windows.Forms.PictureBox picUserCard3;
        private System.Windows.Forms.PictureBox picDealCard1;
        private System.Windows.Forms.PictureBox picDealCard2;
        private System.Windows.Forms.PictureBox picDealCard3;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.PictureBox picUserCard2;
        private System.Windows.Forms.Label lblNumOfWins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblWinCounter;
    }
}

