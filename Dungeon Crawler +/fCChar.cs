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
            try
            {
                pc.setBaseStr(Int32.Parse(strTextBox.Text));
                strLabel.Text = strTextBox.Text;
                pc.setStrMod(Calculations.calcMod(Int32.Parse(strTextBox.Text)));
                strModLabel.Text = pc.getSTRMod().ToString();
            }
            catch
            {

            }

        }

        private void dexButton_Click(object sender, EventArgs e)
        {
            try
            {
                pc.setBaseDex(Int32.Parse(dexTextBox.Text));
                dexLabel.Text = dexTextBox.Text;
                pc.setDexMod(Calculations.calcMod(Int32.Parse(dexTextBox.Text)));
                dexModLabel.Text = pc.getDEXMod().ToString();
            }
            catch
            {

            }
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            try
            {
                pc.setBaseCon(Int32.Parse(conTextBox.Text));
                conLabel.Text = conTextBox.Text;
                pc.setConMod(Calculations.calcMod(Int32.Parse(conTextBox.Text)));
                conModLabel.Text = pc.getCONMod().ToString();
            }
            catch
            {

            }
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            try
            {
                pc.setBaseIntel(Int32.Parse(intTextBox.Text));
                intLabel.Text = intTextBox.Text;
                pc.setIntelMod(Calculations.calcMod(Int32.Parse(intTextBox.Text)));
                intModLabel.Text = pc.getINTMod().ToString();
            }
            catch
            {

            }
        }

        private void wisButton_Click(object sender, EventArgs e)
        {
            try
            {
                pc.setBaseWis(Int32.Parse(wisTextBox.Text));
                wisLabel.Text = wisTextBox.Text;
                pc.setWisMod(Calculations.calcMod(Int32.Parse(wisTextBox.Text)));
                wisModLabel.Text = pc.getWISMod().ToString();
            }
            catch
            {

            }
        }

        private void chaButton_Click(object sender, EventArgs e)
        {
            try
            {
                pc.setBaseCha(Int32.Parse(chaTextBox.Text));
                chaLabel.Text = chaTextBox.Text;
                pc.setChaMod(Calculations.calcMod(Int32.Parse(chaTextBox.Text)));
                chaModLabel.Text = pc.getCHAMod().ToString();
            }
            catch
            {

            }
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            strButton_Click(sender, e);
            dexButton_Click(sender, e);
            conButton_Click(sender, e);
            intButton_Click(sender, e);
            wisButton_Click(sender, e);
            chaButton_Click(sender, e);
        }

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = raceBox.SelectedItem.ToString();

            //Call to create a new Race object, same name as currently selected item.
            Race selectRace = new Race(curItem);


            //Update data and display based on the currently selected item.


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
            traitsGrid.ColumnCount = 2;
            traitsGrid.Columns[0].Name = "Trait";
            traitsGrid.Columns[1].Name = "Description";

            ArrayList trait = new ArrayList();
            trait = selectRace.getTraits();
            ArrayList tDesc = new ArrayList();
            tDesc = selectRace.getTDesc();
            ArrayList lang = new ArrayList();
            lang = selectRace.getLanguages();


            for (int i = 0; i < trait.Count; i++)
            {
                traitsGrid.Rows.Add(trait[i], tDesc[i]);

            }

            //Clear the Language DataGrid of all columns and rows.
            languagesGrid.Columns.Clear();
            languagesGrid.Rows.Clear();

            languagesGrid.ColumnCount = 1;
            languagesGrid.Columns[0].Name = "Languages";
            //Add Language information to the Language DataGrid.
            for (int j = 0; j < lang.Count; j++)
            {
                languagesGrid.Rows.Add(lang[j]);
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            try
            {

                string curItem = raceBox.SelectedItem.ToString();
                pc.setRace(curItem);
                pc.setStats(pc.race.getStats());

                strLabel.Text = pc.getSTR().ToString();
                pc.setStrMod(Calculations.calcMod(pc.getSTR()));
                strModLabel.Text = pc.getSTRMod().ToString();

                dexLabel.Text = pc.getDEX().ToString();
                pc.setDexMod(Calculations.calcMod(pc.getDEX()));
                dexModLabel.Text = pc.getDEXMod().ToString();

                conLabel.Text = pc.getCON().ToString();
                pc.setConMod(Calculations.calcMod(pc.getCON()));
                conModLabel.Text = pc.getCONMod().ToString();

                intLabel.Text = pc.getINT().ToString();
                pc.setIntelMod(Calculations.calcMod(pc.getINT()));
                intModLabel.Text = pc.getINTMod().ToString();

                wisLabel.Text = pc.getWIS().ToString();
                pc.setWisMod(Calculations.calcMod(pc.getWIS()));
                wisModLabel.Text = pc.getWISMod().ToString();

                chaLabel.Text = pc.getCHA().ToString();
                pc.setChaMod(Calculations.calcMod(pc.getCHA()));
                chaModLabel.Text = pc.getCHAMod().ToString();
            }
            catch
            {

            }

        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            Class selectClass = new Class(curItem);

            //Clear the Features DataGrid of all columns and rows.
            featuresGrid.Columns.Clear();
            featuresGrid.Rows.Clear();

            //Set the columns for the Features DataGrid.
            featuresGrid.ColumnCount = 2;
            featuresGrid.Columns[0].Name = "Name";
            featuresGrid.Columns[1].Name = "Description";

            featuresGrid.Rows.Add("Hit Dice:", "1d" + selectClass.hit + " per " + selectClass.className + " level");

            ArrayList prof = new ArrayList();
            prof = selectClass.prof;
            //ArrayList pDesc = new ArrayList();
            // pDesc = selectClass.getPDesc();

            for (int i = 0; i < prof.Count; i++)
            {
                featuresGrid.Rows.Add(prof[i]/*, pDesc[i]*/);
            }
            //Set the rows for the Features DataGrid.



            //    //Clear the Leveling Table DataGrid of all columns and rows.
            //    levelingGrid.Columns.Clear();
            //    levelingGrid.Rows.Clear();


            //ArrayList vRows = new ArrayList();

            ////ArrayList col = new ArrayList();
            ////col = selectClass.getCol();


            //Clear the Leveling Table DataGrid of all columns and rows.
            levelingGrid.Columns.Clear();
            levelingGrid.Rows.Clear();


            //ArrayList col = new ArrayList();
            //col = selectClass.getLCol();
            // ArrayList rows = new ArrayList();
            // rows = selectClass.getRows();
            // ArrayList vRows = new ArrayList();

            //for (int j = 0; j <= ; j++)
            //{
            //    levelingGrid.Columns.Add(""+j,col[j]);
            //}

            //    for (int z = 0; z <= selectClass.vrow.Count; z++)
            //    {
            //        row = (DataGridViewRow)levelingGrid.Rows[z].Clone();
            //        for (int y = 0; y <= selectClass.columns.Count; y++)
            //        {
            //            row.Cells[y].Value = selectClass.vrow[y];
            //        }
            //    }
            //}
            //THINK THIS OVER, NEED TO FILL THE LEVELING GRID WITH ROWS VALUES BASED ON THE COLUMNS.
            //for (int z = 0; z <= ; z++)
            //Set the columns for the Leveling Table DataGrid.
            //levelingGrid.Columns.Add("level","Level");
            //levelingGrid.Columns.Add("proficiency","Proficiency Bonus");
            //levelingGrid.Columns.Add("features", "Features");
            //levelingGrid.Columns.Add("rages", "Rages");
            //levelingGrid.Columns.Add("damage", "Rage Damage");

            //for (int z = 0; z <= rows.Count; z++)
            //{
            //    vRows = selectClass.getVRows(z);
            //    row = (DataGridViewRow)levelingGrid.Rows[z].Clone();
            //    for (int y = 0; y <= col.Count; y++)
            //    {
            //        row.Cells[col[y]].Value = vRows[y];
            //    }
            //}
        }

        private void backgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get currently selected item.
            string curItem = backgroundBox.SelectedItem.ToString();
            Background selectBG = new Background(curItem);
            Background selectBack = new Background(curItem);

            ArrayList bProf = new ArrayList();
            bProf = selectBack.prof;
            ArrayList bLang = new ArrayList();
            bLang = selectBack.lang;
            ArrayList bEquip = new ArrayList();
            bEquip = selectBack.equip;
            ArrayList bPers = new ArrayList();
            bPers = selectBack.person;
            ArrayList bIdeal = new ArrayList();
            bIdeal = selectBack.ideal;
            ArrayList bBond = new ArrayList();
            bBond = selectBack.bond;
            ArrayList bFlaw = new ArrayList();
            bFlaw = selectBack.flaw;

            proficienciesGrid.Columns.Clear();
            proficienciesGrid.Rows.Clear();

            proficienciesGrid.ColumnCount = 2;
            proficienciesGrid.Columns[0].Name = "Name";
            proficienciesGrid.Columns[1].Name = "Description";

            for (int i = 0; i < bProf.Count; i++)
            {
                proficienciesGrid.Rows.Add(bProf[i]/*, bProf description[i]*/);
            }

            bLanguagesGrid.Columns.Clear();
            bLanguagesGrid.Rows.Clear();

            bLanguagesGrid.ColumnCount = 1;
            bLanguagesGrid.Columns[0].Name = "Language";

            for (int j = 0; j < bLang.Count; j++)
            {
                bLanguagesGrid.Rows.Add(bLang[j]);
            }

            bEquipmentGrid.Columns.Clear();
            bEquipmentGrid.Rows.Clear();

            bEquipmentGrid.ColumnCount = 2;
            bEquipmentGrid.Columns[0].Name = "Equipment";
            bEquipmentGrid.Columns[1].Name = "Description";

            for (int z = 0; z < bEquip.Count; z++)
            {
                bEquipmentGrid.Rows.Add(bEquip[z]/*, bEquip description[z]*/);

            }

            personalityGrid.Columns.Clear();
            personalityGrid.Rows.Clear();

            personalityGrid.ColumnCount = 2;
            personalityGrid.Columns[0].Name = "Number";
            personalityGrid.Columns[1].Name = "Description";

            for (int y = 0; y < bPers.Count; y++)
            {
                personalityGrid.Rows.Add((y + 1).ToString(), bPers[y]);
            }

            idealGrid.Columns.Clear();
            idealGrid.Rows.Clear();

            idealGrid.ColumnCount = 2;
            idealGrid.Columns[0].Name = "Number";
            idealGrid.Columns[1].Name = "Description";

            for (int x = 0; x < bIdeal.Count; x++)
            {
                idealGrid.Rows.Add((x + 1).ToString(), bIdeal[x]);
            }

            bondGrid.Columns.Clear();
            bondGrid.Rows.Clear();

            bondGrid.ColumnCount = 2;
            bondGrid.Columns[0].Name = "Number";
            bondGrid.Columns[1].Name = "Description";

            for (int w = 0; w < bBond.Count; w++)
            {
                bondGrid.Rows.Add((w + 1).ToString(), bBond[w]);
            }

            flawGrid.Columns.Clear();
            flawGrid.Rows.Clear();

            flawGrid.ColumnCount = 2;
            flawGrid.Columns[0].Name = "Number";
            flawGrid.Columns[1].Name = "Description";

            for (int v = 0; v < bFlaw.Count; v++)
            {
                flawGrid.Rows.Add((v + 1).ToString(), bFlaw[v]);
            }
        }


    }
}
