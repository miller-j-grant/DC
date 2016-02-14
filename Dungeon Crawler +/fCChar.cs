using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawler__
{
    public partial class fCChar : Form
    {
        public fCChar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = raceBox.SelectedItem.ToString();

            //Update data and display based on the currently selected item.
            if (curItem == "Dwarf")
            {

            }

            if (curItem == "Elf")
            {

            }

            if (curItem == "Halfling")
            {

            }

            if (curItem == "Human")
            {

            }

            if (curItem == "Dragonborn")
            {

            }

            if (curItem == "Gnome")
            {

            }

            if (curItem == "Half-Elf")
            {

            }

            if (curItem == "Half-Orc")
            {

            }

            if (curItem == "Tiefling")
            {

            }
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            if (curItem == "Barbarian")
            {

            }

            if (curItem == "Bard")
            {

            }

            if (curItem == "Cleric")
            {

            }

            if (curItem == "Druid")
            {

            }

            if (curItem == "Fighter")
            {

            }

            if (curItem == "Monk")
            {

            }

            if (curItem == "Paladin")
            {

            }

            if (curItem == "Ranger")
            {

            }

            if (curItem == "Rogue")
            {

            }

            if (curItem == "Sorcerer")
            {

            }

            if (curItem == "Warlock")
            {

            }

            if (curItem == "Wizard")
            {

            }
        }

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            if (curItem == "Acolyte")
            {

            }

            if (curItem == "Charlatan")
            {

            }

            if (curItem == "Criminal")
            {

            }

            if (curItem == "Entertainer")
            {

            }

            if (curItem == "Folk Hero")
            {

            }

            if (curItem == "Guild Artisan")
            {

            }

            if (curItem == "Hermit")
            {

            }

            if (curItem == "Noble")
            {

            }

            if (curItem == "Outlander")
            {

            }

            if (curItem == "Sage")
            {

            }

            if (curItem == "Sailor")
            {

            }

            if (curItem == "Soldier")
            {

            }

            if (curItem == "Urchin")
            {

            }
        }
    }
}
