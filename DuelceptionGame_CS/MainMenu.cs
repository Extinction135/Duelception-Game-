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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the current form. 
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_HowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay howToPlay = new HowToPlay(); //Calls the HowToPlay class and assigns its object.
            howToPlay.Show(); //Shows the HowToPlay form.
            Hide(); //hides the current form (MainMenu).
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/Stats.txt"; //Finds the User's directory, where the file will be created.
            BattleArena battleArena = new BattleArena(); //Calls the BattleArena class and assigns its object.
            battleArena.Show(); //Shows the BattleArena form. 
            Hide(); //hides the current form. 

            if (!File.Exists(path)) //Checks if file does not already exist in the path directory.
            {
                var stats_File = File.CreateText(path); //creates the file in the path directory if the file does not exist.
                stats_File.Close(); //closes file. 
              
            }
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(); //Calls the Stats class and assigns its object.
            Hide(); //hides current form. 
            stats.Show(); //Shows the Stats form. 
        }
    }

  
}
