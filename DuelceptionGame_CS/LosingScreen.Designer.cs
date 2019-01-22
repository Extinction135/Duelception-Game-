namespace WindowsFormsApp3
{
    partial class LosingScreen
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
            this.lbl_YouLose = new System.Windows.Forms.Label();
            this.lbl_Txt_RoundsPlayed = new System.Windows.Forms.Label();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.btn_Rematch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_YouLose
            // 
            this.lbl_YouLose.AutoSize = true;
            this.lbl_YouLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YouLose.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_YouLose.Location = new System.Drawing.Point(-1, 9);
            this.lbl_YouLose.Name = "lbl_YouLose";
            this.lbl_YouLose.Size = new System.Drawing.Size(519, 98);
            this.lbl_YouLose.TabIndex = 3;
            this.lbl_YouLose.Text = "YOU LOSE!";
            // 
            // lbl_Txt_RoundsPlayed
            // 
            this.lbl_Txt_RoundsPlayed.AutoSize = true;
            this.lbl_Txt_RoundsPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Txt_RoundsPlayed.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Txt_RoundsPlayed.Location = new System.Drawing.Point(160, 136);
            this.lbl_Txt_RoundsPlayed.Name = "lbl_Txt_RoundsPlayed";
            this.lbl_Txt_RoundsPlayed.Size = new System.Drawing.Size(146, 20);
            this.lbl_Txt_RoundsPlayed.TabIndex = 5;
            this.lbl_Txt_RoundsPlayed.Text = "Round(s) Played:";
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Round.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Round.Location = new System.Drawing.Point(312, 136);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(19, 20);
            this.lbl_Round.TabIndex = 4;
            this.lbl_Round.Text = "0";
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Quit.Location = new System.Drawing.Point(164, 303);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(167, 51);
            this.btn_Quit.TabIndex = 9;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_Stats
            // 
            this.btn_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stats.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Stats.Location = new System.Drawing.Point(164, 246);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(167, 51);
            this.btn_Stats.TabIndex = 8;
            this.btn_Stats.Text = "Stats";
            this.btn_Stats.UseVisualStyleBackColor = true;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // btn_Rematch
            // 
            this.btn_Rematch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Rematch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rematch.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Rematch.Location = new System.Drawing.Point(164, 189);
            this.btn_Rematch.Name = "btn_Rematch";
            this.btn_Rematch.Size = new System.Drawing.Size(167, 51);
            this.btn_Rematch.TabIndex = 7;
            this.btn_Rematch.Text = "Rematch";
            this.btn_Rematch.UseVisualStyleBackColor = true;
            this.btn_Rematch.Click += new System.EventHandler(this.btn_Rematch_Click);
            // 
            // LosingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 378);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.btn_Rematch);
            this.Controls.Add(this.lbl_Txt_RoundsPlayed);
            this.Controls.Add(this.lbl_Round);
            this.Controls.Add(this.lbl_YouLose);
            this.Name = "LosingScreen";
            this.Text = "Losing Screen";
            this.Load += new System.EventHandler(this.LosingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_YouLose;
        private System.Windows.Forms.Label lbl_Txt_RoundsPlayed;
        private System.Windows.Forms.Label lbl_Round;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Button btn_Rematch;
    }
}