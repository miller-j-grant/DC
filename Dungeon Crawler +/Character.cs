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
            Skills
            Background
            Equipment
                AC, attack bonus, $$ALL THAT SICK GP YO$$
        */

        public string name { get; set; }
        public int level { get; set; }

        public Race race { get; set; }

        public int speed { get; set; }
        public ArrayList language { get; set; }

        public Class pClass { get; set; }
        public ArrayList proficiency { get; set; }
        public ArrayList spellbook { get; set; }

        // base ability scores for when changing race
        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha 
        public int[] baseAS;

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        public int[] stats;

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        public int[] statmods;

        // 0 Acrobatics, 1 Animal Handing, 2 Arcana, 3 Athletics, 4 Deception
        // 5 History, 6 Insight, 7 Intimidation, 8 Investigation, 9 Medicine
        // 10 Nature, 11 Perception, 12 Performance, 13 Persuasion, 14 Religion
        // 15 Sleight of Hand, 16 Stealth, 17 Survival
        public int[] skills;

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        public int[] saves;

        public Background bg { get; set; }

        //calculated stats
        public int hp { get; set; }
        public int initiative { get; set; }
        public int passwis { get; set; }
        public int profbonus { get; set; }
        public int ac { get; set; }
        public int atk { get; set; }
        public int wealth { get; set; }

        //extra details
        public string player { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string age { get; set; }
        public string eye { get; set; }
        public string hair { get; set; }
        public string skin { get; set; }
        public string alignment { get; set; }
        public string backstory { get; set; }


        public Character()
        {
            language = new ArrayList();
            proficiency = new ArrayList();
            spellbook = new ArrayList();
            baseAS = new int[6] { 0, 0, 0, 0, 0, 0 };
            stats = new int[6] { 0, 0, 0, 0, 0, 0 };
            statmods = new int[6] { 0, 0, 0, 0, 0, 0 };
            skills = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            saves = new int[6] { 0, 0, 0, 0, 0, 0 };
        }

        public void setRace(string s)
        {
            race = new Race(s);
        }

        public void setClass(string s)
        {
            pClass = new Class(s);
        }
        public void setBackground(string s)
        {
            bg = new Background(s);
        }

        // setters for base ability scores 
        public void setBaseStats(int[] s)
        {
            // save for later stats.Zip(s, (x, y) => x + y);
            for (int z = 0; z < 5; z++)
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
            for (int z = 0; z < 6; z++)
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

        // setters for calculated values...
        // should the set send values to methods?

        // setters for skills
        public void setSkills(int[] s)
        {
            for (int x = 0; x < 16; x++)
            {
                skills[x] = s[x];
            }
        }

        // 0 Acrobatics, 1 Animal Handing, 2 Arcana, 3 Athletics, 4 Deception
        // 5 History, 6 Insight, 7 Intimidation, 8 Investigation, 9 Medicine
        // 10 Nature, 11 Perception, 12 Performance, 13 Persuasion, 14 Religion
        // 15 Sleight of Hand, 16 Stealth, 17 Survival

        public void setAcrobatics(int a)
        {
            skills[0] = a;
        }

        public void setAnimalHanding(int a)
        {
            skills[1] = a;
        }

        public void setArcana(int a)
        {
            skills[2] = a;
        }

        public void setAthletics(int a)
        {
            skills[3] = a;
        }

        public void setDeception(int d)
        {
            skills[4] = d;
        }

        public void setHistory(int h)
        {
            skills[5] = h;
        }

        public void setInsight(int i)
        {
            skills[6] = i;
        }

        public void setIntimidation(int i)
        {
            skills[7] = i;
        }

        public void setInvestigation(int i)
        {
            skills[8] = i;
        }

        public void setMedicine(int m)
        {
            skills[9] = m;
        }

        public void setNature(int n)
        {
            skills[10] = n;
        }

        public void setPerception(int p)
        {
            skills[11] = p;
        }

        public void setPerformance(int p)
        {
            skills[12] = p;
        }

        public void setPersuasion(int p)
        {
            skills[13] = p;
        }

        public void setReligion(int r)
        {
            skills[14] = r;
        }

        public void setSleightofHand(int s)
        {
            skills[15] = s;
        }

        public void setStealth(int s)
        {
            skills[16] = s;
        }

        public void setSurvival(int s)
        {
            skills[17] = s;
        }

        // setters for ability scores plus racial bonuses
        public void setSaves(int[] s)
        {
            // save for later stats.Zip(s, (x, y) => x + y);
            for (int z = 0; z < 5; z++)
            {
                saves[z] = s[z];
            }
        }

        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha

        public void setStrSave(int str)
        {
            saves[0] = str;
        }

        public void setDexSave(int dex)
        {
            saves[1] = dex;
        }

        public void setConSave(int con)
        {
            saves[2] = con;
        }

        public void setIntelSave(int intel)
        {
            saves[3] = intel;
        }

        public void setWisSave(int wis)
        {
            saves[4] = wis;
        }

        public void setChaSave(int cha)
        {
            saves[5] = cha;
        }

        public void setHP(int health)
        {
            hp = health;
        }

        public void setAC(int armorclass)
        {
            ac = armorclass;
        }

        public void setInitiative(int init)
        {
            initiative = init;
        }

        public void setPassiveWisdom(int pw)
        {
            passwis = pw;
        }

        public void setProfBonus(int pb)
        {
            profbonus = pb;
        }

        // ArrayList adders

        public void addLanguage(string lang)
        {
            language.Add(lang);
        }

        public void addProficiency(string prof)
        {
            proficiency.Add(prof);
        }

        public void addSpell(string spell)
        {
            spellbook.Add(spell);
        }

        //getters

        // get Base Ability Scores
        public int[] getBaseAS()
        {
            return baseAS;
        }

        public int getBaseSTR()
        {
            return baseAS[0];
        }

        public int getBaseDEX()
        {
            return baseAS[1];
        }

        public int getBaseCON()
        {
            return baseAS[2];
        }

        public int getBaseINT()
        {
            return baseAS[3];
        }

        public int getBaseWIS()
        {
            return baseAS[4];
        }

        public int getBaseCHA()
        {
            return baseAS[5];
        }

        // get current ability scores

        public int[] getStats()
        {
            return stats;
        }

        public int getSTR()
        {
            return stats[0];
        }

        public int getDEX()
        {
            return stats[1];
        }

        public int getCON()
        {
            return stats[2];
        }

        public int getINT()
        {
            return stats[3];
        }

        public int getWIS()
        {
            return stats[4];
        }

        public int getCHA()
        {
            return stats[5];
        }

        // get ability score modifiers

        public int[] getStatMod()
        {
            return statmods;
        }

        public int getSTRMod()
        {
            return statmods[0];
        }

        public int getDEXMod()
        {
            return statmods[1];
        }

        public int getCONMod()
        {
            return statmods[2];
        }

        public int getINTMod()
        {
            return statmods[3];
        }

        public int getWISMod()
        {
            return statmods[4];
        }

        public int getCHAMod()
        {
            return statmods[5];
        }

        // get skills

        public int[] getSkills()
        {
            return skills;
        }

        // 0 Acrobatics, 1 Animal Handing, 2 Arcana, 3 Athletics, 4 Deception
        // 5 History, 6 Insight, 7 Intimidation, 8 Investigation, 9 Medicine
        // 10 Nature, 11 Perception, 12 Performance, 13 Persuasion, 14 Religion
        // 15 Sleight of Hand, 16 Stealth, 17 Survival

        public int getAcrobatics()
        {
            return skills[0];
        }

        public int getAnimalHanding()
        {
            return skills[1];
        }

        public int getArcana()
        {
            return skills[2];
        }

        public int getAthletics()
        {
            return skills[3];
        }

        public int getDeception()
        {
            return skills[4];
        }

        public int getHistory()
        {
            return skills[5];
        }

        public int getInsight()
        {
            return skills[6];
        }

        public int getIntimidation()
        {
            return skills[7];
        }

        public int getInvestigation()
        {
            return skills[8];
        }

        public int getMedicine()
        {
            return skills[9];
        }
        
        public int getNature()
        {
           return skills[10];
        }

        public int getPerception()
        {
            return skills[11];
        }

        public int getPerformance()
        {
            return skills[12];
        }

        public int getPersuasion()
        {
            return skills[13];
        }

        public int getReligion()
        {
            return skills[14];
        }

        public int getSleightofHand()
        {
            return skills[15];
        }

        public int getStealth()
        {
            return skills[16];
        }

        public int getSurvival()
        {
            return skills[17];
        }

        // get saves

        public int[] getSaves()
        {
            return saves;
        }

        public int getSTRSave()
        {
            return saves[0];
        }

        public int getDEXSave()
        {
            return saves[1];
        }

        public int getCONSave()
        {
            return saves[2];
        }

        public int getINTSave()
        {
            return saves[3];
        }

        public int getWISSave()
        {
            return saves[4];
        }

        public int getCHASave()
        {
            return saves[5];
        }

    }
}
