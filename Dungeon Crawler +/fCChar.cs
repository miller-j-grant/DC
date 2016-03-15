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

            traitsGrid.ColumnCount = 2;
            traitsGrid.Columns[0].Name = "Trait";
            traitsGrid.Columns[1].Name = "Description";

            //Add Trait information to the Traits DataGrid based on the amount of racial traits each race has.
            DataGridViewRow row = new DataGridViewRow();


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
            traitsGrid.Columns[0].Name = "Languages";
            //Add Language information to the Language DataGrid.
            for (int j = 0; j < lang.Count; j++)
            {
                languagesGrid.Rows.Add(lang[j]);
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
            featuresGrid.Columns.Add("name", "Name");
            featuresGrid.Columns.Add("desc", "Description");

            DataGridViewRow row = (DataGridViewRow)featuresGrid.Rows[0].Clone();
            row.Cells["name"].Value = "Hit Dice: ";
            row.Cells["desc"].Value = "1d" + selectClass.hit + " per " + selectClass.className + " level";

            featuresGrid.Rows.Add(row);

            ArrayList prof = new ArrayList();
            prof = selectClass.prof;
            // ArrayList pDesc = new ArrayList();
            // pDesc = selectClass.getPDesc();

            for (int i = 1; i <= prof.Count; i++)
            {
                row = (DataGridViewRow)featuresGrid.Rows[i].Clone();
                row.Cells["name"].Value = prof[i];
            //    row.Cells["desc"].Value = pDesc[i];
                featuresGrid.Rows.Add(row);
            }
                //Set the rows for the Features DataGrid.        

            //Clear the Leveling Table DataGrid of all columns and rows.
            levelingGrid.Columns.Clear();
            levelingGrid.Rows.Clear();
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

            proficienciesGrid.Columns.Add("name", "Name");
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

        private void STRUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            strCostLabel.Text = "" + Calculations.pointBuyCost(STRUpDown.Value);
            //Change the value of the points remaining label.
            string name = "str";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), STRUpDown.Value, name);
        }

        private void DEXUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            dexCostLabel.Text = "" + Calculations.pointBuyCost(DEXUpDown.Value);
            //Change the value of the points remaining label.
            string name = "dex";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), DEXUpDown.Value, name);
        }

        private void CONUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            conCostLabel.Text = "" + Calculations.pointBuyCost(CONUpDown.Value);
            //Change the value of the points remaining label.
            string name = "con";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), CONUpDown.Value, name);
        }

        private void INTUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            intCostLabel.Text = "" + Calculations.pointBuyCost(INTUpDown.Value);
            //Change the value of the points remaining label.
            string name = "int";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), INTUpDown.Value, name);
        }

        private void WISUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            wisCostLabel.Text = "" + Calculations.pointBuyCost(WISUpDown.Value);
            //Change the value of the points remaining label.
            string name = "wis";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), WISUpDown.Value, name);
        }

        private void CHAUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Change the value of the cost label.
            chaCostLabel.Text = "" + Calculations.pointBuyCost(CHAUpDown.Value);
            //Change the value of the points remaining label.
            string name = "cha";
            pointsRemainingLabel.Text = "" + Calculations.pointBuyPoints(Convert.ToInt32(pointsRemainingLabel.Text), CHAUpDown.Value, name);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pbCommitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
