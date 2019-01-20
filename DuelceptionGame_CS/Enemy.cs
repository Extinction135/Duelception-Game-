using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Enemy
    {
        public int health;
        public int StartHealth;  //Starting Health of Enemy
        public int damage;
        public int healthRegen;

        public Enemy()
        {
            health = 600;
            StartHealth = 600;
            healthRegen = 300;
        }
         
        public int Attack(out string Enemy_Attack_Info)
        {
            int i = 0;
            Enemy_Attack_Info = " ";
            Random random = new Random();
            i = random.Next(1, 101); //Process to select a random number between 1 and 100.
            if (i >=75)  //Enemy has 25% chance of using this ability. Restores 300 health to Enemy. 
            {
                health = (health + healthRegen >= StartHealth) ? StartHealth : health + healthRegen; //verification check to ensure Enemy's health does not exceed StartHealth when gaining back health.
                damage = 0;
                Enemy_Attack_Info = "Enemy used Restore and gained " + healthRegen + " Health!\nYou took " + damage + " damage!";          
            }
            else  //Enemy's second ability. This ability is used 75% of the time.
            {
                damage = random.Next(100, 301); //Enemy attacks for a random damage number between 100 - 300.
                Enemy_Attack_Info = "Enemy used Fire Breath!\nYou took " + damage + " damage!";
            }
            return damage;
        }
    }
}
