using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            foreach (string weapon in args)
            {   
                
                switch (weapon)
                {
                    case "":
                        return Weapons.None;
                    case "SilverBullet":
                        return Weapons.SilverBullet;                  
                    case "Garlic":                       
                        return Weapons.Garlic;
                    case "HolyWater":
                        return Weapons.HolyWater;
                }
            }

        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            if (enemy == EnemyType.Vampire)
            {
                if (weapons == Weapons.Garlic || weapons == Weapons.HolyWater)
                {
                    return true;
                }
                else
                    return false;
            }
            if (enemy == EnemyType.Zombie)
            {
                if (weapons == Weapons.SilverBullet)
                {
                    return true;
                }
                else
                    return false;
               
            }
            if (enemy == EnemyType.Werewolf)
            {
               if (weapons == Weapons.SilverBullet)
                {
                    return true;
                }
                else
                    return false;
            }
            if (enemy == EnemyType.Ghost)
            {
               if (weapons == Weapons.HolyWater)
                {
                    return true;
                }
                else
                    return false;
            }

        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            // ////////// //
            // CHANGE ME! //
            // ////////// //
        }
    }
}
