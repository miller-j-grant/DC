using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawler__
{
    class Program
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> DC/Grant

=======
>>>>>>> 76351322e827d5d322d27f43a08038f1861cbf82
        private string pClass;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void main(String[] args)
        {
            createChar();
            initRaces();
            initClasses();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fCChar());
        }

        public static void createChar()
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> DC/Grant
            Character pc = new Character();
        }

        //public Race createRace(string s)
        //{
        //    return new Race(s);
        //}
<<<<<<< HEAD
=======
           Character pc = new Character();
        }

        public static Race createChar(string s)
        {
            return new Race(s);
        }
>>>>>>> 76351322e827d5d322d27f43a08038f1861cbf82
=======
>>>>>>> DC/Grant

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

