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

            //Update data and display based on the currently selected item.
            //if (curItem.Equals("Dwarf"))
            //{

            int[] stat = new int[6];
            stat = selectRace.getStats();

                //Set Ability Score Modifier text display for each race.
                asmDisplayLabel.Text = "STR: " + stat[0] + " DEX: " + stat[1] + " CON: " + stat[2] + " INT: " + stat[3] + " WIS: " + stat[4] + " CHA: " + stat[5];

                //Set Size text display for each race.
                sizeDisplayLabel.Text = selectRace.getSize() ;

                //Set Speed text display for each race.
                speedDisplayLabel.Text = "" + selectRace.getSpeed();

                //Clear the Trait DataGrid of all columns and rows.
                traitsGrid.Columns.Clear();
                traitsGrid.Rows.Clear();

                //Add Trait information to the Traits DataGrid based on the amount of racial traits each race has.
                DataGridViewRow row = (DataGridViewRow)traitsGrid.Rows[0].Clone();

            ArrayList trait = new ArrayList();
            trait = selectRace.getTraits();
            ArrayList tDesc = new ArrayList();
            tDesc = selectRace.getTDesc();
            ArrayList lang = new ArrayList();
            lang = selectRace.getLanguages();


            for (int i = 0; i <= trait.Count; i++)
            {
                row = (DataGridViewRow)traitsGrid.Rows[i].Clone();
                row.Cells["Trait"].Value = trait[i];
                row.Cells["Description"].Value = tDesc[i];
                traitsGrid.Rows.Add(row);
            }

                //row.Cells["Trait"].Value = selectRace.getTrait[0];
                //row.Cells["Description"].Value = selectRace.getTDesc[0];
                //traitsGrid.Rows.Add(row);

                //row = (DataGridViewRow)traitsGrid.Rows[1].Clone();
                //row.Cells["Trait"].Value = selectRace.getTrait[1];
                //row.Cells["Description"].Value = .getTDesc[1];
                //traitsGrid.Rows.Add(row);

                //row = (DataGridViewRow)traitsGrid.Rows[2].Clone();
                //row.Cells["Trait"].Value = dwarf.getTrait[2];
                //row.Cells["Description"].Value = dwarf.getTDesc[2];
                //traitsGrid.Rows.Add(row);

                //row = (DataGridViewRow)traitsGrid.Rows[3].Clone();
                //row.Cells["Trait"].Value = dwarf.getTrait[3];
                //row.Cells["Description"].Value = dwarf.getTDesc[3];
                //traitsGrid.Rows.Add(row);

                //row = (DataGridViewRow)traitsGrid.Rows[4].Clone();
                //row.Cells["Trait"].Value = dwarf.getTrait[4];
                //row.Cells["Description"].Value = dwarf.getTDesc[4];
                //traitsGrid.Rows.Add(row);

                //Clear the Language DataGrid of all columns and rows.
                languagesGrid.Columns.Clear();
                languagesGrid.Rows.Clear();

            //Add Language information to the Language DataGrid.
            for (int j = 0; j <= lang.Count; j++)
            {
                row = (DataGridViewRow)languagesGrid.Rows[j].Clone();
                row.Cells["Languages"].Value = lang[j];
                languagesGrid.Rows.Add(row);
            }
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
            row.Cells["desc"].Value = "1d" + selectClass.getHit() + " per " + selectClass.getName() + " level";
            featuresGrid.Rows.Add(row);

            ArrayList prof = new ArrayList();
            prof = selectClass.getProf();
            ArrayList pDesc = new ArrayList();
            pDesc = selectClass.getPDesc();

            for (int i = 1; i <= prof.Count; i++)
            {
                row = (DataGridViewRow)featuresGrid.Rows[i].Clone();
                row.Cells["name"].Value = prof[i];
                row.Cells["desc"].Value = pDesc[i];
                featuresGrid.Rows.Add(row);
            }
                //Set the rows for the Features DataGrid.
                //DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
                //row.Cells["name"].Value = "Hit Dice: ";
                //row.Cells["desc"].Value = "1d12 per Barbarian level";
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[1].Clone();
                //row.Cells["name"].Value = barbarian.getProf[0];
                //row.Cells["desc"].Value = barbarian.getPDesc[0];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[2].Clone();
                //row.Cells["name"].Value = barbarian.getProf[1];
                //row.Cells["desc"].Value = barbarian.getPDesc[1];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[3].Clone();
                //row.Cells["name"].Value = barbarian.getProf[2];
                //row.Cells["desc"].Value = barbarian.getPDesc[2];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[4].Clone();
                //row.Cells["name"].Value = barbarian.getProf[3];
                //row.Cells["desc"].Value = barbarian.getPDesc[3];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[5].Clone();
                //row.Cells["name"].Value = barbarian.getProf[4];
                //row.Cells["desc"].Value = barbarian.getPDesc[4];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[6].Clone();
                //row.Cells["name"].Value = barbarian.getProf[5];
                //row.Cells["desc"].Value = barbarian.getPDesc[5];
                //featuresGrid.Rows.Add(row);

                //row = (DataGridViewRow)featuresGrid.Rows[7].Clone();
                //row.Cells["name"].Value = barbarian.getProf[6];
                //row.Cells["desc"].Value = barbarian.getPDesc[6];
                //featuresGrid.Rows.Add(row);

                //Clear the Leveling Table DataGrid of all columns and rows.
                levelingGrid.Columns.Clear();
                levelingGrid.Rows.Clear();

            ArrayList col = new ArrayList();
            col = selectClass.getLCol();
            ArrayList rows = new ArrayList();
            rows = selectClass.getRows();
            ArrayList vRows = new ArrayList();

            for (int j = 0; j <= ; j++)
            {
                levelingGrid.Columns.Add(""+j,col[j]);
            }

            //Set the columns for the Leveling Table DataGrid.
            //levelingGrid.Columns.Add("level","Level");
            //levelingGrid.Columns.Add("proficiency","Proficiency Bonus");
            //levelingGrid.Columns.Add("features", "Features");
            //levelingGrid.Columns.Add("rages", "Rages");
            //levelingGrid.Columns.Add("damage", "Rage Damage");

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

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get currently selected item.
            string curItem = classBox.SelectedItem.ToString();

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
    }
}
