using System;
using System.Collections;
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
        Race selectRace;
        Class selectClass;
        Background selectBack;
        Character pc = new Character();
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

            //Call to create a new Race object, same name as currently selected item.
            Race selectRace = new Race(curItem);

            //Set Ability Score Modifier text display for each race.
            asmDisplayLabel.Text = "STR: " + selectRace.getStats()[0] + "   DEX: " + selectRace.getStats()[1] + "\nCON: " + selectRace.getStats()[2] +
            "   INT: " + selectRace.getStats()[3] + "\nWIS: " + selectRace.getStats()[4] + "    CHA: " + selectRace.getStats()[5];

            //Set Size text display for each race.
            sizeDisplayLabel.Text = selectRace.getSize();

            //Set Speed text display for each race.
            speedDisplayLabel.Text = selectRace.getSpeed().ToString();

            //Clear the Trait DataGrid of all columns and rows.
            traitsGrid.Columns.Clear();
            traitsGrid.Rows.Clear();

            //Add Trait information to the Traits DataGrid based on the amount of racial traits each race has.
            DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();

            //  ArrayList trait = new ArrayList();
            //  trait = selectRace.getTraits();
            //  ArrayList tDesc = new ArrayList();
            ////  tDesc = selectRace.getTDesc();
            //  ArrayList lang = new ArrayList();
            //  lang = selectRace.getLanguages();


            //  for (int i = 0; i <= trait.Count; i++)
            //  {
            //      row = (DataGridViewRow)traitsGrid.Rows[i].Clone();
            //      row.Cells["Trait"].Value = trait[i];
            //      row.Cells["Description"].Value = tDesc[i];
            //      traitsGrid.Rows.Add(row);
            //  }

            //Clear the Language DataGrid of all columns and rows.
            //    languagesGrid.Columns.Clear();
            //    languagesGrid.Rows.Clear();

            //Add Language information to the Language DataGrid.
            for (int j = 0; j <= selectRace.getLanguages().Count; j++)
            {
                row = (DataGridViewRow)languagesGrid.Rows[j].Clone();
                row.Cells["Languages"].Value = selectRace.getLanguages()[j];
                languagesGrid.Rows.Add(row);
            }

            ////Add Language information to the Language DataGrid.
            //for (int j = 0; j <= lang.Count; j++)
            //{
            //    row = (DataGridViewRow)languagesGrid.Rows[j].Clone();
            //    row.Cells["Languages"].Value = lang[j];
            //    languagesGrid.Rows.Add(row);
            //}
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            Class selectClass = new Class(curItem);

            //if (curItem.Equals("Barbarian"))
            //{
                //Clear the Features DataGrid of all columns and rows.
                featuresGrid.Columns.Clear();
                featuresGrid.Rows.Clear();

                //Set the columns for the Features DataGrid.
                featuresGrid.Columns.Add("name","Name");
                featuresGrid.Columns.Add("desc","Description");

            DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
            row.Cells["name"].Value = "Hit Dice: ";
            row.Cells["desc"].Value = "1d" + selectClass.hit + " per " + selectClass.className + " level";

            featuresGrid.Rows.Add(row);

            ArrayList prof = new ArrayList();
            prof = selectClass.prof;
            ArrayList pDesc = new ArrayList();
          //  pDesc = selectClass.getPDesc();

            for (int i = 1; i <= prof.Count; i++)
            {
                row = (DataGridViewRow)featuresGrid.Rows[i].Clone();
                row.Cells["name"].Value = prof[i];
                row.Cells["desc"].Value = pDesc[i];
                featuresGrid.Rows.Add(row);
            }
                //Set the rows for the Features DataGrid.
               


                //Clear the Leveling Table DataGrid of all columns and rows.
                levelingGrid.Columns.Clear();
                levelingGrid.Rows.Clear();


            ArrayList col = new ArrayList();
            col = selectClass.getLCol();
            ArrayList rows = new ArrayList();
            rows = selectClass.getRows();
            ArrayList vRows = new ArrayList();

            //ArrayList col = new ArrayList();
            //col = selectClass.getCol();


            //for (int j = 0; j <= ; j++)
            //{
            //    levelingGrid.Columns.Add(""+j,col[j]);
            //}

            //Set the columns for the Leveling Table DataGrid.
            //levelingGrid.Columns.Add("level","Level");
            //levelingGrid.Columns.Add("proficiency","Proficiency Bonus");
            //levelingGrid.Columns.Add("features", "Features");
            //levelingGrid.Columns.Add("rages", "Rages");
            //levelingGrid.Columns.Add("damage", "Rage Damage");

