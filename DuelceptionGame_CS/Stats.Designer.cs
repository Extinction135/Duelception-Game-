namespace WindowsFormsApp3
{
    partial class Stats
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
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.lbl_Txt_TotalRoundsPlayed = new System.Windows.Forms.Label();
            this.lbl_Txt_HighestRounds = new System.Windows.Forms.Label();
            this.lbl_HighRound = new System.Windows.Forms.Label();
            this.lbl_Stats = new System.Windows.Forms.Label();
            this.lbl_TotalRounds = new System.Windows.Forms.Label();
            this.lbl_Txt_TotalWins = new System.Windows.Forms.Label();
            this.lbl_Wins = new System.Windows.Forms.Label();
            this.groupBox_TotalRoundsPlayed = new System.Windows.Forms.GroupBox();
            this.groupBox_TotalWins = new System.Windows.Forms.GroupBox();
            this.groupBox_HighestRounds = new System.Windows.Forms.GroupBox();
            this.groupBox_TotalGamesPlayed = new System.Windows.Forms.GroupBox();
            this.lbl_GamesPlayed = new System.Windows.Forms.Label();
            this.lbl_Txt_TotalGamesPlayed = new System.Windows.Forms.Label();
            this.groupBox_WinPercentage = new System.Windows.Forms.GroupBox();
            this.lbl_WinPercent = new System.Windows.Forms.Label();
            this.lbl_TxtWinPercentage = new System.Windows.Forms.Label();
            this.groupBox_TotalRoundsPlayed.SuspendLayout();
            this.groupBox_TotalWins.SuspendLayout();
            this.groupBox_HighestRounds.SuspendLayout();
            this.groupBox_TotalGamesPlayed.SuspendLayout();
            this.groupBox_WinPercentage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_MainMenu.Location = new System.Drawing.Point(279, 440);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(258, 38);
            this.btn_MainMenu.TabIndex = 0;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // lbl_Txt_TotalRoundsPlayed
            // 
            this.lbl_Txt_TotalRoundsPlayed.AutoSize = true;
            this.lbl_Txt_TotalRoundsPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Txt_TotalRoundsPlayed.Location = new System.Drawing.Point(37, 11);
            this.lbl_Txt_TotalRoundsPlayed.Name = "lbl_Txt_TotalRoundsPlayed";
            this.lbl_Txt_TotalRoundsPlayed.Size = new System.Drawing.Size(154, 16);
            this.lbl_Txt_TotalRoundsPlayed.TabIndex = 1;
            this.lbl_Txt_TotalRoundsPlayed.Text = "Total Rounds Played\r\n";
            // 
            // lbl_Txt_HighestRounds
            // 
            this.lbl_Txt_HighestRounds.AutoSize = true;
            this.lbl_Txt_HighestRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Txt_HighestRounds.ForeColor = System.Drawing.Color.Black;
            this.lbl_Txt_HighestRounds.Location = new System.Drawing.Point(16, 10);
            this.lbl_Txt_HighestRounds.Name = "lbl_Txt_HighestRounds";
            this.lbl_Txt_HighestRounds.Size = new System.Drawing.Size(185, 48);
            this.lbl_Txt_HighestRounds.TabIndex = 2;
            this.lbl_Txt_HighestRounds.Text = "Highest Rounds Reached\r\n\r\n\r\n";
            // 
            // lbl_HighRound
            // 
            this.lbl_HighRound.AutoSize = true;
            this.lbl_HighRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HighRound.ForeColor = System.Drawing.Color.Navy;
            this.lbl_HighRound.Location = new System.Drawing.Point(6, 25);
            this.lbl_HighRound.Name = "lbl_HighRound";
            this.lbl_HighRound.Size = new System.Drawing.Size(99, 108);
            this.lbl_HighRound.TabIndex = 4;
            this.lbl_HighRound.Text = "0";
            // 
            // lbl_Stats
            // 
            this.lbl_Stats.AutoSize = true;
            this.lbl_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stats.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Stats.Location = new System.Drawing.Point(231, 9);
            this.lbl_Stats.Name = "lbl_Stats";
            this.lbl_Stats.Size = new System.Drawing.Size(360, 108);
            this.lbl_Stats.TabIndex = 5;
            this.lbl_Stats.Text = "STATS";
            // 
            // lbl_TotalRounds
            // 
            this.lbl_TotalRounds.AutoSize = true;
            this.lbl_TotalRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalRounds.ForeColor = System.Drawing.Color.Navy;
            this.lbl_TotalRounds.Location = new System.Drawing.Point(22, 26);
            this.lbl_TotalRounds.Name = "lbl_TotalRounds";
            this.lbl_TotalRounds.Size = new System.Drawing.Size(99, 108);
            this.lbl_TotalRounds.TabIndex = 6;
            this.lbl_TotalRounds.Text = "0";
            // 
            // lbl_Txt_TotalWins
            // 
            this.lbl_Txt_TotalWins.AutoSize = true;
            this.lbl_Txt_TotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Txt_TotalWins.Location = new System.Drawing.Point(24, 10);
            this.lbl_Txt_TotalWins.Name = "lbl_Txt_TotalWins";
            this.lbl_Txt_TotalWins.Size = new System.Drawing.Size(82, 16);
            this.lbl_Txt_TotalWins.TabIndex = 7;
            this.lbl_Txt_TotalWins.Text = "Total Wins";
            // 
            // lbl_Wins
            // 
            this.lbl_Wins.AutoSize = true;
            this.lbl_Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wins.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Wins.Location = new System.Drawing.Point(9, 25);
            this.lbl_Wins.Name = "lbl_Wins";
            this.lbl_Wins.Size = new System.Drawing.Size(99, 108);
            this.lbl_Wins.TabIndex = 8;
            this.lbl_Wins.Text = "0";
            // 
            // groupBox_TotalRoundsPlayed
            // 
            this.groupBox_TotalRoundsPlayed.Controls.Add(this.lbl_Txt_TotalRoundsPlayed);
            this.groupBox_TotalRoundsPlayed.Controls.Add(this.lbl_TotalRounds);
            this.groupBox_TotalRoundsPlayed.Location = new System.Drawing.Point(279, 131);
            this.groupBox_TotalRoundsPlayed.Name = "groupBox_TotalRoundsPlayed";
            this.groupBox_TotalRoundsPlayed.Size = new System.Drawing.Size(258, 149);
            this.groupBox_TotalRoundsPlayed.TabIndex = 9;
            this.groupBox_TotalRoundsPlayed.TabStop = false;
            // 
            // groupBox_TotalWins
            // 
            this.groupBox_TotalWins.Controls.Add(this.lbl_Wins);
            this.groupBox_TotalWins.Controls.Add(this.lbl_Txt_TotalWins);
            this.groupBox_TotalWins.Location = new System.Drawing.Point(555, 132);
            this.groupBox_TotalWins.Name = "groupBox_TotalWins";
            this.groupBox_TotalWins.Size = new System.Drawing.Size(256, 148);
            this.groupBox_TotalWins.TabIndex = 10;
            this.groupBox_TotalWins.TabStop = false;
            // 
            // groupBox_HighestRounds
            // 
            this.groupBox_HighestRounds.Controls.Add(this.lbl_HighRound);
            this.groupBox_HighestRounds.Controls.Add(this.lbl_Txt_HighestRounds);
            this.groupBox_HighestRounds.Location = new System.Drawing.Point(12, 132);
            this.groupBox_HighestRounds.Name = "groupBox_HighestRounds";
            this.groupBox_HighestRounds.Size = new System.Drawing.Size(249, 148);
            this.groupBox_HighestRounds.TabIndex = 11;
            this.groupBox_HighestRounds.TabStop = false;
            // 
            // groupBox_TotalGamesPlayed
            // 
            this.groupBox_TotalGamesPlayed.Controls.Add(this.lbl_GamesPlayed);
            this.groupBox_TotalGamesPlayed.Controls.Add(this.lbl_Txt_TotalGamesPlayed);
            this.groupBox_TotalGamesPlayed.Location = new System.Drawing.Point(151, 286);
            this.groupBox_TotalGamesPlayed.Name = "groupBox_TotalGamesPlayed";
            this.groupBox_TotalGamesPlayed.Size = new System.Drawing.Size(249, 148);
            this.groupBox_TotalGamesPlayed.TabIndex = 12;
            this.groupBox_TotalGamesPlayed.TabStop = false;
            // 
            // lbl_GamesPlayed
            // 
            this.lbl_GamesPlayed.AutoSize = true;
            this.lbl_GamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GamesPlayed.ForeColor = System.Drawing.Color.Navy;
            this.lbl_GamesPlayed.Location = new System.Drawing.Point(6, 25);
            this.lbl_GamesPlayed.Name = "lbl_GamesPlayed";
            this.lbl_GamesPlayed.Size = new System.Drawing.Size(99, 108);
            this.lbl_GamesPlayed.TabIndex = 4;
            this.lbl_GamesPlayed.Text = "0";
            // 
            // lbl_Txt_TotalGamesPlayed
            // 
            this.lbl_Txt_TotalGamesPlayed.AutoSize = true;
            this.lbl_Txt_TotalGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Txt_TotalGamesPlayed.Location = new System.Drawing.Point(16, 10);
            this.lbl_Txt_TotalGamesPlayed.Name = "lbl_Txt_TotalGamesPlayed";
            this.lbl_Txt_TotalGamesPlayed.Size = new System.Drawing.Size(150, 64);
            this.lbl_Txt_TotalGamesPlayed.TabIndex = 2;
            this.lbl_Txt_TotalGamesPlayed.Text = "Total Games Played\r\n\r\n\r\n\r\n";
            // 
            // groupBox_WinPercentage
            // 
            this.groupBox_WinPercentage.Controls.Add(this.lbl_WinPercent);
            this.groupBox_WinPercentage.Controls.Add(this.lbl_TxtWinPercentage);
            this.groupBox_WinPercentage.Location = new System.Drawing.Point(423, 286);
            this.groupBox_WinPercentage.Name = "groupBox_WinPercentage";
            this.groupBox_WinPercentage.Size = new System.Drawing.Size(302, 148);
            this.groupBox_WinPercentage.TabIndex = 12;
            this.groupBox_WinPercentage.TabStop = false;
            // 
            // lbl_WinPercent
            // 
            this.lbl_WinPercent.AutoSize = true;
            this.lbl_WinPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WinPercent.ForeColor = System.Drawing.Color.Navy;
            this.lbl_WinPercent.Location = new System.Drawing.Point(6, 25);
            this.lbl_WinPercent.Name = "lbl_WinPercent";
            this.lbl_WinPercent.Size = new System.Drawing.Size(99, 108);
            this.lbl_WinPercent.TabIndex = 4;
            this.lbl_WinPercent.Text = "0";
            // 
            // lbl_TxtWinPercentage
            // 
            this.lbl_TxtWinPercentage.AutoSize = true;
            this.lbl_TxtWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TxtWinPercentage.Location = new System.Drawing.Point(16, 10);
            this.lbl_TxtWinPercentage.Name = "lbl_TxtWinPercentage";
            this.lbl_TxtWinPercentage.Size = new System.Drawing.Size(135, 64);
            this.lbl_TxtWinPercentage.TabIndex = 2;
            this.lbl_TxtWinPercentage.Text = "Win Percentage %\r\n\r\n\r\n\r\n";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(827, 482);
            this.Controls.Add(this.groupBox_WinPercentage);
            this.Controls.Add(this.groupBox_TotalGamesPlayed);
            this.Controls.Add(this.groupBox_TotalWins);
            this.Controls.Add(this.lbl_Stats);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.groupBox_TotalRoundsPlayed);
            this.Controls.Add(this.groupBox_HighestRounds);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.groupBox_TotalRoundsPlayed.ResumeLayout(false);
            this.groupBox_TotalRoundsPlayed.PerformLayout();
            this.groupBox_TotalWins.ResumeLayout(false);
            this.groupBox_TotalWins.PerformLayout();
            this.groupBox_HighestRounds.ResumeLayout(false);
            this.groupBox_HighestRounds.PerformLayout();
            this.groupBox_TotalGamesPlayed.ResumeLayout(false);
            this.groupBox_TotalGamesPlayed.PerformLayout();
            this.groupBox_WinPercentage.ResumeLayout(false);
            this.groupBox_WinPercentage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Label lbl_Txt_TotalRoundsPlayed;
        private System.Windows.Forms.Label lbl_Txt_HighestRounds;
        private System.Windows.Forms.Label lbl_HighRound;
        private System.Windows.Forms.Label lbl_Stats;
        private System.Windows.Forms.Label lbl_TotalRounds;
        private System.Windows.Forms.Label lbl_Txt_TotalWins;
        private System.Windows.Forms.Label lbl_Wins;
        private System.Windows.Forms.GroupBox groupBox_TotalRoundsPlayed;
        private System.Windows.Forms.GroupBox groupBox_TotalWins;
        private System.Windows.Forms.GroupBox groupBox_HighestRounds;
        private System.Windows.Forms.GroupBox groupBox_TotalGamesPlayed;
        private System.Windows.Forms.Label lbl_GamesPlayed;
        private System.Windows.Forms.Label lbl_Txt_TotalGamesPlayed;
        private System.Windows.Forms.GroupBox groupBox_WinPercentage;
        private System.Windows.Forms.Label lbl_WinPercent;
        private System.Windows.Forms.Label lbl_TxtWinPercentage;
    }
}