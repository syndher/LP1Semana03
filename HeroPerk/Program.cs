﻿using System ;
using HeroPerks;


namespace HeroPerks
{
      
    class Program
    {
           
        static void Main (string[] args)         
        {
            string perks = args[0];
            Perks MyPerks = Perks.NoPerks;

            foreach (char perk in perks)
            {
                switch (perk)
                {
                    case 'w':
                        MyPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        MyPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        MyPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        MyPerks ^= Perks.DoubleJump;
                        break;

                }

            }
            if (MyPerks == Perks.NoPerks)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }

            Console.WriteLine(MyPerks);
            

            if ((MyPerks & Perks.Stealth) != 0 && (MyPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("Silent Jumper!");
            }

             if ((MyPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }



                    
        }

               


            
    }
}