<<<<<<< HEAD
            for (int z = 0; z <= rows.Count; z++)
            {
                vRows = selectClass.getVRows(z);
                row = (DataGridViewRow)levelingGrid.Rows[z].Clone();
                for (int y = 0; y <= col.Count; y++)
                {
                    row.Cells[col[y]].Value = vRows[y];
                }
            }
        }
=======
            //THINK THIS OVER, NEED TO FILL THE LEVELING GRID WITH ROWS VALUES BASED ON THE COLUMNS.
            //for (int z = 0; z <= ; z++)
            //{
            //    row = (DataGridViewRow)levelingGrid.Rows[z].Clone();
            //    for (int y = 0; y <= col.Count; y++)
            //    {
            //        row.Cells[col[y]].Value = ;
            //    }
            //}

                //Set the rows for the Leveling Table DataGrid.
                row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
                row.Cells["level"].Value = 1;
                row.Cells["proficiency"].Value = 2;
                row.Cells["features"].Value = "Rage, Unarmored Defense";
                row.Cells["rages"].Value = 2;
                row.Cells["damage"].Value = 2;
                levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[1].Clone();
                //row.Cells["level"].Value = 2;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Reckless Attack, Danger Sense";
                //row.Cells["rages"].Value = 2;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[2].Clone();
                //row.Cells["level"].Value = 3;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Primal Path";
                //row.Cells["rages"].Value = 3;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[3].Clone();
                //row.Cells["level"].Value = 4;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["rages"].Value = 3;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[4].Clone();
                //row.Cells["level"].Value = 5;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Extra Attack, Fast Movement";
                //row.Cells["rages"].Value = 3;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[5].Clone();
                //row.Cells["level"].Value = 6;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Path Feature";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[6].Clone();
                //row.Cells["level"].Value = 7;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Feral Instinct";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[7].Clone();
                //row.Cells["level"].Value = 8;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[8].Clone();
                //row.Cells["level"].Value = 9;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Brutal Critical (1 die)";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[9].Clone();
                //row.Cells["level"].Value = 10;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Path Feature";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[10].Clone();
                //row.Cells["level"].Value = 11;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Relentless Rage";
                //row.Cells["rages"].Value = 4;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[11].Clone();
                //row.Cells["level"].Value = 12;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["rages"].Value = 5;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[12].Clone();
                //row.Cells["level"].Value = 13;
                //row.Cells["proficiency"].Value = 5;
                //row.Cells["features"].Value = "Brutal Critical (2 dice)";
                //row.Cells["rages"].Value = 5;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[13].Clone();
                //row.Cells["level"].Value = 14;
                //row.Cells["proficiency"].Value = 5;
                //row.Cells["features"].Value = "Path Feature";
                //row.Cells["rages"].Value = 5;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[14].Clone();
                //row.Cells["level"].Value = 15;
                //row.Cells["proficiency"].Value = 5;
                //row.Cells["features"].Value = "Persistent Rage";
                //row.Cells["rages"].Value = 5;
                //row.Cells["damage"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[15].Clone();
                //row.Cells["level"].Value = 16;
                //row.Cells["proficiency"].Value = 5;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["rages"].Value = 5;
                //row.Cells["damage"].Value = 4;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[16].Clone();
                //row.Cells["level"].Value = 17;
                //row.Cells["proficiency"].Value = 6;
                //row.Cells["features"].Value = "Brutal Critical (3 dice)";
                //row.Cells["rages"].Value = 6;
                //row.Cells["damage"].Value = 4;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[17].Clone();
                //row.Cells["level"].Value = 18;
                //row.Cells["proficiency"].Value = 6;
                //row.Cells["features"].Value = "Indomitable Might";
                //row.Cells["rages"].Value = 6;
                //row.Cells["damage"].Value = 4;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[18].Clone();
                //row.Cells["level"].Value = 19;
                //row.Cells["proficiency"].Value = 6;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["rages"].Value = 6;
                //row.Cells["damage"].Value = 4;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[19].Clone();
                //row.Cells["level"].Value = 20;
                //row.Cells["proficiency"].Value = 6;
                //row.Cells["features"].Value = "Primal Champion";
                //row.Cells["rages"].Value = "Unlimited";
                //row.Cells["damage"].Value = 4;
                //levelingGrid.Rows.Add(row);
            }

            //if (curItem.Equals("Bard"))
            //{
            //    featuresGrid.Columns.Clear();
            //    featuresGrid.Rows.Clear();

            //    featuresGrid.Columns.Add("name", "Name");
            //    featuresGrid.Columns.Add("desc", "Description");

            //    DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
            //    row.Cells["name"].Value = "Hit Dice: ";
            //    row.Cells["desc"].Value = "1d8 per Bard level";
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
            //    row.Cells["name"].Value = bard.getProf[0];
            //    row.Cells["desc"].Value = bard.getDProf[0];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
            //    row.Cells["name"].Value = bard.getProf[1];
            //    row.Cells["desc"].Value = bard.getDProf[1];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
            //    row.Cells["name"].Value = bard.getProf[2];
            //    row.Cells["desc"].Value = bard.getDProf[2];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
            //    row.Cells["name"].Value = bard.getProf[3];
            //    row.Cells["desc"].Value = bard.getDProf[3];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
            //    row.Cells["name"].Value = bard.getProf[4];
            //    row.Cells["desc"].Value = bard.getDProf[4];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
            //    row.Cells["name"].Value = bard.getProf[5];
            //    row.Cells["desc"].Value = bard.getDProf[5];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
            //    row.Cells["name"].Value = bard.getProf[6];
            //    row.Cells["desc"].Value = bard.getDProf[6];
            //    featuresGrid.Rows.Add(row);

            //    row = (DataGridViewRow)featuresGrid.Rows[8].Clone();
            //    row.Cells["name"].Value = bard.getProf[7];
            //    row.Cells["desc"].Value = bard.getDProf[7];
            //    featuresGrid.Rows.Add(row);

            //    levelingGrid.Columns.Clear();
            //    levelingGrid.Rows.Clear();

            //    levelingGrid.Columns.Add("level", "Level");
            //    levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
            //    levelingGrid.Columns.Add("features", "Features");
            //    levelingGrid.Columns.Add("cantrips","Cantrips Known");
            //    levelingGrid.Columns.Add("spells", "Spells Known");
            //    levelingGrid.Columns.Add("first", "1st");
            //    levelingGrid.Columns.Add("second", "2nd");
            //    levelingGrid.Columns.Add("third", "3rd");
            //    levelingGrid.Columns.Add("fourth", "4th");
            //    levelingGrid.Columns.Add("fifth", "5th");
            //    levelingGrid.Columns.Add("sixth", "6th");
            //    levelingGrid.Columns.Add("seventh", "7th");
            //    levelingGrid.Columns.Add("eighth", "8th");
            //    levelingGrid.Columns.Add("nineth", "9th");

            //    row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
            //    row.Cells["level"].Value = 1;
            //    row.Cells["proficiency"].Value = 2;
            //    row.Cells["features"].Value = "Spellcasting, Bardic Inspiration (d6)";
            //    row.Cells["cantrips"].Value = 2;
            //    row.Cells["spells"].Value = 4;
            //    row.Cells["first"].Value = 2;
            //    levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[1].Clone();
                //row.Cells["level"].Value = 2;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Jack of All Trades, Song of Rest (d6)";
                //row.Cells["cantrips"].Value = 2;
                //row.Cells["spells"].Value = 5;
                //row.Cells["first"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[2].Clone();
                //row.Cells["level"].Value = 3;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Bard College, Expertise";
                //row.Cells["cantrips"].Value = 2;
                //row.Cells["spells"].Value = 6;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[3].Clone();
                //row.Cells["level"].Value = 4;
                //row.Cells["proficiency"].Value = 2;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 7;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[4].Clone();
                //row.Cells["level"].Value = 5;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Bardic Inspiration (d8), Font of Inspiration";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 8;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[5].Clone();
                //row.Cells["level"].Value = 6;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Countercharm, Bard College Feature";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 9;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[6].Clone();
                //row.Cells["level"].Value = 7;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "---";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 10;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 1;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[7].Clone();
                //row.Cells["level"].Value = 8;
                //row.Cells["proficiency"].Value = 3;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 11;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[8].Clone();
                //row.Cells["level"].Value = 9;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Song of Rest (d8)";
                //row.Cells["cantrips"].Value = 3;
                //row.Cells["spells"].Value = 12;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 3;
                //row.Cells["fifth"].Value = 1;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[9].Clone();
                //row.Cells["level"].Value = 10;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Bardic Inspiration (d10), Expertise, Magical Secrets";
                //row.Cells["cantrips"].Value = 4;
                //row.Cells["spells"].Value = 14;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 3;
                //row.Cells["fifth"].Value = 2;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[10].Clone();
                //row.Cells["level"].Value = 11;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "---";
                //row.Cells["cantrips"].Value = 4;
                //row.Cells["spells"].Value = 15;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 3;
                //row.Cells["fifth"].Value = 2;
                //row.Cells["sixth"].Value = 1;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[11].Clone();
                //row.Cells["level"].Value = 12;
                //row.Cells["proficiency"].Value = 4;
                //row.Cells["features"].Value = "Ability Score Improvement";
                //row.Cells["cantrips"].Value = 4;
                //row.Cells["spells"].Value = 15;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 3;
                //row.Cells["fifth"].Value = 2;
                //row.Cells["sixth"].Value = 1;
                //levelingGrid.Rows.Add(row);

                //row = (DataGridViewRow)levelingGrid.Rows[12].Clone();
                //row.Cells["level"].Value = 13;
                //row.Cells["proficiency"].Value = 5;
                //row.Cells["features"].Value = "Song of Rest (d10)";
                //row.Cells["cantrips"].Value = 4;
                //row.Cells["spells"].Value = 16;
                //row.Cells["first"].Value = 4;
                //row.Cells["second"].Value = 3;
                //row.Cells["third"].Value = 3;
                //row.Cells["fourth"].Value = 3;
                //row.Cells["fifth"].Value = 2;
                //row.Cells["sixth"].Value = 1;
                //row.Cells["seventh"].Value = 
                //levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Cleric"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d8 per Cleric level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = cleric.getProf[0];
        //        row.Cells["desc"].Value = cleric.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = cleric.getProf[1];
        //        row.Cells["desc"].Value = cleric.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = cleric.getProf[2];
        //        row.Cells["desc"].Value = cleric.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = cleric.getProf[3];
        //        row.Cells["desc"].Value = cleric.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = cleric.getProf[4];
        //        row.Cells["desc"].Value = cleric.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = cleric.getProf[5];
        //        row.Cells["desc"].Value = cleric.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("cantrips", "Cantrips Known");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");
        //        levelingGrid.Columns.Add("sixth", "6th");
        //        levelingGrid.Columns.Add("seventh", "7th");
        //        levelingGrid.Columns.Add("eighth", "8th");
        //        levelingGrid.Columns.Add("nineth", "9th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Spellcasting, Divine Domain";
        //        row.Cells["cantrips"].Value = 3;
        //        row.Cells["first"].Value = 2;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Druid"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d8 per Druid level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = druid.getProf[0];
        //        row.Cells["desc"].Value = druid.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = druid.getProf[1];
        //        row.Cells["desc"].Value = druid.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = druid.getProf[2];
        //        row.Cells["desc"].Value = druid.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = druid.getProf[3];
        //        row.Cells["desc"].Value = druid.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = druid.getProf[4];
        //        row.Cells["desc"].Value = druid.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = druid.getProf[5];
        //        row.Cells["desc"].Value = druid.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
        //        row.Cells["name"].Value = druid.getProf[6];
        //        row.Cells["desc"].Value = druid.getDProf[6];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[8].Clone();
        //        row.Cells["name"].Value = druid.getProf[7];
        //        row.Cells["desc"].Value = druid.getDProf[7];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[9].Clone();
        //        row.Cells["name"].Value = druid.getProf[8];
        //        row.Cells["desc"].Value = druid.getDProf[8];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[10].Clone();
        //        row.Cells["name"].Value = druid.getProf[9];
        //        row.Cells["desc"].Value = druid.getDProf[9];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[11].Clone();
        //        row.Cells["name"].Value = druid.getProf[10];
        //        row.Cells["desc"].Value = druid.getDProf[10];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[12].Clone();
        //        row.Cells["name"].Value = druid.getProf[11];
        //        row.Cells["desc"].Value = druid.getDProf[11];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[13].Clone();
        //        row.Cells["name"].Value = druid.getProf[12];
        //        row.Cells["desc"].Value = druid.getDProf[12];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[14].Clone();
        //        row.Cells["name"].Value = druid.getProf[13];
        //        row.Cells["desc"].Value = druid.getDProf[13];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[15].Clone();
        //        row.Cells["name"].Value = druid.getProf[14];
        //        row.Cells["desc"].Value = druid.getDProf[14];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[16].Clone();
        //        row.Cells["name"].Value = druid.getProf[15];
        //        row.Cells["desc"].Value = druid.getDProf[15];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("cantrips", "Cantrips Known");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");
        //        levelingGrid.Columns.Add("sixth", "6th");
        //        levelingGrid.Columns.Add("seventh", "7th");
        //        levelingGrid.Columns.Add("eighth", "8th");
        //        levelingGrid.Columns.Add("nineth", "9th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Spellcasting, Druidic";
        //        row.Cells["cantrips"].Value = 2;
        //        row.Cells["first"].Value = 2;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Fighter"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d10 per Fighter level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = fighter.getProf[0];
        //        row.Cells["desc"].Value = fighter.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = fighter.getProf[1];
        //        row.Cells["desc"].Value = fighter.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = fighter.getProf[2];
        //        row.Cells["desc"].Value = fighter.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = fighter.getProf[3];
        //        row.Cells["desc"].Value = fighter.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = fighter.getProf[4];
        //        row.Cells["desc"].Value = fighter.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = fighter.getProf[5];
        //        row.Cells["desc"].Value = fighter.getDProf[5];
        //        featuresGrid.Rows.Add(row);


        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Fighting Style, Second Wind";
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Monk"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d8 per Monk level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = monk.getProf[0];
        //        row.Cells["desc"].Value = monk.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = monk.getProf[1];
        //        row.Cells["desc"].Value = monk.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = monk.getProf[2];
        //        row.Cells["desc"].Value = monk.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = monk.getProf[3];
        //        row.Cells["desc"].Value = monk.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = monk.getProf[4];
        //        row.Cells["desc"].Value = monk.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("martial","Martial Arts");
        //        levelingGrid.Columns.Add("ki","Ki Points");
        //        levelingGrid.Columns.Add("unarmored","Unarmored Movement");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Unarmored Defense, Martial Arts";
        //        row.Cells["martial"].Value = "1d4";
        //        row.Cells["ki"].Value = 0;
        //        row.Cells["unarmored"].Value = 0;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Paladin"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d10 per Paladin level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = paladin.getProf[0];
        //        row.Cells["desc"].Value = paladin.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = paladin.getProf[1];
        //        row.Cells["desc"].Value = paladin.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = paladin.getProf[2];
        //        row.Cells["desc"].Value = paladin.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = paladin.getProf[3];
        //        row.Cells["desc"].Value = paladin.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = paladin.getProf[4];
        //        row.Cells["desc"].Value = paladin.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = paladin.getProf[5];
        //        row.Cells["desc"].Value = paladin.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Divine Sense, Lay on Hands";
        //        row.Cells["first"].Value = 0;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Ranger"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d10 per Ranger level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = ranger.getProf[0];
        //        row.Cells["desc"].Value = ranger.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = ranger.getProf[1];
        //        row.Cells["desc"].Value = ranger.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = ranger.getProf[2];
        //        row.Cells["desc"].Value = ranger.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = ranger.getProf[3];
        //        row.Cells["desc"].Value = ranger.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = ranger.getProf[4];
        //        row.Cells["desc"].Value = ranger.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = ranger.getProf[5];
        //        row.Cells["desc"].Value = ranger.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
        //        row.Cells["name"].Value = ranger.getProf[6];
        //        row.Cells["desc"].Value = ranger.getDProf[6];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("spells", "Spells Known");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Favored Enemy, Natural Explorer";
        //        row.Cells["spells"].Value = 0;
        //        row.Cells["first"].Value = 0;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Rogue"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d8 per Rogue level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = rogue.getProf[0];
        //        row.Cells["desc"].Value = rogue.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = rogue.getProf[1];
        //        row.Cells["desc"].Value = rogue.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = rogue.getProf[2];
        //        row.Cells["desc"].Value = rogue.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = rogue.getProf[3];
        //        row.Cells["desc"].Value = rogue.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = rogue.getProf[4];
        //        row.Cells["desc"].Value = rogue.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = rogue.getProf[5];
        //        row.Cells["desc"].Value = rogue.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
        //        row.Cells["name"].Value = rogue.getProf[6];
        //        row.Cells["desc"].Value = rogue.getDProf[6];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[8].Clone();
        //        row.Cells["name"].Value = rogue.getProf[7];
        //        row.Cells["desc"].Value = rogue.getDProf[7];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[9].Clone();
        //        row.Cells["name"].Value = rogue.getProf[8];
        //        row.Cells["desc"].Value = rogue.getDProf[8];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("sneak","Sneak Attack");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Expertise, Sneak Attack, Thieves' Cant";
        //        row.Cells["sneak"].Value = "1d6";
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Sorcerer"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d6 per Sorcerer level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[0];
        //        row.Cells["desc"].Value = sorcerer.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[1];
        //        row.Cells["desc"].Value = sorcerer.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[2];
        //        row.Cells["desc"].Value = sorcerer.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[3];
        //        row.Cells["desc"].Value = sorcerer.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[4];
        //        row.Cells["desc"].Value = sorcerer.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[5];
        //        row.Cells["desc"].Value = sorcerer.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
        //        row.Cells["name"].Value = sorcerer.getProf[6];
        //        row.Cells["desc"].Value = sorcerer.getDProf[6];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("sorcery","Sorcery Points");
        //        levelingGrid.Columns.Add("cantrips", "Cantrips Known");
        //        levelingGrid.Columns.Add("spells", "Spells Known");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");
        //        levelingGrid.Columns.Add("sixth", "6th");
        //        levelingGrid.Columns.Add("seventh", "7th");
        //        levelingGrid.Columns.Add("eighth", "8th");
        //        levelingGrid.Columns.Add("nineth", "9th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Spellcasting, Sorcerous Origin";
        //        row.Cells["cantrips"].Value = 4;
        //        row.Cells["spells"].Value = 2;
        //        row.Cells["first"].Value = 2;
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Warlock"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        featuresGrid.Columns.Add("name", "Name");
        //        featuresGrid.Columns.Add("desc", "Description");

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d8 per Warlock level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = warlock.getProf[0];
        //        row.Cells["desc"].Value = warlock.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = warlock.getProf[1];
        //        row.Cells["desc"].Value = warlock.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = warlock.getProf[2];
        //        row.Cells["desc"].Value = warlock.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = warlock.getProf[3];
        //        row.Cells["desc"].Value = warlock.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("cantrips", "Cantrips Known");
        //        levelingGrid.Columns.Add("spells", "Spells Known");
        //        levelingGrid.Columns.Add("slots","Spell Slots");
        //        levelingGrid.Columns.Add("slotLevel","Slot Level");
        //        levelingGrid.Columns.Add("invocations","Invocations Known");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Otherworldly Patron, Pact Magic";
        //        row.Cells["cantrips"].Value = 2;
        //        row.Cells["spells"].Value = 2;
        //        row.Cells["slots"].Value = 1;
        //        row.Cells["slotsLevel"].Value = "1st";
        //        levelingGrid.Rows.Add(row);
        //    }

        //    if (curItem.Equals("Wizard"))
        //    {
        //        featuresGrid.Columns.Clear();
        //        featuresGrid.Rows.Clear();

        //        DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
        //        row.Cells["name"].Value = "Hit Dice: ";
        //        row.Cells["desc"].Value = "1d6 per Warlock level";
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
        //        row.Cells["name"].Value = wizard.getProf[0];
        //        row.Cells["desc"].Value = wizard.getDProf[0];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
        //        row.Cells["name"].Value = wizard.getProf[1];
        //        row.Cells["desc"].Value = wizard.getDProf[1];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
        //        row.Cells["name"].Value = wizard.getProf[2];
        //        row.Cells["desc"].Value = wizard.getDProf[2];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
        //        row.Cells["name"].Value = wizard.getProf[3];
        //        row.Cells["desc"].Value = wizard.getDProf[3];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
        //        row.Cells["name"].Value = wizard.getProf[4];
        //        row.Cells["desc"].Value = wizard.getDProf[4];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
        //        row.Cells["name"].Value = wizard.getProf[5];
        //        row.Cells["desc"].Value = wizard.getDProf[5];
        //        featuresGrid.Rows.Add(row);

        //        row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
        //        row.Cells["name"].Value = wizard.getProf[6];
        //        row.Cells["desc"].Value = wizard.getDProf[6];
        //        featuresGrid.Rows.Add(row);

        //        levelingGrid.Columns.Clear();
        //        levelingGrid.Rows.Clear();

        //        levelingGrid.Columns.Add("level", "Level");
        //        levelingGrid.Columns.Add("proficiency", "Proficiency Bonus");
        //        levelingGrid.Columns.Add("features", "Features");
        //        levelingGrid.Columns.Add("cantrips", "Cantrips Known");
        //        levelingGrid.Columns.Add("spells", "Spells Known");
        //        levelingGrid.Columns.Add("first", "1st");
        //        levelingGrid.Columns.Add("second", "2nd");
        //        levelingGrid.Columns.Add("third", "3rd");
        //        levelingGrid.Columns.Add("fourth", "4th");
        //        levelingGrid.Columns.Add("fifth", "5th");
        //        levelingGrid.Columns.Add("sixth", "6th");
        //        levelingGrid.Columns.Add("seventh", "7th");
        //        levelingGrid.Columns.Add("eighth", "8th");
        //        levelingGrid.Columns.Add("nineth", "9th");

        //        row = (DataGridViewRow)levelingGrid.Rows[0].Clone();
        //        row.Cells["level"].Value = 1;
        //        row.Cells["proficiency"].Value = 2;
        //        row.Cells["features"].Value = "Spellcasting, Arcane Recovery";
        //        row.Cells["cantrips"].Value = 3;
        //        row.Cells["first"].Value = 2;
        //        levelingGrid.Rows.Add(row);
        //    }
        //}
