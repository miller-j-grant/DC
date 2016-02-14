using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    class Character
    {
        /* Every character has the following:
            Name
            Race
                Speed, Languages
            Class
                Proficiencies, Spells
            Ability scores (str, dex, con, intel, wis, cha)
                Hit points, hit dice, proficiency bonus, initiative, passive wisdom
            Background
            Equipment
                AC, attack bonus, packs and packs and packs and packs, $$ALL THAT SICK GP YO$$
        */

        private string name;
        private int level;

        private Race race;

        private int speed;
        private string[] lang;

        private Class pClass;
        private ArrayList prof;
        private ArrayList spells;
        
        // base ability scores for when changing race
        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha 
        private int[] baseAS;

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        private int[] stats;

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        private int[] statmods;
       
        private Background bg = new Background();
        private ArrayList inventory = new ArrayList();
        private Equipment equip = new Equipment();

        //calculated stats
        private int hp;
        private int initiative;
        private int passwis;
        private int profbonus;
        private int ac;
        private int atk;
        private int wealth;


        public Character()
        {
            name = null;
            race = null;
            pClass = null;
            stats = new int[6]{ 0,0,0,0,0,0};
            statmods = new int[6] { 0, 0, 0, 0, 0, 0 };
            bg = null;
            equip = null;
        }

        // setters

        public void setName(String n)
        {
            name = n;
        }

        public void setRace(String r)
        {
            race = new Race(r);
        }

        public void setClass(string c)
        {
            pClass = new Class(c);
        }

        // setters for base ability scores


        // setters for ability scores 
        public void setBaseStats(int[] s)
        {
            // save for later stats.Zip(s, (x, y) => x + y);
            for(int z = 0; z < 5; z++)
            {
                baseAS[z] = s[z];
            }
        }

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha

        public void setBaseStr(int str)
        {
            baseAS[0] = str;
        }

        public void setBaseDex(int dex)
        {
            baseAS[1] = dex;
        }

        public void setBaseCon(int con)
        {
            baseAS[2] = con;
        }

        public void setBaseIntel(int intel)
        {
            baseAS[3] = intel;
        }

        public void setBaseWis(int wis)
        {
            baseAS[4] = wis;
        }

        public void setBaseCha(int cha)
        {
            baseAS[5] = cha;
        }

        // setters for ability scores plus racial bonuses
        public void setStats(int[] s)
        {
            // save for later stats.Zip(s, (x, y) => x + y);
            for (int z = 0; z < 5; z++)
            {
                stats[z] = baseAS[z] + s[z];
            }
        }

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha

        public void setStr(int str)
        {
            stats[0] = baseAS[0] + str;
        }

        public void setDex(int dex)
        {
            stats[1] = baseAS[1] + dex;
        }

        public void setCon(int con)
        {
            stats[2] = baseAS[2] + con;
        }

        public void setIntel(int intel)
        {
            stats[3] = baseAS[3] + intel;
        }

        public void setWis(int wis)
        {
            stats[4] = baseAS[4] + wis;
        }

        public void setCha(int cha)
        {
            stats[5] = baseAS[5] + cha;
        }

        // setters for ability modifiers
        public void setMods(int[] s)
        {
            for (int z = 0; z < 5; z++)
            {
                statmods[z] = s[z];
            }
        }

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha

        public void setStrMod(int str)
        {
            statmods[0] = str;
        }

        public void setDexMod(int dex)
        {
            statmods[1] = dex;
        }

        public void setConMod(int con)
        {
            statmods[2] = con;
        }

        public void setIntelMod(int intel)
        {
            statmods[3] = intel;
        }

        public void setWisMod(int wis)
        {
            statmods[4] = wis;
        }

        public void setChaMod(int cha)
        {
            statmods[5] = cha;
        }

        public void setBG(string background)
        {
            bg = new Background(background);
        }

        public void addEquipment(Equipment eq)
        {
            inventory.Add(eq);
        }
    }
}
