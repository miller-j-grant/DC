using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    class Class
    {

        private int hit;

        // Proficiences, could be broken down into armor, weapons, tools, 
        // don't think needed per say, but it would shorten the string
        private String prof;
        private String saves;
        private String skills;

        // Soon TM
        // Since equipment has their own stats, probably should make a class. 
        // Will need to seperate into armor, weapons, tools
        // private Item() equip; <- jk not in this class or right now, but commenting as we might do something with it laster
        private String equip;
        private int wealth;

        // Features
        private String ft;


        public Class()
        {

        }

        public Class(string pickClass)
        {
            if(pickClass.Equals("Barbarian"))
            {
                hit = 12;
                // long strings might get long
                prof = "Light armor, Medium armor, Shields, "
                    + "Simple weapons, Martial weapons";
                saves = "Strength, Constitution";
                skills = "Animal Handling, Athletics, Intimidation, Nature, Preception, Survival";
                // not quite sure how to go about these 
                equip = "Greataxe or an martial weapon, Two handaxes or any simple weapon, "
                    + "An explorer's pack and four javelins";
                // 2d4 x 10gp; for now I'm putting average
                wealth = 40;
                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.
                ft = "Rage, Unarmored Defense";
            }
        }


    }
}
