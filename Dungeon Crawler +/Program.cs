using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawler__
{
    class Program
    {
        private Character pc;

        private string pClass;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public void createChar()
        {
            pc = new Character();
        }


         
    }
}

