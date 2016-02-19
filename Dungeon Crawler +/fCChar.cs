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
                //Set Ability Score Modifier text display for each race.
                asmDisplayLabel.Text = "STR: " + dwarf.getStats[0] + " DEX: " + dwarf.getStats[1] + " CON: " + dwarf.getStats[2] + " INT: " + dwarf.getStats[3] + " WIS: " + dwarf.getStats[4] + " CHA: " + dwarf.getStats[5];

                //Set Size text display for each race.
                sizeDisplayLabel.Text = dwarf.getSize() ;

                //Set Speed text display for each race.
                speedDisplayLabel.Text = dwarf.getSpeed();

                //Add Trait information to the Traits DataGrid.
                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = dwarf.getTrait[0];
                row.Cells["Description"].Value = dwarf.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)traitsGrid.Rows[1].Clone();
                row.Cells["Trait"].Value = dwarf.getTrait[1];
                row.Cells["Description"].Value = dwarf.getTDesc[1];
                traitsGrid.Rows.Add(row);

                //Add Language information to the Language DataGrid.
                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = dwarf.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Elf"))
            {
                asmDisplayLabel.Text = "STR: " + elf.getStats[0] + " DEX: " + elf.getStats[1] + " CON: " + elf.getStats[2] + " INT: " + elf.getStats[3] + " WIS: " + elf.getStats[4] + " CHA: " + elf.getStats[5];

                sizeDisplayLabel.Text = elf.getSize();

                speedDisplayLabel.Text = elf.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = elf.getTrait[0];
                row.Cells["Description"].Value = elf.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = elf.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Halfling"))
            {
                asmDisplayLabel.Text = "STR: " + halfling.getStats[0] + " DEX: " + halfling.getStats[1] + " CON: " + halfling.getStats[2] + " INT: " + halfling.getStats[3] + " WIS: " + halfling.getStats[4] + " CHA: " + halfling.getStats[5];

                sizeDisplayLabel.Text = halfling.getSize();

                speedDisplayLabel.Text = halfling.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = halfling.getTrait[0];
                row.Cells["Description"].Value = halfling.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = halfling.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Human"))
            {
                asmDisplayLabel.Text = "STR: " + human.getStats[0] + " DEX: " + human.getStats[1] + " CON: " + human.getStats[2] + " INT: " + human.getStats[3] + " WIS: " + human.getStats[4] + " CHA: " + human.getStats[5];

                sizeDisplayLabel.Text = human.getSize();

                speedDisplayLabel.Text = human.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = human.getTrait[0];
                row.Cells["Description"].Value = human.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = human.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Dragonborn"))
            {
                asmDisplayLabel.Text = "STR: " + dragonborn.getStats[0] + " DEX: " + dragonborn.getStats[1] + " CON: " + dragonborn.getStats[2] + " INT: " + dragonborn.getStats[3] + " WIS: " + dragonborn.getStats[4] + " CHA: " + dragonborn.getStats[5];

                sizeDisplayLabel.Text = dragonborn.getSize();

                speedDisplayLabel.Text = dragonborn.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = dragonborn.getTrait[0];
                row.Cells["Description"].Value = dragonborn.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = dragonborn.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Gnome"))
            {
                asmDisplayLabel.Text = "STR: " + gnome.getStats[0] + " DEX: " + gnome.getStats[1] + " CON: " + gnome.getStats[2] + " INT: " + gnome.getStats[3] + " WIS: " + gnome.getStats[4] + " CHA: " + gnome.getStats[5];

                sizeDisplayLabel.Text = gnome.getSize();

                speedDisplayLabel.Text = gnome.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = gnome.getTrait[0];
                row.Cells["Description"].Value = gnome.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = gnome.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Half-Elf"))
            {
                asmDisplayLabel.Text = "STR: " + halfElf.getStats[0] + " DEX: " + halfElf.getStats[1] + " CON: " + halfElf.getStats[2] + " INT: " + halfElf.getStats[3] + " WIS: " + halfElf.getStats[4] + " CHA: " + halfElf.getStats[5];

                sizeDisplayLabel.Text = halfElf.getSize();

                speedDisplayLabel.Text = halfElf.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = halfElf.getTrait[0];
                row.Cells["Description"].Value = halfElf.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = halfElf.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Half-Orc"))
            {
                asmDisplayLabel.Text = "STR: " + halfOrc.getStats[0] + " DEX: " + halfOrc.getStats[1] + " CON: " + halfOrc.getStats[2] + " INT: " + halfOrc.getStats[3] + " WIS: " + halfOrc.getStats[4] + " CHA: " + halfOrc.getStats[5];

                sizeDisplayLabel.Text = halfOrc.getSize();

                speedDisplayLabel.Text = halfOrc.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = halfOrc.getTrait[0];
                row.Cells["Description"].Value = halfOrc.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = halfOrc.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }

            if (curItem.Equals("Tiefling"))
            {
                asmDisplayLabel.Text = "STR: " + tiefling.getStats[0] + " DEX: " + tiefling.getStats[1] + " CON: " + tiefling.getStats[2] + " INT: " + tiefling.getStats[3] + " WIS: " + tiefling.getStats[4] + " CHA: " + tiefling.getStats[5];

                sizeDisplayLabel.Text = tiefling.getSize();

                speedDisplayLabel.Text = tiefling.getSpeed();

                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();
                row.Cells["Trait"].Value = tiefling.getTrait[0];
                row.Cells["Description"].Value = tiefling.getTDesc[0];
                traitsGrid.Rows.Add(row);

                row = (DataGridViewRow)languagesGrid.Rows[0].Clone();
                row.Cells["Languages"].Value = tiefling.getLanguage[0];
                languagesGrid.Rows.Add(row);
            }
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            if (curItem.Equals("Barbarian"))
            {
                //Algorithm to clear the tables on IndexChanged IMPLEMENT.

                //Set the columns for the Leveling Table DataGrid.
                levelingGrid.Columns.Add("level","Level");
                levelingGrid.Columns.Add("proficiency","Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("rages", "Rages");
                levelingGrid.Columns.Add("damage", "Rage Damage");


            }

            if (curItem.Equals("Bard"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("cantrips","Cantrips Known");
                levelingGrid.Columns.Add("spells", "Spells Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
                levelingGrid.Columns.Add("sixth", "6th");
                levelingGrid.Columns.Add("seventh", "7th");
                levelingGrid.Columns.Add("eighth", "8th");
                levelingGrid.Columns.Add("nineth", "9th");
            }

            if (curItem.Equals("Cleric"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("cantrips", "Cantrips Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
                levelingGrid.Columns.Add("sixth", "6th");
                levelingGrid.Columns.Add("seventh", "7th");
                levelingGrid.Columns.Add("eighth", "8th");
                levelingGrid.Columns.Add("nineth", "9th");
            }

            if (curItem.Equals("Druid"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("cantrips", "Cantrips Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
                levelingGrid.Columns.Add("sixth", "6th");
                levelingGrid.Columns.Add("seventh", "7th");
                levelingGrid.Columns.Add("eighth", "8th");
                levelingGrid.Columns.Add("nineth", "9th");
            }

            if (curItem.Equals("Fighter"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
            }

            if (curItem.Equals("Monk"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("martial","Martial Arts");
                levelingGrid.Columns.Add("ki","Ki Points");
                levelingGrid.Columns.Add("unarmored","Unarmored Movement");
            }

            if (curItem.Equals("Paladin"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
            }

            if (curItem.Equals("Ranger"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("spells", "Spells Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
            }

            if (curItem.Equals("Rogue"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("sneak","Sneak Attack");
            }

            if (curItem.Equals("Sorcerer"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("sorcery","Sorcery Points");
                levelingGrid.Columns.Add("cantrips", "Cantrips Known");
                levelingGrid.Columns.Add("spells", "Spells Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
                levelingGrid.Columns.Add("sixth", "6th");
                levelingGrid.Columns.Add("seventh", "7th");
                levelingGrid.Columns.Add("eighth", "8th");
                levelingGrid.Columns.Add("nineth", "9th");
            }

            if (curItem.Equals("Warlock"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("cantrips", "Cantrips Known");
                levelingGrid.Columns.Add("spells", "Spells Known");
                levelingGrid.Columns.Add("slots","Spell Slots");
                levelingGrid.Columns.Add("slotLevel","Slot Level");
                levelingGrid.Columns.Add("invocations","Invocations Known");
            }

            if (curItem.Equals("Wizard"))
            {
                levelingGrid.Columns.Add("level", "Level");
                levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
                levelingGrid.Columns.Add("features", "Features");
                levelingGrid.Columns.Add("cantrips", "Cantrips Known");
                levelingGrid.Columns.Add("spells", "Spells Known");
                levelingGrid.Columns.Add("first", "1st");
                levelingGrid.Columns.Add("second", "2nd");
                levelingGrid.Columns.Add("third", "3rd");
                levelingGrid.Columns.Add("fourth", "4th");
                levelingGrid.Columns.Add("fifth", "5th");
                levelingGrid.Columns.Add("sixth", "6th");
                levelingGrid.Columns.Add("seventh", "7th");
                levelingGrid.Columns.Add("eighth", "8th");
                levelingGrid.Columns.Add("nineth", "9th");
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
