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
        private void button1_Click(object sender, EventArgs e)
        {

            //Run fCChar.cs

        }

        /// <summary>
        /// Load Character
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            string filename = "";
            //Reminds the user to enter a filename to load a character
            if (textBox1.Text.Equals("*Enter Filename*") || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please enter a filename.",
                                "Invalid filename");
            }
            else
            {
                filename = textBox1.Text;

                //run load character method?

            }
        }

        /// <summary>
        /// Random Character
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {

            //run random method?

        }
    }
}
