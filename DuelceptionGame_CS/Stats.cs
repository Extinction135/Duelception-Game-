using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/Stats.txt"; //Finds the User's directory, where the file will be created.
        private void Stats_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path)) //Checks if file does not already exist in the path directory. 
            {
                var stats_File = File.CreateText(path); //creates the file in the path directory if the file does not exist.
                stats_File.Close(); //closes file. 
            
            }

            using (StreamReader streamReader = new StreamReader(path)) //opens the Stats.txt file for reading.
            {
                int File_round = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the rounds played/completed from the file.
                int File_win = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total wins from the file.
                int File_highRound = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the highest round reached from the file.
                int File_totalRounds = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total rounds played/completed from the file.
                int File_gamesPlayed = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total games played from the file.

                lbl_HighRound.Text = File_highRound.ToString(); //Displays the Highest round reached. 
                lbl_TotalRounds.Text = File_totalRounds.ToString(); //Displays the total rounds played/completed. 
                lbl_Wins.Text = File_win.ToString(); //Displays the total wins.  
                lbl_GamesPlayed.Text = File_gamesPlayed.ToString(); //Displays the total games played. 

                double win_Percent;
                win_Percent = (File_win / (double)File_gamesPlayed) * 100; //calculates the win percentage.

                if (double.IsNaN(win_Percent)) //if loop that checks the double variable 'win_percent' for NaN value. 
                {
                    lbl_WinPercent.Text = 0.ToString(); //if it is NaN then the (label)lbl_WinPercent's text is changed to 0.
                }
                else
                {
                    lbl_WinPercent.Text = win_Percent.ToString("0.0"); // if it isn't NaN then the (label)lbl_WinPercent's text is set to win_Percent (upto 1 decimal place).
                }
             

            }
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Calls the MainMenu class and assigns its object.
            this.Hide();
            this.Close();
            mainMenu.ShowDialog(); //Shows the MainMenu form. 
        }
    }
}
