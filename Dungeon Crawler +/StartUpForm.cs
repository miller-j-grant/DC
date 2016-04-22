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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// New Character
        /// </summary>
        private void newButton_Click(object sender, EventArgs e)
        {
            fCChar fCC = new fCChar();
            fCC.ShowDialog();
        }

        /// <summary>
        /// Random Character
        /// </summary>
        private void randomButton_Click(object sender, EventArgs e)
        {
            Character random = new Character();
            for(int x = 0; x < 6; x++)
            {
                random.baseAS[x] = Calculations.rollAbilityScore();
            }
            random.setRace(Calculations.randomRace());
            random.setStats(random.race.getStats());
            random.setStrMod(Calculations.calcMod(random.getSTR()));
            random.setDexMod(Calculations.calcMod(random.getDEX()));
            random.setConMod(Calculations.calcMod(random.getCON()));
            random.setWisMod(Calculations.calcMod(random.getWIS()));
            random.setIntelMod(Calculations.calcMod(random.getINT()));
            random.setChaMod(Calculations.calcMod(random.getCHA()));
            random.setClass(Calculations.randomClass());
            random.setBackground(Calculations.randomBackground());
            random.name = Calculations.randomName();
            random.player = "Random";
            random.age = "";
            random.eye = "";
            random.height = "";
            random.hair = "";
            random.weight = "";
            random.skin = "";
            random.alignment = "";
            random.backstory = "";
            random.skills = Calculations.calcSkills(random.statmods, random.proficiency, random.profbonus);
            PDFInterface.finalize(random);
        }
    }
}
