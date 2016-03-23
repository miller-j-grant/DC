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
    public partial class fCCSelection : Form
    {
        string uniSelector;
        Character spc = new Character();
        public fCCSelection()
        {
            InitializeComponent();
        }

        private void fCCSelection_Load(object sender, EventArgs e)
        {

        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectLabel_Click(object sender, EventArgs e)
        {

        }

        internal void fCCLoadSelections(string selector, Character pc)
        {
            spc = pc;
            uniSelector = selector;
            if (selector == "Race: Half-Elf")
            {
                selectionListBox.Items.Add("Strength");
                selectionListBox.Items.Add("Dexterity");
                selectionListBox.Items.Add("Constitution");
                selectionListBox.Items.Add("Intelligence");
                selectionListBox.Items.Add("Wisdom");
                selectionListBox.Items.Add("Charisma");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two attributes to add a +1 modifier to.");
            }
            else if (selector == "Race: Dragonborn")
            {
                selectionListBox.Items.Add("Black (Acid)");
                selectionListBox.Items.Add("Blue (Lightning)");
                selectionListBox.Items.Add("Brass (Fire)");
                selectionListBox.Items.Add("Bronze (Lightning)");
                selectionListBox.Items.Add("Copper (Acid)");
                selectionListBox.Items.Add("Gold (Fire)");
                selectionListBox.Items.Add("Green (Poison)");
                selectionListBox.Items.Add("Red (Fire)");
                selectionListBox.Items.Add("Silver (Cold)");
                selectionListBox.Items.Add("White (Cold)");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select one type of Dragon Ancestry.");
            }
            else if (selector == "Class: Barbarian")
            {
                selectionListBox.Items.Add("Animal Handling");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Nature");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Survival");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Bard")
            {
                selectionListBox.Items.Add("Acrobatics");
                selectionListBox.Items.Add("Animal Handling");
                selectionListBox.Items.Add("Arcana");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("Deception");
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Investigation");
                selectionListBox.Items.Add("Medicine");
                selectionListBox.Items.Add("Nature");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Performation");
                selectionListBox.Items.Add("Persuasion");
                selectionListBox.Items.Add("Religion");
                selectionListBox.Items.Add("Slight of Hand");
                selectionListBox.Items.Add("Stealth");
                selectionListBox.Items.Add("Survival");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select three skills to gain proficiency in.");
            }
            else if (selector == "Class: Cleric")
            {
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Medicine");
                selectionListBox.Items.Add("Persuasion");
                selectionListBox.Items.Add("Religion");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Druid")
            {
                selectionListBox.Items.Add("Arcana");
                selectionListBox.Items.Add("Animal Handling");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Medicine");
                selectionListBox.Items.Add("Nature");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Religion");
                selectionListBox.Items.Add("Survival");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Fighter")
            {
                selectionListBox.Items.Add("Acrobatics");
                selectionListBox.Items.Add("Animal Handling");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Survival");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Monk")
            {
                selectionListBox.Items.Add("Acrobatics");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Religion");
                selectionListBox.Items.Add("Stealth");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Paladin")
            {
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Medicine");
                selectionListBox.Items.Add("Persuasion");
                selectionListBox.Items.Add("Religion");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Ranger")
            {
                selectionListBox.Items.Add("Animal Handling");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Investigation");
                selectionListBox.Items.Add("Nature");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Stealth");
                selectionListBox.Items.Add("Survival");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select three skills to gain proficiency in.");
            }
            else if (selector == "Class: Rogue")
            {
                selectionListBox.Items.Add("Acrobatics");
                selectionListBox.Items.Add("Athletics");
                selectionListBox.Items.Add("Deception");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Investigation");
                selectionListBox.Items.Add("Perception");
                selectionListBox.Items.Add("Performance");
                selectionListBox.Items.Add("Persuasion");
                selectionListBox.Items.Add("Sleight of Hand");
                selectionListBox.Items.Add("Stealth");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select four skills to gain proficiency in.");
            }
            else if (selector == "Class: Sorcerer")
            {
                selectionListBox.Items.Add("Arcana");
                selectionListBox.Items.Add("Deception");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Persuasion");
                selectionListBox.Items.Add("Religion");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Warlock")
            {
                selectionListBox.Items.Add("Arcana");
                selectionListBox.Items.Add("Deception");
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Intimidation");
                selectionListBox.Items.Add("Investigation");
                selectionListBox.Items.Add("Nature");
                selectionListBox.Items.Add("Religion");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
            else if (selector == "Class: Wizard")
            {
                selectionListBox.Items.Add("Arcana");
                selectionListBox.Items.Add("History");
                selectionListBox.Items.Add("Insight");
                selectionListBox.Items.Add("Investigation");
                selectionListBox.Items.Add("Medicine");
                selectionListBox.Items.Add("Religion");
                descGrid.ColumnCount = 1;
                descGrid.Columns[0].Name = "Description/Instruction";
                descGrid.Rows.Add("Select two skills to gain proficiency in.");
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectionListBox.SelectedItems.Count; i++)
                spc.addProficiency("" + selectionListBox.SelectedItems[i]);
        }
    }
}
