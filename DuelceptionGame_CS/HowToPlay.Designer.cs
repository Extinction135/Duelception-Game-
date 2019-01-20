namespace WindowsFormsApp3
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.richTextBox_Guide = new System.Windows.Forms.RichTextBox();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.lbl_HowToPlay = new System.Windows.Forms.Label();
            this.groupBox_Guide = new System.Windows.Forms.GroupBox();
            this.Pic_Player = new System.Windows.Forms.PictureBox();
            this.richTextBox_PlayerAbilities = new System.Windows.Forms.RichTextBox();
            this.groupBox_YourAbilities = new System.Windows.Forms.GroupBox();
            this.groupBox_EnemyAbilities = new System.Windows.Forms.GroupBox();
            this.Pic_Enemy = new System.Windows.Forms.PictureBox();
            this.richTextBox_EnemyAbilities = new System.Windows.Forms.RichTextBox();
            this.groupBox_Guide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Player)).BeginInit();
            this.groupBox_YourAbilities.SuspendLayout();
            this.groupBox_EnemyAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Guide
            // 
            this.richTextBox_Guide.Enabled = false;
            this.richTextBox_Guide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Guide.Location = new System.Drawing.Point(11, 19);
            this.richTextBox_Guide.Name = "richTextBox_Guide";
            this.richTextBox_Guide.Size = new System.Drawing.Size(909, 140);
            this.richTextBox_Guide.TabIndex = 0;
            this.richTextBox_Guide.Text = resources.GetString("richTextBox_Guide.Text");
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_MainMenu.Location = new System.Drawing.Point(331, 428);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(285, 41);
            this.btn_MainMenu.TabIndex = 1;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // lbl_HowToPlay
            // 
            this.lbl_HowToPlay.AutoSize = true;
            this.lbl_HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HowToPlay.ForeColor = System.Drawing.Color.Green;
            this.lbl_HowToPlay.Location = new System.Drawing.Point(164, -7);
            this.lbl_HowToPlay.Name = "lbl_HowToPlay";
            this.lbl_HowToPlay.Size = new System.Drawing.Size(597, 108);
            this.lbl_HowToPlay.TabIndex = 3;
            this.lbl_HowToPlay.Text = "How To Play";
            // 
            // groupBox_Guide
            // 
            this.groupBox_Guide.Controls.Add(this.richTextBox_Guide);
            this.groupBox_Guide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Guide.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox_Guide.Location = new System.Drawing.Point(10, 104);
            this.groupBox_Guide.Name = "groupBox_Guide";
            this.groupBox_Guide.Size = new System.Drawing.Size(941, 165);
            this.groupBox_Guide.TabIndex = 4;
            this.groupBox_Guide.TabStop = false;
            this.groupBox_Guide.Text = "Guide";
            // 
            // Pic_Player
            // 
            this.Pic_Player.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Player.Image")));
            this.Pic_Player.Location = new System.Drawing.Point(17, 15);
            this.Pic_Player.Name = "Pic_Player";
            this.Pic_Player.Size = new System.Drawing.Size(115, 107);
            this.Pic_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Player.TabIndex = 5;
            this.Pic_Player.TabStop = false;
            // 
            // richTextBox_PlayerAbilities
            // 
            this.richTextBox_PlayerAbilities.Enabled = false;
            this.richTextBox_PlayerAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_PlayerAbilities.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTextBox_PlayerAbilities.Location = new System.Drawing.Point(149, 15);
            this.richTextBox_PlayerAbilities.Name = "richTextBox_PlayerAbilities";
            this.richTextBox_PlayerAbilities.Size = new System.Drawing.Size(294, 107);
            this.richTextBox_PlayerAbilities.TabIndex = 6;
            this.richTextBox_PlayerAbilities.Text = "Your Abilities:\n(1) Divine Power - Attacks for 190 damage.\n\n(2) Healing Touch - A" +
    "ttacks for 50 damage and you gain 170 health.\n";
            // 
            // groupBox_YourAbilities
            // 
            this.groupBox_YourAbilities.Controls.Add(this.richTextBox_PlayerAbilities);
            this.groupBox_YourAbilities.Controls.Add(this.Pic_Player);
            this.groupBox_YourAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_YourAbilities.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox_YourAbilities.Location = new System.Drawing.Point(10, 275);
            this.groupBox_YourAbilities.Name = "groupBox_YourAbilities";
            this.groupBox_YourAbilities.Size = new System.Drawing.Size(462, 147);
            this.groupBox_YourAbilities.TabIndex = 7;
            this.groupBox_YourAbilities.TabStop = false;
            this.groupBox_YourAbilities.Text = "Your Abilities";
            // 
            // groupBox_EnemyAbilities
            // 
            this.groupBox_EnemyAbilities.Controls.Add(this.Pic_Enemy);
            this.groupBox_EnemyAbilities.Controls.Add(this.richTextBox_EnemyAbilities);
            this.groupBox_EnemyAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_EnemyAbilities.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox_EnemyAbilities.Location = new System.Drawing.Point(502, 275);
            this.groupBox_EnemyAbilities.Name = "groupBox_EnemyAbilities";
            this.groupBox_EnemyAbilities.Size = new System.Drawing.Size(449, 147);
            this.groupBox_EnemyAbilities.TabIndex = 8;
            this.groupBox_EnemyAbilities.TabStop = false;
            this.groupBox_EnemyAbilities.Text = "Enemy Abilities";
            // 
            // Pic_Enemy
            // 
            this.Pic_Enemy.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Enemy.Image")));
            this.Pic_Enemy.Location = new System.Drawing.Point(15, 15);
            this.Pic_Enemy.Name = "Pic_Enemy";
            this.Pic_Enemy.Size = new System.Drawing.Size(115, 107);
            this.Pic_Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Enemy.TabIndex = 9;
            this.Pic_Enemy.TabStop = false;
            // 
            // richTextBox_EnemyAbilities
            // 
            this.richTextBox_EnemyAbilities.Enabled = false;
            this.richTextBox_EnemyAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_EnemyAbilities.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox_EnemyAbilities.Location = new System.Drawing.Point(149, 15);
            this.richTextBox_EnemyAbilities.Name = "richTextBox_EnemyAbilities";
            this.richTextBox_EnemyAbilities.Size = new System.Drawing.Size(279, 107);
            this.richTextBox_EnemyAbilities.TabIndex = 6;
            this.richTextBox_EnemyAbilities.Text = "Enemy Abilities:\n(1) Fire Breath - Attacks for a random damage number between 100" +
    "-300.\n\n(2) Restore - Gains 300 Health. Enemy has a 25% chance of using this abil" +
    "ity.";
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(963, 481);
            this.Controls.Add(this.groupBox_EnemyAbilities);
            this.Controls.Add(this.groupBox_YourAbilities);
            this.Controls.Add(this.groupBox_Guide);
            this.Controls.Add(this.lbl_HowToPlay);
            this.Controls.Add(this.btn_MainMenu);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.groupBox_Guide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Player)).EndInit();
            this.groupBox_YourAbilities.ResumeLayout(false);
            this.groupBox_EnemyAbilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Guide;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Label lbl_HowToPlay;
        private System.Windows.Forms.GroupBox groupBox_Guide;
        private System.Windows.Forms.PictureBox Pic_Player;
        private System.Windows.Forms.RichTextBox richTextBox_PlayerAbilities;
        private System.Windows.Forms.GroupBox groupBox_YourAbilities;
        private System.Windows.Forms.GroupBox groupBox_EnemyAbilities;
        private System.Windows.Forms.RichTextBox richTextBox_EnemyAbilities;
        private System.Windows.Forms.PictureBox Pic_Enemy;
    }
}