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
using BitMiracle.Docotic.Pdf;
using System.Diagnostics;



namespace Dungeon_Crawler__
{
    /// <summary>
    /// The form that a character is created in </summary>
    /// <remarks>
    /// author: Patrick Dishaw, Grant Miller, Mitch Couturier
    /// version: 2/22/2016 </remarks>
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

        /// <summary>
        /// Executed when the rollButton is clicked. Rolls random ability scores </summary>
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
            STRUpDown.Value = 8;
            DEXUpDown.Value = 8;
            CONUpDown.Value = 8;
            INTUpDown.Value = 8;
            WISUpDown.Value = 8;
            CHAUpDown.Value = 8;
            pointsRemainingLabel.Text = "27";
        }

        private void pbCommitButton_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(pointsRemainingLabel.Text) < 0)
            {
                MessageBox.Show("Points Remaining is less than 0", "Point-Buy Error", MessageBoxButtons.OK);
            }
            else
            {


                try
                {
                    pc.setBaseStr(Convert.ToInt32(STRUpDown.Value));
                    strLabel.Text = STRUpDown.Value.ToString();
                    pc.setStrMod(Calculations.calcMod(Int32.Parse(STRUpDown.Value.ToString())));
                    strModLabel.Text = pc.getSTRMod().ToString();

                    pc.setBaseDex(Convert.ToInt32(DEXUpDown.Value));
                    dexLabel.Text = DEXUpDown.Value.ToString();
                    pc.setDexMod(Calculations.calcMod(Int32.Parse(DEXUpDown.Value.ToString())));
                    dexModLabel.Text = pc.getDEXMod().ToString();

                    pc.setBaseCon(Convert.ToInt32(CONUpDown.Value));
                    conLabel.Text = CONUpDown.Value.ToString();
                    pc.setConMod(Calculations.calcMod(Int32.Parse(CONUpDown.Value.ToString())));
                    conModLabel.Text = pc.getCONMod().ToString();

                    pc.setBaseIntel(Convert.ToInt32(INTUpDown.Value));
                    intLabel.Text = INTUpDown.Value.ToString();
                    pc.setIntelMod(Calculations.calcMod(Int32.Parse(INTUpDown.Value.ToString())));
                    intModLabel.Text = pc.getINTMod().ToString();

                    pc.setBaseWis(Convert.ToInt32(WISUpDown.Value));
                    wisLabel.Text = WISUpDown.Value.ToString();
                    pc.setWisMod(Calculations.calcMod(Int32.Parse(WISUpDown.Value.ToString())));
                    wisModLabel.Text = pc.getWISMod().ToString();

                    pc.setBaseCha(Convert.ToInt32(CHAUpDown.Value));
                    chaLabel.Text = CHAUpDown.Value.ToString();
                    pc.setChaMod(Calculations.calcMod(Int32.Parse(CHAUpDown.Value.ToString())));
                    chaModLabel.Text = pc.getCHAMod().ToString();
                }
                catch
                {

                }
            }
        }

        private void raceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item.
            string curItem = raceBox.SelectedItem.ToString();

            //Call to create a new Race object, same name as currently selected item.
            Race selectRace = new Race(curItem);

            // Changes labels, grids, and buttons to be visible
            asmLabel.Visible = true;
            asmDisplayLabel.Visible = true;
            sizeLabel.Visible = true;
            sizeDisplayLabel.Visible = true;
            speedLabel.Visible = true;
            speedDisplayLabel.Visible = true;
            traitsLabel.Visible = true;
            traitsGrid.Visible = true;
            languagesLabel.Visible = true;
            languagesGrid.Visible = true;
            raceButton.Visible = true;

            // Changes race background image based on selected Race
            switch (curItem)
            {
                case "Dwarf":
                    raceTab.BackgroundImage = Properties.Resources.dwarf;
                    break;
                case "Elf":
                    raceTab.BackgroundImage = Properties.Resources.elf;
                    break;
                case "Halfling":
                    raceTab.BackgroundImage = Properties.Resources.halfling;
                    break;
                case "Human":
                    raceTab.BackgroundImage = Properties.Resources.human;
                    break;
                case "Dragonborn":
                    raceTab.BackgroundImage = Properties.Resources.dragonborn;
                    break;
                case "Gnome":
                    raceTab.BackgroundImage = Properties.Resources.gnome;
                    break;
                case "Half-Elf":
                    raceTab.BackgroundImage = Properties.Resources.halfelf;
                    break;
                case "Half-Orc":
                    raceTab.BackgroundImage = Properties.Resources.halforc;
                    break;
                case "Tiefling":
                    raceTab.BackgroundImage = Properties.Resources.tiefling;
                    break;
                default:
                    break;
            }

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

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Get the currently selected item.
            string curItem = classBox.SelectedItem.ToString();

            Class selectClass = new Class(curItem);

            // changes label, grid, and buttons to be visable
            featuresLabel.Visible = true;
            featuresGrid.Visible = true;
            classButton.Visible = true;

            // changes class background image depending on what class is selected
            switch (curItem)
            {
                case "Barbarian":
                    classTab.BackgroundImage = Properties.Resources.barbarian0;
                    break;
                case "Bard":
                    classTab.BackgroundImage = Properties.Resources.bard0;
                    break;
                case "Cleric":
                    classTab.BackgroundImage = Properties.Resources.cleric0;
                    break;
                case "Druid":
                    classTab.BackgroundImage = Properties.Resources.druid0;
                    break;
                case "Fighter":
                    classTab.BackgroundImage = Properties.Resources.fighter0;
                    break;
                case "Monk":
                    classTab.BackgroundImage = Properties.Resources.monk0;
                    break;
                case "Paladin":
                    classTab.BackgroundImage = Properties.Resources.paladin0;
                    break;
                case "Ranger":
                    classTab.BackgroundImage = Properties.Resources.ranger0;
                    break;
                case "Rogue":
                    classTab.BackgroundImage = Properties.Resources.rogue0;
                    break;
                case "Sorcerer":
                    classTab.BackgroundImage = Properties.Resources.sorcerer0;
                    break;
                case "Warlock":
                    classTab.BackgroundImage = Properties.Resources.warlock0;
                    break;
                case "Wizard":
                    classTab.BackgroundImage = Properties.Resources.wizard0;
                    break;
                default:
                    break;
            }


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

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (pc.getBaseAS().Contains(0))
            {
                MessageBox.Show("Please commit all of your Ability Scores before selecting a race.", "Race Selection Error", MessageBoxButtons.OK);
            }
            else
            {

                try
                {
                    fCCSelection fCC = new fCCSelection();
                    fCC.fCCLoadSelections("Race: " + raceBox.SelectedItem, pc);
                    fCC.ShowDialog();

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

        }

        private void classButton_Click(object sender, EventArgs e)
        {
            try
            {
                fCCSelection fCC = new fCCSelection();
                fCC.fCCLoadSelections("Class: " + classBox.SelectedItem, pc);
                fCC.ShowDialog();
                string curItem = classBox.SelectedItem.ToString();
                pc.setClass(curItem);
            }
            catch
            {

            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            try
            {

                string curItem = backgroundBox.SelectedItem.ToString();
                pc.setBackground(curItem);

            }
            catch
            {

            }
        }

        private void selectionButton_Click(object sender, EventArgs e)
        {
            
        }

        private void skillSelectionButton_Click(object sender, EventArgs e)
        {
            
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            pc.name = nameTextBox.Text;
            pc.player = playerTextBox.Text;
            pc.age = ageTextBox.Text;
            pc.eye = eyesBox.Text;
            pc.height = heightTextBox.Text;
            pc.hair = hairTextBox.Text;
            pc.weight = weightTextBox.Text;
            pc.skin = skinTextBox.Text;
            pc.alignment = alignmentTextBox.Text;
            pc.backstory = backstoryTextBox.Text;
            pc.skills = Calculations.calcSkills(pc.statmods, pc.proficiency, pc.profbonus);
            PDFInterface.finalize(pc);
        }

    }
}
