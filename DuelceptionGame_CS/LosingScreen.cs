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
    public partial class LosingScreen : Form
    {
        public LosingScreen()
        {
            InitializeComponent();
        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/Stats.txt"; //Finds the User's directory, where the file will be created.
        private void LosingScreen_Load(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader(path)) //opens the Stats.txt file for reading.
            {
                int File_round = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the rounds played/completed from the file.
                int File_win = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total wins from the file.
                int File_highRound = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the highest round reached from the file.
                int File_totalRounds = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total rounds played/completed from the file.
                int File_gamesPlayed = Convert.ToInt32(streamReader.ReadLine()); //variable that holds the total games played from the file.
                lbl_Round.Text = File_round.ToString(); //Displays the Rounds played/completed. 
            }
        }

        private void btn_Rematch_Click(object sender, EventArgs e)
        {
            BattleArena battleArena = new BattleArena(); //Calls the BattleArena class and assigns its object.
            this.Close();
            this.Hide();
            battleArena.ShowDialog(); //Shows the BattleArena form.
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(); //Calls the Stats class and assigns its object.
            this.Close();
            this.Hide();
            stats.ShowDialog(); //Shows the Stats form.
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the current form. 
        }
    }
}
