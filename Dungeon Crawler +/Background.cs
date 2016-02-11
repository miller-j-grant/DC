using System;
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
        private String skill;
        private String tool;
        private String lang;
        private String equip;
        private String ft;

        // extra is for like Charlatan "Favorite Schemes"
        private String extra;

        // Personality Trait
        private String person;
        private String ideal;
        private String bond;
        private String flaw;

        public Background()
        {

        }

        public Background(String bg)
        {
            if (bg.Equals("Acolyte"))
            {
                skill = "Insight, Religion";
                lang = "Two of your choice";
                equip = "Holy Symbol, Prayer book or prayer wheel, "
                    + "5 sticks of incense, Vestments, Common clothes, 15gp";
                ft = "Shelther of the Faithful";

                // OTL fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
                person = "1: I idolize a particular hero of my faith, and constantly refer to that person's deeds and example. "
                    + "2: I can find common ground between the fiercest enemies, empathizing with them and always working toward peace. "
                    + "etc";

                ideal = "1: Tradtion - The ancient traditions of worship and sacrifice must be preserved and upheld. "
                    + "etc.";

                bond = "1: I would die to recover an ancient relic of m faith that was lost long ago. "
                    + "etc.";

                flaw = "1: I judge others harshly, and myself even more severely. "
                    + "etc.";

                if(bg.Equals("Charlatan"))
                {
                    // moo
                }
            }
        }
    }
}
