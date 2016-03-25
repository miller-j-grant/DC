﻿using System;
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

        private void classButton_Click(object sender, EventArgs e)
        {
            try
            {

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

        private void selectionButton_Click(object sender, EventArgs e)
        {
            fCCSelection fCC = new fCCSelection();
            fCC.fCCLoadSelections("Race: " + raceBox.SelectedItem, pc);
            fCC.ShowDialog();
        }

        private void skillSelectionButton_Click(object sender, EventArgs e)
        {
            fCCSelection fCC = new fCCSelection();
            fCC.fCCLoadSelections("Class: " + classBox.SelectedItem, pc);
            fCC.ShowDialog();
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            BitMiracle.Docotic.LicenseManager.AddLicenseData("4L4F2-CN67H-38NDJ-2K1HA-NBODQ");
            string pathToFile = "FilledSheet.pdf";

            using (PdfDocument pdf = new PdfDocument("CharacterSheet.pdf"))
            {
                PdfTextBox classBox = (PdfTextBox)pdf.Widgets[0];
                classBox.Text = pc.pClass.className + " 1";

                PdfTextBox backgroundBox = (PdfTextBox)pdf.Widgets[1];
                backgroundBox.Text = pc.bg.background;

                PdfTextBox playerBox = (PdfTextBox)pdf.Widgets[2];
                playerBox.Text = playerTextBox.Text;

                PdfTextBox characterBox = (PdfTextBox)pdf.Widgets[3];
                characterBox.Text = nameTextBox.Text;

                PdfTextBox raceBox = (PdfTextBox)pdf.Widgets[4];
                raceBox.Text = pc.race.getRaceName();

                PdfTextBox alignmentBox = (PdfTextBox)pdf.Widgets[5];
                alignmentBox.Text = "";
                
                //assuming level 1 character
                PdfTextBox expBox = (PdfTextBox)pdf.Widgets[6];
                expBox.Text = "0 / 300";

                PdfTextBox inspirationBox = (PdfTextBox)pdf.Widgets[7];
                inspirationBox.Text = "";

                PdfTextBox strengthBox = (PdfTextBox)pdf.Widgets[8];
                strengthBox.Text = pc.getSTR().ToString();

                //assuming level 1 character
                PdfTextBox proficiencyBox = (PdfTextBox)pdf.Widgets[9];
                proficiencyBox.Text = "2";

                PdfTextBox armorclassBox = (PdfTextBox)pdf.Widgets[10];
                armorclassBox.Text = Calculations.calcAC(10, pc.getDEXMod(), 0).ToString();

                PdfTextBox initiativeBox = (PdfTextBox)pdf.Widgets[11];
                initiativeBox.Text = Calculations.calcInitiative(pc.getDEXMod(),0).ToString();

                PdfTextBox speedBox = (PdfTextBox)pdf.Widgets[12];
                speedBox.Text = pc.race.getSpeed().ToString();

                PdfTextBox personalityBox = (PdfTextBox)pdf.Widgets[13];
                personalityBox.Text = "Background Personality Traits";

                PdfTextBox strmodBox = (PdfTextBox)pdf.Widgets[14];
                strmodBox.Text = pc.getSTRMod().ToString();

                //assuming level 1 character
                PdfTextBox maxhpBox = (PdfTextBox)pdf.Widgets[15];
                maxhpBox.Text = pc.pClass.hit.ToString();

                PdfTextBox strsaveBox = (PdfTextBox)pdf.Widgets[16];
                //strsaveBox.Text = pc.getSTRSave().ToString();
                strsaveBox.Text = pc.getSTRMod().ToString();

                PdfTextBox dexterityBox = (PdfTextBox)pdf.Widgets[17];
                dexterityBox.Text = pc.getDEX().ToString();

                //Widget 18: Current HP; leaving blank

                PdfTextBox idealsBox = (PdfTextBox)pdf.Widgets[19];
                idealsBox.Text = "Background Ideal";

                PdfTextBox dexmodBox = (PdfTextBox)pdf.Widgets[20];
                dexmodBox.Text = pc.getDEXMod().ToString();

                //Widget 21: Temp HP; leaving blank

                PdfTextBox bondsBox = (PdfTextBox)pdf.Widgets[22];
                bondsBox.Text = "Background Bond";

                PdfTextBox constitutionBox = (PdfTextBox)pdf.Widgets[23];
                constitutionBox.Text = pc.getCON().ToString();

                //assuming level 1 character
                PdfTextBox hitdicetotalBox = (PdfTextBox)pdf.Widgets[24];
                hitdicetotalBox.Text = "1";

                //Widgets 25, 26, & 27: Death Saves; leaving unchecked

                PdfTextBox conmodBox = (PdfTextBox)pdf.Widgets[28];
                conmodBox.Text = pc.getCONMod().ToString();

                //Widgets 29, 30, & 31: Death Saves; leaving unchecked

                PdfTextBox hitdiceBox = (PdfTextBox)pdf.Widgets[32];
                hitdiceBox.Text = "d" + pc.pClass.hit.ToString();

                PdfTextBox flawsBox = (PdfTextBox)pdf.Widgets[33];
                flawsBox.Text = "Character Flaws";

                PdfTextBox intelligenceBox = (PdfTextBox)pdf.Widgets[34];
                intelligenceBox.Text = pc.getINT().ToString();

                PdfTextBox dexsaveBox = (PdfTextBox)pdf.Widgets[35];
                //dexsaveBox.Text = pc.getDEXSave().ToString();
                dexsaveBox.Text = pc.getDEXMod().ToString();

                PdfTextBox consaveBox = (PdfTextBox)pdf.Widgets[36];
                //consaveBox.Text = pc.getCONSave().ToString();
                consaveBox.Text = pc.getCONMod().ToString();

                PdfTextBox intsaveBox = (PdfTextBox)pdf.Widgets[37];
                //intsaveBox.Text = pc.getINTSave().ToString();
                intsaveBox.Text = pc.getINTMod().ToString();

                PdfTextBox wissaveBox = (PdfTextBox)pdf.Widgets[38];
                //wissaveBox.Text = pc.getWISSave().ToString();
                wissaveBox.Text = pc.getWISMod().ToString();

                PdfTextBox chasaveBox = (PdfTextBox)pdf.Widgets[39];
                //chasaveBox.Text = pc.getCHASave().ToString();
                chasaveBox.Text = pc.getCHAMod().ToString();

                PdfTextBox acrobaticsBox = (PdfTextBox)pdf.Widgets[40];
                acrobaticsBox.Text = pc.getAcrobatics().ToString();

                PdfTextBox animalhandlingBox = (PdfTextBox)pdf.Widgets[41];
                animalhandlingBox.Text = pc.getAnimalHanding().ToString();


                pdf.Save(pathToFile);
            }

            Process.Start(pathToFile);

        }
    }
}
