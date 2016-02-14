using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{

    // not entirely sold on this class
    // honestly, Backgrounds are the biggest drawback to 5E
    // but it is technically optional, sooooooo ><
    class Background
    {
        private ArrayList prof;
        private ArrayList lang;
        private ArrayList equip;
        private int wealth;
        private string ft;

        // extra is for like Charlatan "Favorite Schemes"
        private string []extra;

        // Personality Trait
        private string[] person;
        private string[] ideal;
        private string[] bond;
        private string[] flaw;

        public Background()
        {

        }

        public Background(string bg)
        {
            if (bg.Equals("Acolyte"))
            {
                prof.Add("Insight");
                prof.Add("Religion");

                lang.Add("Two of your choice");

                equip.Add("Holy Symbol");
                equip.Add("Prayer book or prayer wheel");
                equip.Add("5 sticks of incense");
                equip.Add("Vestments");
                equip.Add("Common clothes");

                // in gp
                wealth = 15;
                ft = "Shelther of the Faithful";

                // OTL fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
                person = new string[] { "1: I idolize a particular hero of my faith, and constantly refer to that person's deeds and example.",
                    "2: I can find common ground between the fiercest enemies, empathizing with them and always working toward peace.",
                    "etc" };

                ideal = new string[] { "1: Tradtion - The ancient traditions of worship and sacrifice must be preserved and upheld.",
                    "etc." };

                bond = new string[] { "1: I would die to recover an ancient relic of m faith that was lost long ago.",
                    "etc." };

                flaw = new string[] { "1: I judge others harshly, and myself even more severely.",
                    "etc." };

                if(bg.Equals("Charlatan"))
                {
                    // moo
                }
            }
        }
    }
}
