using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawler__
{
    class Program
    {
        private Character pc;

        private string pClass;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void main(String[] args)
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fCChar());
        }

        public void createChar()
        {
            pc = new Character();
        }

        public void initRaces()
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
         
    }
}

