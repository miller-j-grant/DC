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

        // 0 Acrobatics, 1 Animal Handing, 2 Arcana, 3 Athletics, 4 Deception
        // 5 History, 6 Insight, 7 Intimidation, 8 Investigation, 9 Medicine
        // 10 Nature, 11 Perception, 12 Performance, 13 Persuasion, 14 Religion
        // 15 Sleight of Hand, 16 Stealth, 17 Survival
        private static int[] skills;
        private static int[] saves;

        private static Random r = new Random();
        private static int roll;
        private static int drop;
        private static int abilityscore;

        public static int rollD(int d)
        {
            roll = r.Next(1, (d+1));
            return roll;
        }

        public static int rollAbilityScore()
        {
            drop = 0;
            abilityscore = 0;
            for (int x = 0; x < 3; x++)
            {
                roll = r.Next(1, 7);
                abilityscore = abilityscore + roll;
                if (drop > roll)
                {
                    drop = roll;
                }
            }
            abilityscore = abilityscore - drop;
            return abilityscore;
        }

        public static int[] calcSkills(int[] mod, ArrayList prof, int probonus)
        {
            skills = new int[18];
            for (int x = 0; x < 5; x++)
            {
                switch (x)
                {
                    // Str skill: Athletics
                    case 0:
                        if (prof.Contains("Athletics") == true)
                            skills[3] = (mod[x] + probonus);
                        else
                            skills[3] = mod[x];
                        break;

                    // Dex skills: Abcrobatics, Sleight of Hand, Stealth
                    case 1:
                        if (prof.Contains("Acrobatics") == true)
                            skills[0] = (mod[x] + probonus);
                        else
                            skills[0] = mod[x];

                        if (prof.Contains("Sleight of Hand") == true)
                            skills[15] = (mod[x] + probonus);
                        else
                            skills[15] = mod[x];

                        if (prof.Contains("Stealth") == true)
                            skills[16] = (mod[x] + probonus);
                        else
                            skills[16] = mod[x];
                        break;

                    // no constituion skills 
                    case 2:
                        break;

                    // int skills: Arcana, History, Investigation, Nature, Religion
                    case 3:
                        if (prof.Contains("Arcana") == true)
                            skills[2] = (mod[x] + probonus);
                        else
                            skills[2] = mod[x];

                        if (prof.Contains("History") == true)
                            skills[6] = (mod[x] + probonus);
                        else
                            skills[6] = mod[x];

                        if (prof.Contains("Investigation") == true)
                            skills[8] = (mod[x] + probonus);
                        else
                            skills[8] = mod[x];

                        if (prof.Contains("Nature") == true)
                            skills[10] = (mod[x] + probonus);
                        else
                            skills[10] = mod[x];

                        if (prof.Contains("Religion") == true)
                            skills[14] = (mod[x] + probonus);
                        else
                            skills[14] = mod[x];

                        break;

                    // Wis skills: Animal Handling, Insight, Medicine, Perception, Survival
                    case 4:
                        if (prof.Contains("Animal Handling") == true)
                            skills[1] = (mod[x] + probonus);
                        else
                            skills[1] = mod[x];

                        if (prof.Contains("Insight") == true)
                            skills[6] = (mod[x] + probonus);
                        else
                            skills[6] = mod[x];

                        if (prof.Contains("Medicine") == true)
                            skills[9] = (mod[x] + probonus);
                        else
                            skills[9] = mod[x];

                        if (prof.Contains("Perception") == true)
                            skills[11] = (mod[x] + probonus);
                        else
                            skills[11] = mod[x];

                        if (prof.Contains("Survival") == true)
                            skills[17] = (mod[x] + probonus);
                        else
                            skills[17] = mod[x];

                        break;

                    // Cha skills: Deception, Intimidation, Performance, Persuassion
                    case 5:
                        if (prof.Contains("Deception") == true)
                            skills[4] = (mod[x] + probonus);
                        else
                            skills[4] = mod[x];

                        if (prof.Contains("Intimidation") == true)
                            skills[7] = (mod[x] + probonus);
                        else
                            skills[7] = mod[x];

                        if (prof.Contains("Performance") == true)
                            skills[12] = (mod[x] + probonus);
                        else
                            skills[12] = mod[x];

                        if (prof.Contains("Persuassion") == true)
                            skills[13] = (mod[x] + probonus);
                        else
                            skills[13] = mod[x];

                        break;

                    default:
                        break;
                }
            }
            return skills;
        }

        public static int[] calcSaves(int[] mod, ArrayList prof, int probonus)
        {
            saves = new int[6];
            for (int x = 0; x < 5; x++)
            {
                switch (x)
                {
                    case 0:
                            if (prof.Contains("Strength") == true)
                                saves[x] = (mod[x] + probonus);
                            else
                                saves[x] = mod[x];
                            break;

                    case 1:
                        if (prof.Contains("Dexterity") == true)
                            saves[x] = (mod[x] + probonus);
                        else
                            saves[x] = mod[x];
                        break;

                    case 2:
                        if (prof.Contains("Constitution") == true)
                            saves[x] = (mod[x] + probonus);
                        else
                            saves[x] = mod[x];
                        break;

                    case 3:
                        if (prof.Contains("Wisdom") == true)
                            saves[x] = (mod[x] + probonus);
                        else
                            saves[x] = mod[x];
                        break;

                    case 4:
                        if (prof.Contains("Intelligence") == true)
                            saves[x] = (mod[x] + probonus);
                        else
                            saves[x] = mod[x];
                        break;

                    case 5:
                        if (prof.Contains("Charisma") == true)
                            saves[x] = (mod[x] + probonus);
                        else
                            saves[x] = mod[x];
                        break;

                    default:
                        break;
                }
            }
            return saves;
        }

        public static int calcMod(int m)
        {
            if (m == 1)
            {
                return -5;
            }

            if (m == 2 || m == 3)
            {
                return -4;
            }

            if (m == 4 || m == 5)
            {
                return -3;
            }

            if (m == 6 || m == 7)
            {
                return -2;
            }

            if (m == 8 || m == 9)
            {
                return -1;
            }

            if (m == 10 || m == 11)
            {
                return 0;
            }

            if (m == 12 || m == 13)
            {
                return 1;
            }

            if (m == 14 || m == 15)
            {
                return 2;
            }

            if (m == 16 || m == 17)
            {
                return 3;
            }

            if (m == 18 || m == 19)
            {
                return 4;
            }

            if (m == 20 || m == 21)
            {
                return 5;
            }

            if (m == 22 || m == 23)
            {
                return 6;
            }

            if (m == 24 || m == 25)
            {
                return 7;
            }

            if (m == 26 || m == 27)
            {
                return 8;
            }

            if (m == 28 || m == 29)
            {
                return 9;
            }

            if (m == 30)
            {
                return 10;
            }

            else
            {
                return 0;
            }

        }

        public static int[] calcMods(int[] m)
        {
            mods = new int[6];
            for (int x = 0; x < (m.Length - 1); x++)
            {
                if (m[x] == 1)
                {
                    mods[x] = -5;
                }

                if (m[x] == 2 || m[x] == 3)
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
            for (int x = 1; x < lvl; x++)
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

        public static int calcPassWis(int percep)
        {
            return (10 + percep);
        }

        public static int calcInitiative(int dexMod, int extra)
        {
            return dexMod + extra;
        }

        public static int calcWealth(String pClass)
        {
            wealth = 0;
            if (pClass.Equals("Monk"))
            {
                for (int x = 1; x < 5; x++)
                {
                    wealth = (wealth + r.Next(1, 4));
                }
                return wealth;
            }

            if (pClass.Equals("Druid") || pClass.Equals("Barbarian"))
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

        //addTo calculators

        public static int addToStat(int[] stats, int s, int amount)
        {
            return (stats[s] + amount);
        }

        public static int addToSkill(int[] skills, int s, int amount)
        {
            return (skills[s] + amount);
        }


    }


}