>>>>>>> 54037f2e5a37e8eb5a62831e590a0162163cb6d4

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get currently selected item.
            string curItem = backgroundBox.SelectedItem.ToString();
            Background selectBG = new Background(curItem);

            Background selectBack = new Background(curItem);

            ArrayList bProf = new ArrayList();
            bProf = selectBack.getProf();
            ArrayList bLang = new ArrayList();
            bLang = selectBack.getLang();
            ArrayList bEquip = new ArrayList();
            bEquip = selectBack.getEquip();
            ArrayList bPers = new ArrayList();
            bPers = selectBack.getPers();
            ArrayList bIdeal = new ArrayList();
            bIdeal = selectBack.getIdeal();
            ArrayList bBond = new ArrayList();
            bBond = selectBack.getBond();
            ArrayList bFlaw = new ArrayList();
            bFlaw = selectBack.getFlaw();

            proficienciesGrid.Columns.Add("name","Name");
            //proficienciesGrid.Columns.Add("desc", "Description");

            DataGridViewRow row = (DataGridViewRow)proficienciesGrid.Rows[0].Clone();

            for (int i = 0; i <= bProf.Count; i++)
            {
                row = (DataGridViewRow)proficienciesGrid.Rows[i].Clone();
                row.Cells["name"].Value = bProf[i];
                proficienciesGrid.Rows.Add(row);
            }

            languagesGrid.Columns.Add("name", "Name");
            //languagesGrid.Columns.Add("desc", "Description");

            for (int j = 0; j <= bLang.Count; j++)
            {
                row = (DataGridViewRow)languagesGrid.Rows[j].Clone();
                row.Cells["name"].Value = bLang[j];
                languagesGrid.Rows.Add(row);
            }

            bEquipmentGrid.Columns.Add("name", "Name");
            //equipGrid.Columns.Add("desc", "Description");

            for (int z = 0; z <= bEquip.Count; z++)
            {
                row = (DataGridViewRow)bEquipmentGrid.Rows[z].Clone();
                row.Cells["name"].Value = bEquip[z];
                bEquipmentGrid.Rows.Add(row);
            }

            personalityGrid.Columns.Add("num", "Number");
            personalityGrid.Columns.Add("desc", "Description");

            for (int y = 0; y <= bPers.Count; y++)
            {
                row = (DataGridViewRow)personalityGrid.Rows[y].Clone();
                row.Cells["num"].Value = "" + y + 1;
                row.Cells["desc"].Value = bPers[y];
                personalityGrid.Rows.Add(row);
            }

            idealGrid.Columns.Add("num", "Number");
            idealGrid.Columns.Add("desc", "Description");

            for (int x = 0; x <= bIdeal.Count; x++)
            {
                row = (DataGridViewRow)idealGrid.Rows[x].Clone();
                row.Cells["num"].Value = "" + x + 1;
                row.Cells["desc"].Value = bIdeal[x];
                idealGrid.Rows.Add(row);
            }

            bondGrid.Columns.Add("num", "Number");
            bondGrid.Columns.Add("desc", "Description");

            for (int w = 0; w <= bBond.Count; w++)
            {
                row = (DataGridViewRow)bondGrid.Rows[w].Clone();
                row.Cells["num"].Value = "" + w + 1;
                row.Cells["desc"].Value = bBond[w];
                bondGrid.Rows.Add(row);
            }

            flawGrid.Columns.Add("num", "Number");
            flawGrid.Columns.Add("desc", "Description");

            for (int v = 0; v <= bFlaw.Count; v++)
            {
                row = (DataGridViewRow)flawGrid.Rows[v].Clone();
                row.Cells["num"].Value = "" + v + 1;
                row.Cells["desc"].Value = bFlaw[v];
                flawGrid.Rows.Add(row);
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rollLabel1.Text = Calculations.rollAbilityScore().ToString();
            rollLabel2.Text = Calculations.rollAbilityScore().ToString();
            rollLabel3.Text = Calculations.rollAbilityScore().ToString();
            rollLabel4.Text = Calculations.rollAbilityScore().ToString();
            rollLabel5.Text = Calculations.rollAbilityScore().ToString();
            rollLabel6.Text = Calculations.rollAbilityScore().ToString();
        }

        private void strButton_Click(object sender, EventArgs e)
        {
            pc.setBaseStr(Int32.Parse(strTextBox.Text));
            strLabel.Text = strTextBox.Text;
            pc.setStrMod(Calculations.calcMod(Int32.Parse(strTextBox.Text)));
            strModLabel.Text = pc.getSTRMod().ToString();
        }

        private void dexButton_Click(object sender, EventArgs e)
        {
            pc.setBaseDex(Int32.Parse(dexTextBox.Text));
            dexLabel.Text = dexTextBox.Text;
            pc.setDexMod(Calculations.calcMod(Int32.Parse(dexTextBox.Text)));
            dexModLabel.Text = pc.getDEXMod().ToString();
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            pc.setBaseCon(Int32.Parse(conTextBox.Text));
            conLabel.Text = conTextBox.Text;
            pc.setConMod(Calculations.calcMod(Int32.Parse(conTextBox.Text)));
            conModLabel.Text = pc.getCONMod().ToString();
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            pc.setBaseIntel(Int32.Parse(intTextBox.Text));
            intLabel.Text = intTextBox.Text;
            pc.setIntelMod(Calculations.calcMod(Int32.Parse(intTextBox.Text)));
            intModLabel.Text = pc.getINTMod().ToString();
        }

        private void wisButton_Click(object sender, EventArgs e)
        {
            pc.setBaseWis(Int32.Parse(wisTextBox.Text));
            wisLabel.Text = wisTextBox.Text;
            pc.setWisMod(Calculations.calcMod(Int32.Parse(wisTextBox.Text)));
            wisModLabel.Text = pc.getWISMod().ToString();
        }

        private void chaButton_Click(object sender, EventArgs e)
        {
            pc.setBaseCon(Int32.Parse(chaTextBox.Text));
            chaLabel.Text = chaTextBox.Text;
            pc.setChaMod(Calculations.calcMod(Int32.Parse(chaTextBox.Text)));
            chaModLabel.Text = pc.getCHAMod().ToString();
        }

    }
}
