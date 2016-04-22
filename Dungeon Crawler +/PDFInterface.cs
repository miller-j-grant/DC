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
    class PDFInterface
    {


        public static void finalize(Character pc)
        {
            BitMiracle.Docotic.LicenseManager.AddLicenseData("4L4F2-CN67H-38NDJ-2K1HA-NBODQ");
            string pathToFile = "FilledSheet.pdf";
            for (int x = 0; x < 1; x++)
            {
                using (PdfDocument pdf = new PdfDocument("CharacterSheet.pdf"))
                {
                    try
                    {
                        PdfTextBox classBox = (PdfTextBox)pdf.Widgets[0];
                        classBox.Text = pc.pClass.className + " 1";
                    }
                    catch
                    {
                        MessageBox.Show("A class was not selected", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    try
                    {
                        PdfTextBox backgroundBox = (PdfTextBox)pdf.Widgets[1];
                        backgroundBox.Text = pc.bg.background;
                    }
                    catch
                    {
                        MessageBox.Show("A background was not selected", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    try
                    {
                        PdfTextBox playerBox = (PdfTextBox)pdf.Widgets[2];
                        playerBox.Text = pc.player;
                    }
                    catch
                    {
                        PdfTextBox playerBox = (PdfTextBox)pdf.Widgets[2];
                        playerBox.Text = "";
                    }

                    try
                    {
                        PdfTextBox characterBox = (PdfTextBox)pdf.Widgets[3];
                        characterBox.Text = pc.name;
                    }
                    catch
                    {
                        PdfTextBox characterBox = (PdfTextBox)pdf.Widgets[3];
                        characterBox.Text = "";
                    }

                    try
                    {
                        PdfTextBox raceBox = (PdfTextBox)pdf.Widgets[4];
                        raceBox.Text = pc.race.getRaceName();
                    }
                    catch
                    {
                        MessageBox.Show("A race was not selected", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }


                    PdfTextBox alignmentBox = (PdfTextBox)pdf.Widgets[5];
                    alignmentBox.Text = pc.alignment;

                    //assuming level 1 character
                    PdfTextBox expBox = (PdfTextBox)pdf.Widgets[6];
                    expBox.Text = "0 / 300";

                    //Widget 7: Inspiration; left blank on character sheet 

                    try
                    {
                        PdfTextBox strengthBox = (PdfTextBox)pdf.Widgets[8];
                        strengthBox.Text = pc.getSTR().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Strength stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    //assuming level 1 character
                    PdfTextBox proficiencyBox = (PdfTextBox)pdf.Widgets[9];
                    proficiencyBox.Text = "2";

                    //needs to important character's armor
                    PdfTextBox armorclassBox = (PdfTextBox)pdf.Widgets[10];
                    if(pc.pClass.shield == true)
                    {
                        armorclassBox.Text = Calculations.calcAC(pc.pClass.armor.ac, pc.getDEXMod(), 2).ToString();
                    }
                    else
                    {
                        armorclassBox.Text = Calculations.calcAC(pc.pClass.armor.ac, pc.getDEXMod(), 0).ToString();
                    }
                    

                    PdfTextBox initiativeBox = (PdfTextBox)pdf.Widgets[11];
                    initiativeBox.Text = Calculations.calcInitiative(pc.getDEXMod(), 0).ToString();

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

                    try
                    {
                        PdfTextBox dexterityBox = (PdfTextBox)pdf.Widgets[17];
                        dexterityBox.Text = pc.getDEX().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Dexterity stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }


                    //Widget 18: Current HP; is left blank on character sheets

                    PdfTextBox idealsBox = (PdfTextBox)pdf.Widgets[19];
                    idealsBox.Text = "Background Ideal";

                    PdfTextBox dexmodBox = (PdfTextBox)pdf.Widgets[20];
                    dexmodBox.Text = pc.getDEXMod().ToString();

                    //Widget 21: Temp HP; leaving blank

                    PdfTextBox bondsBox = (PdfTextBox)pdf.Widgets[22];
                    bondsBox.Text = "Background Bond";

                    try
                    {
                        PdfTextBox constitutionBox = (PdfTextBox)pdf.Widgets[23];
                        constitutionBox.Text = pc.getCON().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Constitution stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    //assuming level 1 character
                    PdfTextBox hitdicetotalBox = (PdfTextBox)pdf.Widgets[24];
                    hitdicetotalBox.Text = "1";

                    //Widgets 25, 26, & 27: Death Saves; left unchecked on character sheets

                    PdfTextBox conmodBox = (PdfTextBox)pdf.Widgets[28];
                    conmodBox.Text = pc.getCONMod().ToString();

                    //Widgets 29, 30, & 31: Death Saves; left unchecked on character sheets

                    //Widget 32: hit dice box; left empty on character sheets

                    PdfTextBox flawsBox = (PdfTextBox)pdf.Widgets[33];
                    flawsBox.Text = "Character Flaws";

                    try
                    {
                        PdfTextBox intelligenceBox = (PdfTextBox)pdf.Widgets[34];
                        intelligenceBox.Text = pc.getINT().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Intelligence stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

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

                    PdfTextBox athleticsBox = (PdfTextBox)pdf.Widgets[42];
                    athleticsBox.Text = pc.getAthletics().ToString();

                    PdfTextBox deceptionBox = (PdfTextBox)pdf.Widgets[43];
                    deceptionBox.Text = pc.getDeception().ToString();

                    PdfTextBox historyBox = (PdfTextBox)pdf.Widgets[44];
                    historyBox.Text = pc.getHistory().ToString();

                    PdfTextBox insightBox = (PdfTextBox)pdf.Widgets[45];
                    insightBox.Text = pc.getInsight().ToString();

                    PdfTextBox intimidationBox = (PdfTextBox)pdf.Widgets[46];
                    intimidationBox.Text = pc.getIntimidation().ToString();

                    //Widgets 47-52: checkboxes; not yet known

                    PdfTextBox weapon1Box = (PdfTextBox)pdf.Widgets[53];
                    weapon1Box.Text = pc.pClass.weapon1.name;

                    PdfTextBox attackbonus1Box = (PdfTextBox)pdf.Widgets[54];
                    attackbonus1Box.Text = pc.pClass.weapon1.roll;

                    PdfTextBox damage1Box = (PdfTextBox)pdf.Widgets[55];
                    damage1Box.Text = pc.pClass.weapon1.damage;

                    PdfTextBox intmodBox = (PdfTextBox)pdf.Widgets[56];
                    intmodBox.Text = pc.getINTMod().ToString();

                    PdfTextBox weapon2Box = (PdfTextBox)pdf.Widgets[57];
                    weapon2Box.Text = pc.pClass.weapon2.name;

                    PdfTextBox attackbonus2Box = (PdfTextBox)pdf.Widgets[58];
                    attackbonus2Box.Text = pc.pClass.weapon2.roll;

                    PdfTextBox damage2Box = (PdfTextBox)pdf.Widgets[59];
                    damage2Box.Text = pc.pClass.weapon2.damage;

                    PdfTextBox investigationBox = (PdfTextBox)pdf.Widgets[60];
                    investigationBox.Text = pc.getInvestigation().ToString();

                    try
                    {
                        PdfTextBox wisdomBox = (PdfTextBox)pdf.Widgets[61];
                        wisdomBox.Text = pc.getWIS().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Wisdom stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    PdfTextBox weapon3Box = (PdfTextBox)pdf.Widgets[62];
                    weapon3Box.Text = pc.pClass.weapon3.name;

                    PdfTextBox attackbonus3Box = (PdfTextBox)pdf.Widgets[63];
                    attackbonus3Box.Text = pc.pClass.weapon3.roll;

                    //Arcana in the middle here for some reason. Yes it is supposed to be here
                    PdfTextBox arcanaBox = (PdfTextBox)pdf.Widgets[64];
                    arcanaBox.Text = pc.getArcana().ToString();

                    PdfTextBox damage3Box = (PdfTextBox)pdf.Widgets[65];
                    damage3Box.Text = pc.pClass.weapon3.damage;


                    PdfTextBox perceptionBox = (PdfTextBox)pdf.Widgets[66];
                    perceptionBox.Text = pc.getPerception().ToString();

                    PdfTextBox wismodBox = (PdfTextBox)pdf.Widgets[67];
                    wismodBox.Text = pc.getWISMod().ToString();

                    try
                    {
                        PdfTextBox charismaBox = (PdfTextBox)pdf.Widgets[68];
                        charismaBox.Text = pc.getCHA().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Charisma stat was not assigned", "Finalize Error", MessageBoxButtons.OK);
                        break;
                    }

                    PdfTextBox natureBox = (PdfTextBox)pdf.Widgets[69];
                    natureBox.Text = pc.getNature().ToString();

                    PdfTextBox performanceBox = (PdfTextBox)pdf.Widgets[70];
                    performanceBox.Text = pc.getPerformance().ToString();

                    PdfTextBox medicineBox = (PdfTextBox)pdf.Widgets[71];
                    medicineBox.Text = pc.getMedicine().ToString();

                    PdfTextBox religionBox = (PdfTextBox)pdf.Widgets[72];
                    religionBox.Text = pc.getReligion().ToString();

                    PdfTextBox stealthBox = (PdfTextBox)pdf.Widgets[73];
                    stealthBox.Text = pc.getStealth().ToString();

                    //Widgets 74-91: PDF Checkboxes probably skill

                    PdfTextBox persuasionBox = (PdfTextBox)pdf.Widgets[92];
                    persuasionBox.Text = pc.getPersuasion().ToString();

                    PdfTextBox sleightofhandBox = (PdfTextBox)pdf.Widgets[93];
                    sleightofhandBox.Text = pc.getSleightofHand().ToString();

                    PdfTextBox chamodBox = (PdfTextBox)pdf.Widgets[94];
                    chamodBox.Text = pc.getCHAMod().ToString();

                    PdfTextBox survivalBox = (PdfTextBox)pdf.Widgets[95];
                    survivalBox.Text = pc.getSurvival().ToString();

                    //Widget 96: Attacks & Spellcasting; left blank on sheet

                    PdfTextBox passivewisBox = (PdfTextBox)pdf.Widgets[97];
                    passivewisBox.Text = Calculations.calcPassWis(pc.getPerception()).ToString();

                    //Widget 98: Copper Pieces; left blank on sheet

                    PdfTextBox proflangBox = (PdfTextBox)pdf.Widgets[99];
                    //proflangBox.Text = 

                    //Widget 100: Silver Pieces; left blank on sheet

                    //Widget 101: Electrum Pieces; left blank on sheet

                    PdfTextBox wealthBox = (PdfTextBox)pdf.Widgets[102];
                    wealthBox.Text = Calculations.calcWealth(pc.pClass.ToString()).ToString();

                    //Widget 103: Platinum Pieces; left blank on sheet

                    PdfTextBox equipmentBox = (PdfTextBox)pdf.Widgets[104];
                    string equip = "";
                    foreach (string element in pc.pClass.equip)
                    {
                        equip = equip + element + "\n";

                    }
                    equipmentBox.Text = equip;

                    //!! Widget 105: Features & Traits !!

                    try
                    {
                        PdfTextBox characterBox = (PdfTextBox)pdf.Widgets[106];
                        characterBox.Text = pc.name;
                    }
                    catch
                    {
                        PdfTextBox characterBox = (PdfTextBox)pdf.Widgets[106];
                        characterBox.Text = "";
                    }

                    PdfTextBox ageBox = (PdfTextBox)pdf.Widgets[107];
                    ageBox.Text = pc.age;

                    PdfTextBox heightBox = (PdfTextBox)pdf.Widgets[108];
                    heightBox.Text = pc.height;

                    PdfTextBox weightBox = (PdfTextBox)pdf.Widgets[109];
                    weightBox.Text = pc.weight;

                    PdfTextBox eyeBox = (PdfTextBox)pdf.Widgets[110];
                    eyeBox.Text = pc.eye;

                    PdfTextBox skinBox = (PdfTextBox)pdf.Widgets[111];
                    skinBox.Text = pc.skin;

                    PdfTextBox hairBox = (PdfTextBox)pdf.Widgets[112];
                    hairBox.Text = pc.hair;

                    //Widget 113: Appearance; left blank on sheet

                    //Widget 114: Allies & Organizations; left blank on sheet

                    //Widget 115: Allies & Organizations names; left blank on sheet

                    PdfTextBox backstoryBox = (PdfTextBox)pdf.Widgets[116];
                    backstoryBox.Text = pc.backstory;

                    pdf.Save(pathToFile);
                }


                Process.Start(pathToFile);
            }
        }

    }
}
