using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    public class Calculations
    {
        
        // This class is for any and all calculations needed in the program
        // this includes: stat mods, hit points, initiavtive, passive wisdom, 
        // proficiency bonus, armor class, attack bonus, and wealth

        //calculated stats

        private static int hp;
        private static int initiative;
        private static int passwis;
        private static int profbonus;
        private static int ac;
        private static int atk;
        private static int wealth;

        private static int[] mods;

        private static Random r = new Random();
        private static int roll;
        private static int drop;
        private static int abilityscore;

        public static int rollD(int d)
        {
            roll = r.Next(1, d);
            return roll;
        }

        public static int rollAbility()
        {
            drop = 0;
            abilityscore = 0;
            for (int x = 0; x < 3; x++)
            {
                roll = r.Next(1, 6);
                abilityscore = abilityscore + roll;
                if(drop > roll)
                {
                    drop = roll;
                }
            }
            abilityscore = abilityscore - drop;
            return abilityscore;
        }

        public static int[] calcMods(int[] m)
        {
            mods = new int[6];
            for(int x = 0; x < (m.Length-1); x++)
            {
                if(m[x] == 1)
                {
                    mods[x] = -5;
                }

                if (m[x] == 2 || m[x] ==3)
                {
                    mods[x] = -4;
                }

                if (m[x] == 4 || m[x] == 5)
                {
                    mods[x] = -3;
                }

                if (m[x] == 6 || m[x] == 7)
                {
                    mods[x] = -2;
                }

                if (m[x] == 8 || m[x] == 9)
                {
                    mods[x] = -1;
                }

                if (m[x] == 10 || m[x] == 11)
                {
                    mods[x] = 0;
                }

                if (m[x] == 12 || m[x] == 13)
                {
                    mods[x] = 1;
                }

                if (m[x] == 14 || m[x] == 15)
                {
                    mods[x] = 2;
                }

                if (m[x] == 16 || m[x] == 17)
                {
                    mods[x] = 3;
                }

                if (m[x] == 18 || m[x] == 19)
                {
                    mods[x] = 4;
                }

                if (m[x] == 20 || m[x] == 21)
                {
                    mods[x] = 5;
                }

                if (m[x] == 22 || m[x] == 23)
                {
                    mods[x] = 6;
                }

                if (m[x] == 24 || m[x] == 25)
                {
                    mods[x] = 7;
                }

                if (m[x] == 26 || m[x] == 27)
                {
                    mods[x] = 8;
                }

                if (m[x] == 28 || m[x] == 29)
                {
                    mods[x] = 9;
                }

                if (m[x] == 30)
                {
                    mods[x] = 10;
                }
                
            }
            return mods;
        }

        public static int calcHP(int lvl, int conMod, int hd)
        {
            hp = hd + conMod;
            for(int x = 1; x < lvl; x++)
            {
                hp = (hp + r.Next(1, hd) + conMod);
            }
            return hp;
        }

        public static int calcAC(int armor, int dexMod, int extra)
        {
            return (armor + dexMod + extra);
        }

        public static int calcProf(int lvl)
        {
            if (lvl > 4 && lvl < 9)
                return 3;
            if (lvl > 8 && lvl < 13)
                return 4;
            if (lvl > 12 && lvl < 17)
                return 5;
            if (lvl > 16)
                return 6;
            else
                return 2;
        }

        public static int calcPassWis(int wisMod, ArrayList prof, int probonus, int extra) 
        {
            if (prof.Contains("Perception") == true)
                return passwis = (10 + wisMod + probonus + extra);
            else
                return passwis = (10 + wisMod + extra);
        }

        public static int calcInitiative(int dexMod, int extra)
        {
            return dexMod + extra;
        }

        public static int calcWealth(String pClass)
        {
            wealth = 0;
            if(pClass.Equals("Monk"))
            {
                for (int x = 1; x < 5; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return wealth;
            }

            if(pClass.Equals("Druid") || pClass.Equals("Barbarian"))
            {
                for (int x = 1; x < 2; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return (wealth * 10);
            }

            if (pClass.Equals("Sorcerer"))
            {
                for (int x = 1; x < 3; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return (wealth * 10);
            }

            if (pClass.Equals("Rogue") || pClass.Equals("Warlock") || pClass.Equals("Wizard"))
            {
                for (int x = 1; x < 4; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return (wealth * 10);
            }

            else
            {
                for (int x = 1; x < 5; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return (wealth * 10);
            }

        }

    }


}
