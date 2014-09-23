using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleArena
{
    class SwordMan : Fighter
    {
        //Growth Rate. Numbers relate to chance of each stat gaining a point after each level cycle/level-up
        double gro_strength = 0.5;
        double gro_energy = 0.2;
        double gro_speed = 0.8;
        double gro_skill = 0.7;
        //double gro_moral = 0.2;
        //int moral = 20;
        double gro_health = 0.5;
        Random seed = new Random();
        //A Fighter object will ultimately be created based on the growth rate of a swordman class
        Fighter swordman = new Fighter();

        public SwordMan()
        {
            //level 1 Swordman Stats
            Strength = 3;
            Energy = 0;
            Speed = 4;
            Skill = 3;
            Health = 20;
            Moral = 30;
            Level = 1;

        }


        public SwordMan(int level)
        {
            GenerateFighter(level);
        }

        //
        public void GenerateFighter(int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (seed.NextDouble() < gro_strength)
                {
                    Strength++;
                }

                if (seed.NextDouble() < gro_energy)
                {
                    Energy++;
                }
                if (seed.NextDouble() < gro_skill)
                {
                    Skill++;
                }
                if (seed.NextDouble() < gro_speed)
                {
                    Speed++;
                }

                if (seed.NextDouble() < gro_health)
                {
                    Health++;
                }
            }
            Level = level;
            CurrentHealth = Health;

            //return swordman;
        }

    }
}
