namespace WindowsFormsApp3
{
    partial class BattleArena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleArena));
            this.lbl_BattleArena = new System.Windows.Forms.Label();
            this.Pic_Player = new System.Windows.Forms.PictureBox();
            this.Pic_Enemy = new System.Windows.Forms.PictureBox();
            this.lbl_VS = new System.Windows.Forms.Label();
            this.lbl_Health1 = new System.Windows.Forms.Label();
            this.lbl_Health2 = new System.Windows.Forms.Label();
            this.lbl_PlayerHealth = new System.Windows.Forms.Label();
            this.lbl_EnemyHealth = new System.Windows.Forms.Label();
            this.listBox_PlayerAbilities = new System.Windows.Forms.ListBox();
            this.richTxtBox_PlayerFeed = new System.Windows.Forms.RichTextBox();
            this.richTxtBox_EnemyFeed = new System.Windows.Forms.RichTextBox();
            this.lbl_BattleMessage = new System.Windows.Forms.Label();
            this.lbl_PlayerFeed = new System.Windows.Forms.Label();
            this.lbl_EnemyFeed = new System.Windows.Forms.Label();
            this.btn_AcceptAbility = new System.Windows.Forms.Button();
            this.timer_HealthCheck = new System.Windows.Forms.Timer(this.components);
            this.lbl_Choose = new System.Windows.Forms.Label();
            this.lbl_TxtRound = new System.Windows.Forms.Label();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.btn_HowToPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BattleArena
            // 
            this.lbl_BattleArena.AutoSize = true;
            this.lbl_BattleArena.Font = new System.Drawing.Font("Showcard Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BattleArena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_BattleArena.Location = new System.Drawing.Point(271, -5);
            this.lbl_BattleArena.Name = "lbl_BattleArena";
            this.lbl_BattleArena.Size = new System.Drawing.Size(395, 66);
            this.lbl_BattleArena.TabIndex = 1;
            this.lbl_BattleArena.Text = "Battle Arena";
            // 
            // Pic_Player
            // 
            this.Pic_Player.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Player.Image")));
            this.Pic_Player.Location = new System.Drawing.Point(171, 99);
            this.Pic_Player.Name = "Pic_Player";
            this.Pic_Player.Size = new System.Drawing.Size(221, 179);
            this.Pic_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Player.TabIndex = 2;
            this.Pic_Player.TabStop = false;
            // 
            // Pic_Enemy
            // 
            this.Pic_Enemy.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Enemy.Image")));
            this.Pic_Enemy.Location = new System.Drawing.Point(535, 99);
            this.Pic_Enemy.Name = "Pic_Enemy";
            this.Pic_Enemy.Size = new System.Drawing.Size(221, 179);
            this.Pic_Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Enemy.TabIndex = 3;
            this.Pic_Enemy.TabStop = false;
            // 
            // lbl_VS
            // 
            this.lbl_VS.AutoSize = true;
            this.lbl_VS.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_VS.Location = new System.Drawing.Point(438, 192);
            this.lbl_VS.Name = "lbl_VS";
            this.lbl_VS.Size = new System.Drawing.Size(50, 30);
            this.lbl_VS.TabIndex = 4;
            this.lbl_VS.Text = "VS";
            // 
            // lbl_Health1
            // 
            this.lbl_Health1.AutoSize = true;
            this.lbl_Health1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Health1.ForeColor = System.Drawing.Color.Green;
            this.lbl_Health1.Location = new System.Drawing.Point(208, 71);
            this.lbl_Health1.Name = "lbl_Health1";
            this.lbl_Health1.Size = new System.Drawing.Size(112, 21);
            this.lbl_Health1.TabIndex = 5;
            this.lbl_Health1.Text = "Your Health: ";
            this.lbl_Health1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Health2
            // 
            this.lbl_Health2.AutoSize = true;
            this.lbl_Health2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Health2.ForeColor = System.Drawing.Color.Green;
            this.lbl_Health2.Location = new System.Drawing.Point(566, 70);
            this.lbl_Health2.Name = "lbl_Health2";
            this.lbl_Health2.Size = new System.Drawing.Size(124, 21);
            this.lbl_Health2.TabIndex = 6;
            this.lbl_Health2.Text = "Enemy Health: ";
            // 
            // lbl_PlayerHealth
            // 
            this.lbl_PlayerHealth.AutoSize = true;
            this.lbl_PlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_PlayerHealth.Location = new System.Drawing.Point(310, 73);
            this.lbl_PlayerHealth.Name = "lbl_PlayerHealth";
            this.lbl_PlayerHealth.Size = new System.Drawing.Size(35, 18);
            this.lbl_PlayerHealth.TabIndex = 7;
            this.lbl_PlayerHealth.Text = "600";
            this.lbl_PlayerHealth.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_EnemyHealth
            // 
            this.lbl_EnemyHealth.AutoSize = true;
            this.lbl_EnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnemyHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_EnemyHealth.Location = new System.Drawing.Point(681, 72);
            this.lbl_EnemyHealth.Name = "lbl_EnemyHealth";
            this.lbl_EnemyHealth.Size = new System.Drawing.Size(35, 18);
            this.lbl_EnemyHealth.TabIndex = 8;
            this.lbl_EnemyHealth.Text = "600";
            this.lbl_EnemyHealth.Click += new System.EventHandler(this.lbl_EnemyHealth_Click);
            // 
            // listBox_PlayerAbilities
            // 
            this.listBox_PlayerAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_PlayerAbilities.ForeColor = System.Drawing.Color.Teal;
            this.listBox_PlayerAbilities.FormattingEnabled = true;
            this.listBox_PlayerAbilities.ItemHeight = 16;
            this.listBox_PlayerAbilities.Items.AddRange(new object[] {
            "Divine Power",
            "Healing Touch"});
            this.listBox_PlayerAbilities.Location = new System.Drawing.Point(15, 118);
            this.listBox_PlayerAbilities.Name = "listBox_PlayerAbilities";
            this.listBox_PlayerAbilities.Size = new System.Drawing.Size(153, 52);
            this.listBox_PlayerAbilities.TabIndex = 9;
            this.listBox_PlayerAbilities.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTxtBox_PlayerFeed
            // 
            this.richTxtBox_PlayerFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox_PlayerFeed.ForeColor = System.Drawing.Color.Teal;
            this.richTxtBox_PlayerFeed.Location = new System.Drawing.Point(171, 334);
            this.richTxtBox_PlayerFeed.Name = "richTxtBox_PlayerFeed";
            this.richTxtBox_PlayerFeed.ReadOnly = true;
            this.richTxtBox_PlayerFeed.Size = new System.Drawing.Size(221, 74);
            this.richTxtBox_PlayerFeed.TabIndex = 11;
            this.richTxtBox_PlayerFeed.Text = "Waiting for Player to select Ability...\n";
            // 
            // richTxtBox_EnemyFeed
            // 
            this.richTxtBox_EnemyFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox_EnemyFeed.ForeColor = System.Drawing.Color.Maroon;
            this.richTxtBox_EnemyFeed.Location = new System.Drawing.Point(535, 334);
            this.richTxtBox_EnemyFeed.Name = "richTxtBox_EnemyFeed";
            this.richTxtBox_EnemyFeed.ReadOnly = true;
            this.richTxtBox_EnemyFeed.Size = new System.Drawing.Size(221, 74);
            this.richTxtBox_EnemyFeed.TabIndex = 12;
            this.richTxtBox_EnemyFeed.Text = "Waiting for Player to select Ability...";
            // 
            // lbl_BattleMessage
            // 
            this.lbl_BattleMessage.AutoSize = true;
            this.lbl_BattleMessage.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BattleMessage.ForeColor = System.Drawing.Color.Gray;
            this.lbl_BattleMessage.Location = new System.Drawing.Point(336, 281);
            this.lbl_BattleMessage.Name = "lbl_BattleMessage";
            this.lbl_BattleMessage.Size = new System.Drawing.Size(231, 30);
            this.lbl_BattleMessage.TabIndex = 13;
            this.lbl_BattleMessage.Text = "Waiting for Player...";
            // 
            // lbl_PlayerFeed
            // 
            this.lbl_PlayerFeed.AutoSize = true;
            this.lbl_PlayerFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerFeed.ForeColor = System.Drawing.Color.Black;
            this.lbl_PlayerFeed.Location = new System.Drawing.Point(168, 318);
            this.lbl_PlayerFeed.Name = "lbl_PlayerFeed";
            this.lbl_PlayerFeed.Size = new System.Drawing.Size(190, 16);
            this.lbl_PlayerFeed.TabIndex = 14;
            this.lbl_PlayerFeed.Text = "(Your) Player Attack Feed:\r\n";
            // 
            // lbl_EnemyFeed
            // 
            this.lbl_EnemyFeed.AutoSize = true;
            this.lbl_EnemyFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnemyFeed.ForeColor = System.Drawing.Color.Black;
            this.lbl_EnemyFeed.Location = new System.Drawing.Point(532, 318);
            this.lbl_EnemyFeed.Name = "lbl_EnemyFeed";
            this.lbl_EnemyFeed.Size = new System.Drawing.Size(146, 16);
            this.lbl_EnemyFeed.TabIndex = 15;
            this.lbl_EnemyFeed.Text = "Enemy Attack Feed:\r\n";
            // 
            // btn_AcceptAbility
            // 
            this.btn_AcceptAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcceptAbility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AcceptAbility.Location = new System.Drawing.Point(15, 176);
            this.btn_AcceptAbility.Name = "btn_AcceptAbility";
            this.btn_AcceptAbility.Size = new System.Drawing.Size(153, 35);
            this.btn_AcceptAbility.TabIndex = 16;
            this.btn_AcceptAbility.Text = "Accept and Battle";
            this.btn_AcceptAbility.UseVisualStyleBackColor = true;
            this.btn_AcceptAbility.Click += new System.EventHandler(this.btn_AcceptAbility_Click);
            // 
            // timer_HealthCheck
            // 
            this.timer_HealthCheck.Tick += new System.EventHandler(this.timer_HealthCheck_Tick);
            // 
            // lbl_Choose
            // 
            this.lbl_Choose.AutoSize = true;
            this.lbl_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Choose.ForeColor = System.Drawing.Color.Black;
            this.lbl_Choose.Location = new System.Drawing.Point(12, 99);
            this.lbl_Choose.Name = "lbl_Choose";
            this.lbl_Choose.Size = new System.Drawing.Size(133, 16);
            this.lbl_Choose.TabIndex = 17;
            this.lbl_Choose.Text = "Choose an Ability:";
            // 
            // lbl_TxtRound
            // 
            this.lbl_TxtRound.AutoSize = true;
            this.lbl_TxtRound.Font = new System.Drawing.Font("Nova Square", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TxtRound.ForeColor = System.Drawing.Color.Navy;
            this.lbl_TxtRound.Location = new System.Drawing.Point(398, 152);
            this.lbl_TxtRound.Name = "lbl_TxtRound";
            this.lbl_TxtRound.Size = new System.Drawing.Size(103, 23);
            this.lbl_TxtRound.TabIndex = 18;
            this.lbl_TxtRound.Text = "Round(s):";
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.Font = new System.Drawing.Font("Nova Square", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Round.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Round.Location = new System.Drawing.Point(507, 152);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(18, 23);
            this.lbl_Round.TabIndex = 19;
            this.lbl_Round.Text = "1";
            // 
            // btn_HowToPlay
            // 
            this.btn_HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HowToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_HowToPlay.Location = new System.Drawing.Point(15, 255);
            this.btn_HowToPlay.Name = "btn_HowToPlay";
            this.btn_HowToPlay.Size = new System.Drawing.Size(153, 23);
            this.btn_HowToPlay.TabIndex = 20;
            this.btn_HowToPlay.Text = "How To Play\r\n";
            this.btn_HowToPlay.UseVisualStyleBackColor = true;
            this.btn_HowToPlay.Click += new System.EventHandler(this.btn_HowToPlay_Click);
            // 
            // BattleArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.btn_HowToPlay);
            this.Controls.Add(this.lbl_Round);
            this.Controls.Add(this.lbl_TxtRound);
            this.Controls.Add(this.lbl_Choose);
            this.Controls.Add(this.btn_AcceptAbility);
            this.Controls.Add(this.lbl_EnemyFeed);
            this.Controls.Add(this.lbl_PlayerFeed);
            this.Controls.Add(this.lbl_BattleMessage);
            this.Controls.Add(this.richTxtBox_EnemyFeed);
            this.Controls.Add(this.richTxtBox_PlayerFeed);
            this.Controls.Add(this.listBox_PlayerAbilities);
            this.Controls.Add(this.lbl_EnemyHealth);
            this.Controls.Add(this.lbl_PlayerHealth);
            this.Controls.Add(this.lbl_Health2);
            this.Controls.Add(this.lbl_Health1);
            this.Controls.Add(this.lbl_VS);
            this.Controls.Add(this.Pic_Enemy);
            this.Controls.Add(this.Pic_Player);
            this.Controls.Add(this.lbl_BattleArena);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BattleArena";
            this.Text = "Battle Arena";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BattleArena;
        private System.Windows.Forms.PictureBox Pic_Player;
        private System.Windows.Forms.PictureBox Pic_Enemy;
        private System.Windows.Forms.Label lbl_VS;
        private System.Windows.Forms.Label lbl_Health1;
        private System.Windows.Forms.Label lbl_Health2;
        private System.Windows.Forms.Label lbl_PlayerHealth;
        private System.Windows.Forms.Label lbl_EnemyHealth;
        private System.Windows.Forms.ListBox listBox_PlayerAbilities;
        private System.Windows.Forms.RichTextBox richTxtBox_PlayerFeed;
        private System.Windows.Forms.RichTextBox richTxtBox_EnemyFeed;
        private System.Windows.Forms.Label lbl_BattleMessage;
        private System.Windows.Forms.Label lbl_PlayerFeed;
        private System.Windows.Forms.Label lbl_EnemyFeed;
        private System.Windows.Forms.Button btn_AcceptAbility;
        private System.Windows.Forms.Timer timer_HealthCheck;
        private System.Windows.Forms.Label lbl_Choose;
        private System.Windows.Forms.Label lbl_TxtRound;
        private System.Windows.Forms.Label lbl_Round;
        private System.Windows.Forms.Button btn_HowToPlay;
    }
}