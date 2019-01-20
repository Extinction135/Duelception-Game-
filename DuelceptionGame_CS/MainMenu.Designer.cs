namespace WindowsFormsApp3
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HowToPlay = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.lbl_DeveloperName = new System.Windows.Forms.Label();
            this.lbl_CS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duelception";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_HowToPlay
            // 
            this.btn_HowToPlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HowToPlay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_HowToPlay.Location = new System.Drawing.Point(284, 249);
            this.btn_HowToPlay.Name = "btn_HowToPlay";
            this.btn_HowToPlay.Size = new System.Drawing.Size(202, 51);
            this.btn_HowToPlay.TabIndex = 2;
            this.btn_HowToPlay.Text = "How To Play";
            this.btn_HowToPlay.UseVisualStyleBackColor = false;
            this.btn_HowToPlay.Click += new System.EventHandler(this.btn_HowToPlay_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Quit.FlatAppearance.BorderSize = 6;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Quit.Location = new System.Drawing.Point(284, 363);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(202, 51);
            this.btn_Quit.TabIndex = 4;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartGame.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_StartGame.Location = new System.Drawing.Point(284, 192);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(202, 51);
            this.btn_StartGame.TabIndex = 5;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = false;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Stats.FlatAppearance.BorderSize = 6;
            this.btn_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stats.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Stats.Location = new System.Drawing.Point(284, 306);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(202, 51);
            this.btn_Stats.TabIndex = 6;
            this.btn_Stats.Text = "Stats";
            this.btn_Stats.UseVisualStyleBackColor = false;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // lbl_DeveloperName
            // 
            this.lbl_DeveloperName.AutoSize = true;
            this.lbl_DeveloperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeveloperName.Location = new System.Drawing.Point(546, 137);
            this.lbl_DeveloperName.Name = "lbl_DeveloperName";
            this.lbl_DeveloperName.Size = new System.Drawing.Size(165, 13);
            this.lbl_DeveloperName.TabIndex = 7;
            this.lbl_DeveloperName.Text = "Developed by Ronil Sedani.";
            // 
            // lbl_CS
            // 
            this.lbl_CS.AutoSize = true;
            this.lbl_CS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CS.Location = new System.Drawing.Point(578, 124);
            this.lbl_CS.Name = "lbl_CS";
            this.lbl_CS.Size = new System.Drawing.Size(133, 13);
            this.lbl_CS.TabIndex = 8;
            this.lbl_CS.Text = "Built in C# Forms App.\r\n";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CS);
            this.Controls.Add(this.lbl_DeveloperName);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_HowToPlay);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HowToPlay;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Label lbl_DeveloperName;
        private System.Windows.Forms.Label lbl_CS;
    }
}

