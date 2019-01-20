using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Player
    {
        public int health;
        public int StartHealth;  //Starting Health of Player
        public int PlayerDamage1;
        public int PlayerDamage2;
        public int healthRegen;

        public Player()
        {
            health = 600;
            StartHealth = 600;
            PlayerDamage1 = 190;
            PlayerDamage2 = 50;
            healthRegen = 170;
        }

        public int PlayerAttack1(out string Player_Attack1_Info)  //Player's 1st ability.
        {
            Player_Attack1_Info = "You used Divine Power!\nYou dealt" + PlayerDamage1 + " damage to the Enemy!";
            return PlayerDamage1;
        }
        
        public int PlayerAttack2(out string Player_Attack2_Info)  //Player's 2nd ability.
        {
            Player_Attack2_Info = "You used Healing Touch!\nYou dealt " + PlayerDamage2 + " damage to the Enemy!\nYou gained back" + healthRegen + " Health! ";
            health = (health + healthRegen >= StartHealth) ? StartHealth : health + healthRegen; //verification check to ensure player's health does not exceed StartHealth when gaining back health. Also Grants 170 health back to Player.
            return PlayerDamage2;
        }

    }
}
