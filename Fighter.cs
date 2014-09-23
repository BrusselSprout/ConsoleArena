using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleArena
{
    class Fighter
    {
        string name;
        string classname;
        int strength = 0;
        int energy = 0;
        int speed = 0;
        int skill = 0;
        int moral = 0;
        int level = 0;
        int health = 0;
        int currentHealth = 0;

        public Fighter()
        {

        }

        public Fighter(int str, int erg, int spd, int skl, int mrl, int lvl, int hp)
        {
            strength = str;
            energy = erg;
            speed = spd;
            skill = skl;
            moral = mrl;
            level = lvl;
            health = hp;
            currentHealth = hp;
        }

        public String Stats()
        {
            string stats = "";

            stats += "Strengh: " + strength.ToString() + "\n";
            stats += "Energy: " + energy.ToString() + "\n";
            stats += "Speed: " + speed.ToString() + "\n";
            stats += "Skill: " + skill.ToString() + "\n";
            stats += "Health: " + health.ToString() + " | " + currentHealth.ToString() + "\n";
            stats += "Moral: " + moral.ToString() + "\n";
            stats += "Level: " + level.ToString() + "\n";

            return stats;
        }

        public void Attack(Fighter attacker, Fighter defender)
        {
            //Basic attack. Strengh minus health.
            defender.CurrentHealth -= attacker.Strength;

        }

        public void Defend()
        {


        }


        public int Strength
        {
            set { strength = value; }
            get { return strength; }
        }

        public int Energy
        {
            set { energy = value; }
            get { return energy; }
        }

        public int Speed
        {
            set { speed = value; }
            get { return speed; }
        }

        public int Skill
        {
            set { skill = value; }
            get { return skill; }
        }

        public int Moral
        {
            set { moral = value; }
            get { return moral; }
        }

        public int Health
        {
            set { health = value; }
            get { return health; }
        }

        public int Level
        {
            set { level = value; }
            get { return level; }
        }

        public int CurrentHealth
        {
            set { currentHealth = value; }
            get { return currentHealth;  }
        }








    }
}
