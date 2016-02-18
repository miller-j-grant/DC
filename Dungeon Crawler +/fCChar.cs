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
            if (curItem.Equals("Dwarf"))
            {
                
            }

            if (curItem.Equals("Elf"))
            {

            }

            if (curItem.Equals("Halfling"))
            {

            }

            if (curItem.Equals("Human"))
            {

            }

            if (curItem.Equals("Dragonborn"))
            {

            }

            if (curItem.Equals("Gnome"))
            {

            }

            if (curItem.Equals("Half-Elf"))
            {

            }

            if (curItem.Equals("Half-Orc"))
            {

            }

            if (curItem.Equals("Tiefling"))
            {

            }
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            if (curItem.Equals("Barbarian"))
            {

            }

            if (curItem.Equals("Bard"))
            {

            }

            if (curItem.Equals("Cleric"))
            {

            }

            if (curItem.Equals("Druid"))
            {

            }

            if (curItem.Equals("Fighter"))
            {

            }

            if (curItem.Equals("Monk"))
            {

            }

            if (curItem.Equals("Paladin"))
            {

            }

            if (curItem.Equals("Ranger"))
            {

            }

            if (curItem.Equals("Rogue"))
            {

            }

            if (curItem.Equals("Sorcerer"))
            {

            }

            if (curItem.Equals("Warlock"))
            {

            }

            if (curItem.Equals("Wizard"))
            {

            }
        }

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            if (curItem.Equals("Acolyte"))
            {

            }

            if (curItem.Equals("Charlatan"))
            {

            }

            if (curItem.Equals("Criminal"))
            {

            }

            if (curItem.Equals("Entertainer"))
            {

            }

            if (curItem.Equals("Folk Hero"))
            {

            }

            if (curItem.Equals("Guild Artisan"))
            {

            }

            if (curItem.Equals("Hermit"))
            {

            }

            if (curItem.Equals("Noble"))
            {

            }

            if (curItem.Equals("Outlander"))
            {

            }

            if (curItem.Equals("Sage"))
            {

            }

            if (curItem.Equals("Sailor"))
            {

            }

            if (curItem.Equals("Soldier"))
            {

            }

            if (curItem.Equals("Urchin"))
            {

            }
        }
    }
}
