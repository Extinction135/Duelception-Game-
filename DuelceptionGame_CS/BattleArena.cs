using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BattleArena : Form
    {
        public BattleArena()
        {
            InitializeComponent();
            
        }

        string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/Stats.txt"; //Finds the User's directory, where the file will be created.
        int round; //variable that holds the current rounds played/completed. 
        int win;  
        int totalRounds;
        int highRound;
        int gamesPlayed;

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_AcceptAbility_Click(object sender, EventArgs e) //This function is run when Player clicks on the 'Accept and Battle' button. 
        {
            timer_HealthCheck.Start(); //Starts the HealthCheck timer. 
            Player player = new Player(); //calls the Player class and assigns its object.
            Enemy enemy = new Enemy(); //calls the Enemy class and assigns its object.
            round = Convert.ToInt32(this.lbl_Round.Text); 
            string selection = listBox_PlayerAbilities.GetItemText(listBox_PlayerAbilities.SelectedItem); // Gets Player's selected ability and stores it in the variable named selection.            
            player.health = Convert.ToInt32(this.lbl_PlayerHealth.Text); 
            enemy.health = Convert.ToInt32(this.lbl_EnemyHealth.Text);
            btn_HowToPlay.Visible = true;
            btn_AcceptAbility.Enabled = true;
            btn_AcceptAbility.Text = "Attack and Battle";

            if (selection == "Divine Power")  //If Player has choosen the ability 'Divine Power', this if loop will run. 
            {
                btn_AcceptAbility.Text = "In Battle...";
                btn_AcceptAbility.Enabled = false;
                listBox_PlayerAbilities.Visible = false;
                btn_HowToPlay.Visible = false;
                lbl_Choose.Visible = false;
                string Player_Attack1_Info;
                string Enemy_Attack_Info;
                enemy.health = enemy.health - player.PlayerAttack1(out Player_Attack1_Info); //Determines Enemy's new health from the damage dealt by Player.
                enemy.health = (enemy.health < 0) ? 0 : enemy.health; //Health check to prevent health going below 0.
                lbl_EnemyHealth.Text = enemy.health.ToString(); //Displays Enemy's new health after player attack. 
                lbl_EnemyHealth.Update();
                lbl_BattleMessage.ForeColor = System.Drawing.Color.DarkCyan;
                lbl_BattleMessage.Text = "You have Attacked!";
                lbl_BattleMessage.Update();
                richTxtBox_PlayerFeed.Text = Player_Attack1_Info; //Displays the Player's Attack information/stats. 
                richTxtBox_PlayerFeed.Update();
                richTxtBox_EnemyFeed.Text = "Enemy has been Attacked!";
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(2000);   
                timer_HealthCheck_Tick(sender, e); //Calls the timer HealthCheck function to check if Enemy's health is zero.
                lbl_BattleMessage.ForeColor = System.Drawing.Color.Gray;
                lbl_BattleMessage.Text = "Enemy is Preparing to Attack...";
                lbl_BattleMessage.Update();
                lbl_EnemyHealth.Update();
                richTxtBox_EnemyFeed.Text = "Enemy is Preparing to Attack...";
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(2000); //Sleep functions are used to delay text and create an illusion of a turned-based attack. 
                lbl_BattleMessage.ForeColor = System.Drawing.Color.DarkRed;
                lbl_BattleMessage.Text = "Enemy Has Attacked...";
                lbl_BattleMessage.Update();
                player.health = player.health - enemy.Attack(out Enemy_Attack_Info); //Determines Player's new health from the damage dealt by Enemy.
                player.health = (player.health < 0) ? 0 : player.health; //Health check to prevent health going below 0.
                lbl_PlayerHealth.Text = player.health.ToString(); //Displays Player's new health after Enemys attack. 
                lbl_PlayerHealth.Update();
                lbl_EnemyHealth.Text = enemy.health.ToString(); //Updates and displays Enemy's new health if it uses the Restore ability and gains back health. 
                lbl_EnemyHealth.Update();
                richTxtBox_EnemyFeed.Text = Enemy_Attack_Info; //Displays the Enemy's Attack information/stats.
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(3000);
                timer_HealthCheck_Tick(sender, e); //Calls the timer HealthCheck function to check if Player's or Enemy's health is zero.
                round = round + 1; //increments the rounds played. 
                lbl_Round.Text = round.ToString(); //displays the current Round. 

            }
            else if (selection == "Healing Touch") //If Player has choosen the ability 'Healing Touch', this if loop will run.
            {
                btn_AcceptAbility.Text = "In Battle...";
                btn_AcceptAbility.Enabled = false;
                listBox_PlayerAbilities.Visible = false;
                btn_HowToPlay.Visible = false;
                lbl_Choose.Visible = false;
                string Player_Attack2_Info;
                string Enemy_Attack_Info;
                enemy.health = enemy.health - player.PlayerAttack2(out Player_Attack2_Info); //Determines Enemy's new health from the damage dealt by Player.
                enemy.health = (enemy.health < 0) ? 0 : enemy.health; //Health check to prevent health going below 0.
                lbl_PlayerHealth.Text = player.health.ToString(); //Displays Player's new health after gaining back health. 
                lbl_PlayerHealth.Update();
                lbl_EnemyHealth.Text = enemy.health.ToString(); //Displays Enemy's new health after Player attack.
                lbl_EnemyHealth.Update();
                lbl_BattleMessage.ForeColor = System.Drawing.Color.DarkCyan;
                lbl_BattleMessage.Text = "You have Attacked!";
                lbl_BattleMessage.Update();
                richTxtBox_PlayerFeed.Text = Player_Attack2_Info; //Displays the Player's Attack information/stats. 
                richTxtBox_PlayerFeed.Update();
                richTxtBox_EnemyFeed.Text = "Enemy has been Attacked!";
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(2000);
                timer_HealthCheck_Tick(sender, e); //Calls the timer HealthCheck function to check if Enemy's health is zero.
                lbl_BattleMessage.ForeColor = System.Drawing.Color.Gray;
                lbl_BattleMessage.Text = "Enemy is Preparing to Attack...";
                lbl_BattleMessage.Update();
                lbl_EnemyHealth.Update();
                richTxtBox_EnemyFeed.Text = "Enemy is Preparing to Attack...";
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(2000); //Sleep functions are used to delay text and create an illusion of a turned-based attack.
                lbl_BattleMessage.ForeColor = System.Drawing.Color.DarkRed;
                lbl_BattleMessage.Text = "Enemy Has Attacked...";
                lbl_BattleMessage.Update();
                player.health = player.health - enemy.Attack(out Enemy_Attack_Info); //Determines Player's new health from the damage dealt by Enemy.
                player.health = (player.health < 0) ? 0 : player.health; //Health check to prevent health going below 0.
                lbl_PlayerHealth.Text = player.health.ToString(); //Displays Player's new health after Enemy attack.
                lbl_PlayerHealth.Update();
                lbl_EnemyHealth.Text = enemy.health.ToString(); //Updates and displays Enemy's new health if it uses the Restore ability and gains back health. 
                lbl_EnemyHealth.Update();
                richTxtBox_EnemyFeed.Text = Enemy_Attack_Info; //Displays the Enemy's Attack information/stats.
                richTxtBox_EnemyFeed.Update();
                Thread.Sleep(3000);
                timer_HealthCheck_Tick(sender, e); //Calls the timer HealthCheck function to check if Player's or Enemy's health is zero.
                round = round + 1;
                lbl_Round.Text = round.ToString();

            }
            

            else
            {
                MessageBox.Show("Please select an Ability!"); //If Player doesn't select and ability and clicks on the 'Accept and Battle' button, this error message is displayed.
            }
            lbl_BattleMessage.ForeColor = System.Drawing.Color.Gray;
            lbl_BattleMessage.Text = "Waiting for Player...";
            btn_HowToPlay.Visible = true;
            btn_AcceptAbility.Enabled = true;
            listBox_PlayerAbilities.Visible = true;
            lbl_Choose.Visible = true;
            btn_AcceptAbility.Text = "Attack and Battle";
            richTxtBox_PlayerFeed.Text = "Waiting for Player to select Ability..." ;
            richTxtBox_EnemyFeed.Text = "Waiting for Player to select Ability...";
            
      
          


        }

        private void timer_HealthCheck_Tick(object sender, EventArgs e) //Timer Function that checks whether Player's or Enemy's health is zero. 
        {
            int Player_health = Convert.ToInt32(this.lbl_PlayerHealth.Text); //Variable that stores the current Player's health from the label.
            int Enemy_health = Convert.ToInt32(this.lbl_EnemyHealth.Text); //Variable that stores the current Enemy's health from the label.

            if (Player_health == 0) //checks if Player's health is zero. 
            {
                timer_HealthCheck.Stop(); //stops the timer. 
                btn_AcceptAbility.Text = "Game Over!";
                MessageBox.Show("You Lose!"); //displays a message to the Player that they lost. 
                btn_AcceptAbility.Enabled = false;
                listBox_PlayerAbilities.Visible = false;
                lbl_Choose.Visible = false;
                win = 0;
                gamesPlayed = 1;
                round = Convert.ToInt32(lbl_Round.Text);
                using (StreamReader streamReader = new StreamReader(path)) //opens the Stats.txt file for reading. 
                {
                    int File_round = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the rounds played/completed from the file.
                    int File_win = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total wins from the file.
                    int File_highRound = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the highest round reached from the file.
                    int File_totalRounds = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total rounds played/completed from the file.
                    int File_gamesPlayed = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total games played from the file.

                    if (round > File_highRound) // if loop to check if the current rounds played is higher than the stored High Round in the file. 
                    {
                        highRound = round; //if it is higher then the new high round will become the current rounds played. 
                    }
                    else //if it is not then the new high round will remain the same as the stored high round from the file.
                    {
                        highRound = File_highRound;
                    }
                    streamReader.Close();

                    using (StreamWriter streamWriter = new StreamWriter(path)) //opens the Stats.txt file for writing/overwriting. 
                    {
                        streamWriter.WriteLine(round); // stores the current rounds played/completed. 
                        streamWriter.WriteLine(File_win + win); //stores the new total number of wins. 
                        streamWriter.WriteLine(highRound); //stores the new high round. 
                        streamWriter.WriteLine(File_totalRounds + round); //stores the new total number of rounds played.
                        streamWriter.WriteLine(File_gamesPlayed + gamesPlayed); //stores the new total number of games played. 
                        streamWriter.Close();
                    }
                }
                LosingScreen losingScreen = new LosingScreen(); //Calls the losingScreen class and assigns its object. 
                this.Close(); 
                this.Hide();
                losingScreen.ShowDialog(); //Shows the losingScreen form. 
                
            }
            else if (Enemy_health == 0) //checks if Enemy's health is zero. 
            {
                timer_HealthCheck.Stop(); //stops the timer. 
                btn_AcceptAbility.Text = "Game Over!";
                MessageBox.Show("You Win!"); //displays a message to the Player that they won. 
                btn_AcceptAbility.Enabled = false;
                listBox_PlayerAbilities.Visible = false;
                lbl_Choose.Visible = false;
                win = 1;
                gamesPlayed = 1;
                round = Convert.ToInt32(lbl_Round.Text);
                using (StreamReader streamReader = new StreamReader(path))
                {
                    int File_round = Convert.ToInt32(streamReader.ReadLine());
                    int File_win = Convert.ToInt32(streamReader.ReadLine());
                    int File_highRound = Convert.ToInt32(streamReader.ReadLine());
                    int File_totalRounds = Convert.ToInt32(streamReader.ReadLine());
                    int File_gamesPlayed = Convert.ToInt32(streamReader.ReadLine());
                    if (round > File_highRound)
                    {
                        highRound = round;
                    }
                    else
                    {
                        highRound = File_highRound;
                    }
                    streamReader.Close();

                    using (StreamWriter streamWriter = new StreamWriter(path))
                    {
                        streamWriter.WriteLine(round);
                        streamWriter.WriteLine(File_win + win);
                        streamWriter.WriteLine(highRound);
                        streamWriter.WriteLine(File_totalRounds + round);
                        streamWriter.WriteLine(File_gamesPlayed + gamesPlayed);
                        streamWriter.Close();
                    }
                }
                VictoryScreen victoryScreen = new VictoryScreen(); //Calls the VictoryScreen class and assigns its object. 
                this.Close();
                this.Hide();
                victoryScreen.ShowDialog(); //Shows the VictoryScreen form.
            }
        }   

        private void lbl_EnemyHealth_Click(object sender, EventArgs e)
        {

        }

        private void btn_HowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay howToPlay = new HowToPlay(); //Calls the HowToPlay class and assigns its object.
            this.Close();
            this.Hide();
            howToPlay.ShowDialog(); //Shows the HowToPlay form.

        }
    }
}
