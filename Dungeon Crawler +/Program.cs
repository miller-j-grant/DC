﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawler__
{
    class Program
    {
        private string pClass;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            createChar();
            initRaces();
            initClasses();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm());
        }

        public static void createChar()
        {
            Character pc = new Character();
        }

        public static void initRaces()
        {
            Race dwarf = new Race("Dwarf");
            Race elf = new Race("Elf");
            Race halfling = new Race("Halfling");
            Race human = new Race("Human");
            Race dragonborn = new Race("Dragonborn");
            Race gnome = new Race("Gnome");
            Race halfElf = new Race("Half-Elf");
            Race halfOrc = new Race("Half-Orc");
            Race tiefling = new Race("Tiefling");
        }

        public static void initClasses()
        {
            Class barbarian = new Class("Barbarian");
            Class bard = new Class("Bard");
            Class cleric = new Class("Cleric");
            Class druid = new Class("Druid");
            Class fighter = new Class("Fighter");
            Class monk = new Class("Monk");
            Class paladin = new Class("Paladin");
            Class ranger = new Class("Ranger");
            Class rogue = new Class("Rogue");
            Class sorcerer = new Class("Sorcerer");
            Class warlock = new Class("Warlock");
            Class wizard= new Class("Wizard");
        }
         
    }
}

