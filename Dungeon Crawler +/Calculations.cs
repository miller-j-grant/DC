using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    /// <summary>
    /// This class is for any and all calculations needed in the program. 
    /// this includes: stat mods, hit points, initiavtive, passive wisdom,
    /// proficiency bonus, armor class, attack bonus, and wealth. </summary>
    /// <remarks>
    /// author: Patrick Dishaw, Grant Miller, Mitch Couturier
    /// version: 2/22/2016 </remarks>
    public class Calculations
    {
        //calculated stats
        /// <summary> Health Points of a character </summary>
        private static int hp;
        /// <summary> Initiative of a character </summary>
        private static int initiative;
        /// <summary> Passive Wisdom of a character </summary>
        private static int passwis;
        /// <summary> Proficiency Bonus of a character </summary>
        private static int profbonus;
        /// <summary> Armor Class of a character </summary>
        private static int ac;
        /// <summary> Attack of a character </summary>
        private static int atk;
        /// <summary> Wealth of a character </summary>
        private static int wealth;
        /// <summary> Array of mods for a character </summary>
        private static int[] mods;
        /// <summary> Skills of a character. 
        /// {0 Acrobatics, 1 Animal Handing, 2 Arcana, 3 Athletics, 4 Deception, 
        /// 5 History, 6 Insight, 7 Intimidation, 8 Investigation, 9 Medicine, 
        /// 10 Nature, 11 Perception, 12 Performance, 13 Persuasion, 14 Religion, 
        /// 15 Sleight of Hand, 16 Stealth, 17 Survival. </summary>
        private static int[] skills;
        /// <summary> Array of saves of a character </summary>
        private static int[] saves;
        /// <summary> used to generate a random number </summary>
        private static Random r = new Random();
        /// <summary> represents a random number simulating a roll of die </summary>
        private static int roll;
        /// <summary>  </summary>
        private static int drop;
        /// <summary> Ability Score </summary>
        private static int abilityscore;
        /// <summary> Point Buy Strength </summary>
        private static int[] pbSTR = new int[2];
        /// <summary> Point Buy Constitution </summary>
        private static int[] pbCON = new int[2];
        /// <summary> Point Buy Dexterity </summary>
        private static int[] pbDEX = new int[2];
        /// <summary> Point Buy Intelligence </summary>
        private static int[] pbINT = new int[2];
        /// <summary> Point Buy Wisdom </summary>
        private static int[] pbWIS = new int[2];
        /// <summary> Point Buy Charisma </summary>
        private static int[] pbCHA = new int[2];

        /// <summary>
        /// Rolls a random number between 1 and d and sets the number to roll </summary>
        /// <param name="d"> The limit of the roll </param>
        public static int rollD(int d)
        {
            roll = r.Next(1, (d + 1));
            return roll;
        }

        /// <summary>
        /// Rolls a randomized number for the ability score </summary>
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

        /// <summary>
        /// Calculates skills of a character, based on parameters </summary>
        /// <param name="mod"> Contains mods of a character </param>
        /// <param name="prof"> Contains proficiencies of a character </param>
        /// <param name="profbonus"> Contains proficiency bonus of a character </param>
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

        /// <summary>
        /// Calculates saves of a character, based on parameters </summary>
        /// <param name="mod"> Contains mods of a character </param>
        /// <param name="prof"> Contains proficiencies of a character </param>
        /// <param name="profbonus"> Contains proficiency bonus of a character </param>
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

        /// <summary>
        /// Calculates mod </summary>
        /// <param name="m"> mod being calculated </param>
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

        /// <summary>
        /// Calculates array of mods </summary>
        /// <param name="m"> array of mods being calculated </param>
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

        /// <summary>
        /// Calculates Health Points of a character, based on parameters </summary>
        /// <param name="lvl"> Level of a character </param>
        /// <param name="conMod"> Constitution Modifier of a character </param>
        /// <param name="hd"> Hit Dice of a character </param>
        public static int calcHP(int lvl, int conMod, int hd)
        {
            hp = hd + conMod;
            for (int x = 1; x < lvl; x++)
            {
                hp = (hp + r.Next(1, hd) + conMod);
            }
            return hp;
        }

        /// <summary>
        /// Calculates Armor Class of a character, based on parameters </summary>
        /// <param name="armor"> Armor level of a character </param>
        /// <param name="dexMod"> Dexterity Modifier of a character </param>
        /// <param name="shield"> 2 if wearing a shield, 0 if not </param>
        public static int calcAC(int armor, int dexMod, int shield)
        {
            if (armor == 16)
            {
                return (armor + 0 + shield);
            }

            if (armor == 14 && dexMod > 2)
            {
                return (armor + 2 + shield);
            }

            if (armor == 14 && dexMod < 3)
            {
                return (armor + dexMod + shield);
            }

            else
            {
                return (armor + dexMod + shield);
            }

        }

        /// <summary>
        /// Calculates Proficiency of a character </summary>
        /// <param name="lvl"> Level of a character </param>
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

        /// <summary>
        /// Calculates Passive Wisdom of a character </summary>
        /// <param name="percep"> Perception of a character </param>
        public static int calcPassWis(int percep)
        {
            return (10 + percep);
        }

        /// <summary>
        /// Calculates Initiative of a character, based on parameters </summary>
        /// <param name="dexMod"> Dexterity Modifier of a character </param>
        /// <param name="extra"> extra of a character </param>
        public static int calcInitiative(int dexMod, int extra)
        {
            return dexMod + extra;
        }

        /// <summary>
        /// Calculates Wealth of a character </summary>
        /// <param name="pClass"> String representation of a character's Class </param>
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

        //======addTo calculators======

        /// <summary>
        /// Adds a specified value to a character stat </summary>
        /// <param name="stats"> array of stats of a character </param>
        /// <param name="s"> index of the stat of interest in the stats array</param>
        /// <param name="amount"> amount to be added to the stat </param>
        public static int addToStat(int[] stats, int s, int amount)
        {
            return (stats[s] + amount);
        }

        /// <summary>
        /// Adds a specified value to a character skill </summary>
        /// <param name="skills"> array of skills of a character </param>
        /// <param name="s"> index of the stat of interest in the skills array</param>
        /// <param name="amount"> amount to be added to the skill </param>
        public static int addToSkill(int[] skills, int s, int amount)
        {
            return (skills[s] + amount);
        }

        /// <summary>
        /// Computes to Point Buy Cost depending on the attribute </summary>
        /// <param name="attribute"> attribute that determines point buy cost </param>
        public static int pointBuyCost(decimal attribute)
        {
            int cost = 0;
            if (attribute == 8)
                cost = 0;
            else if (attribute == 9)
                cost = 1;
            else if (attribute == 10)
                cost = 2;
            else if (attribute == 11)
                cost = 3;
            else if (attribute == 12)
                cost = 4;
            else if (attribute == 13)
                cost = 5;
            else if (attribute == 14)
                cost = 7;
            else if (attribute == 15)
                cost = 9;
            return cost;
        }

        /// <summary>
        /// Calulates the point buy points after updating a specified attribute </summary>
        /// <param name="points"> current point buy points </param>
        /// <param name="newValue"> newValue for the specified attribute </param>
        /// <param name="name"> name of the specific value (Str, Con, Dex, Int, Wis, Cha) </param>
        public static int pointBuyPoints(int points, decimal newValue, string name)
        {
            if (name == "str")
            {
                if (pbSTR[0].Equals(null))
                {
                    pbSTR[0] = 8;
                    pbSTR[1] = 8;
                }
                pbSTR[0] = pbSTR[1];
                pbSTR[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbSTR[0]) - pointBuyCost(pbSTR[1]);
            }
            else if (name == "con")
            {
                if (pbCON[0].Equals(null))
                {
                    pbCON[0] = 8;
                    pbCON[1] = 8;
                }
                pbCON[0] = pbCON[1];
                pbCON[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbCON[0]) - pointBuyCost(pbCON[1]);
            }
            else if (name == "dex")
            {
                if (pbDEX[0].Equals(null))
                {
                    pbDEX[0] = 8;
                    pbDEX[1] = 8;
                }
                pbDEX[0] = pbDEX[1];
                pbDEX[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbDEX[0]) - pointBuyCost(pbDEX[1]);
            }
            else if (name == "int")
            {
                if (pbINT[0].Equals(null))
                {
                    pbINT[0] = 8;
                    pbINT[1] = 8;
                }
                pbINT[0] = pbINT[1];
                pbINT[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbINT[0]) - pointBuyCost(pbINT[1]);
            }
            else if (name == "wis")
            {
                if (pbWIS[0].Equals(null))
                {
                    pbWIS[0] = 8;
                    pbWIS[1] = 8;
                }
                pbWIS[0] = pbWIS[1];
                pbWIS[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbWIS[0]) - pointBuyCost(pbWIS[1]);
            }
            else
            {
                if (pbCHA[0].Equals(null))
                {
                    pbCHA[0] = 8;
                    pbCHA[1] = 8;
                }
                pbCHA[0] = pbCHA[1];
                pbCHA[1] = Convert.ToInt32(newValue);
                return points + pointBuyCost(pbCHA[0]) - pointBuyCost(pbCHA[1]);
            }
        }

        public static string randomRace()
        {
            string race;
            int roll = rollD(8);
            switch (roll)
            {
                case 1:
                    race = "Dwarf";
                    break;
                case 2:
                    race = "Elf";
                    break;
                case 3:
                    race = "Halfing";
                    break;
                case 4:
                    race = "Human";
                    break;
                case 5:
                    race = "Dragonborn";
                    break;
                case 6:
                    race = "Gnome";
                    break;
                case 7:
                    race = "Half-Elf";
                    break;
                case 8:
                    race = "Half-Orc";
                    break;
                case 9:
                    race = "Tiefling";
                    break;
                default:
                    race = "";
                    break;
            }
            return race;
        }

        public static string randomClass()
        {
            string rclass;
            int roll = rollD(12);
            switch (roll)
            {
                case 1:
                    rclass = "Barbarian";
                    break;
                case 2:
                    rclass = "Bard";
                    break;
                case 3:
                    rclass = "Cleric";
                    break;
                case 4:
                    rclass = "Druid";
                    break;
                case 5:
                    rclass = "Fighter";
                    break;
                case 6:
                    rclass = "Monk";
                    break;
                case 7:
                    rclass = "Paladin";
                    break;
                case 8:
                    rclass = "Ranger";
                    break;
                case 9:
                    rclass = "Rogue";
                    break;
                case 10:
                    rclass = "Sorcerer";
                    break;
                case 11:
                    rclass = "Warlock";
                    break;
                case 12:
                    rclass = "Wizard";
                    break;
                default:
                    rclass = "";
                    break;
            }
            return rclass;
        }

        public static string randomBackground()
        {
            string background;
            int roll = rollD(13);
            switch (roll)
            {
                case 1:
                    background = "Acolyte";
                    break;
                case 2:
                    background = "Charlatan";
                    break;
                case 3:
                    background = "Criminal";
                    break;
                case 4:
                    background = "Entertainer";
                    break;
                case 5:
                    background = "Folk Hero";
                    break;
                case 6:
                    background = "Guild Artisan";
                    break;
                case 7:
                    background = "Hermit";
                    break;
                case 8:
                    background = "Noble";
                    break;
                case 9:
                    background = "Outlander";
                    break;
                case 10:
                    background = "Sage";
                    break;
                case 11:
                    background = "Sailor";
                    break;
                case 12:
                    background = "Soldier";
                    break;
                case 13:
                    background = "Urchin";
                    break;
                default:
                    background = "";
                    break;
            }
            return background;
        }

        public static string randomName()
        {
            string[] names = new string[11] { "", "Maverick Witchvictor", "Talon Floraivy", "Aeon Griffon", "Raven Honor", "Magus Legend",
                "Lord Beastlady", "Seraphim Dawn", "King Queen", "Spirit Paradox", "Ragnarok Eternitydread"};
            return names[rollD(10)];
        }

    }
}

