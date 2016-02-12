using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    class Equipment
    {

        private String equip;

        private String type;

        // might wanna do this in terms of cp and convert?
        private int cost;

        //weight
        private int lb;

        //armor only
        private int ac;
        private int maxdex;
        private int reqstr;
        // true: gives disadvantage to steath; false: does not
        Boolean steath;

        // weapon only
        private String roll;
        // damage type: piercing, bludgeoning, slashing, -
        private String damage;
        private String prop;


        // equipment is split into  three categories: Armor, Weapon, Tool
        public Equipment(String cate, String name)
        {

            if (cate.Equals("Armor"))
            {
                Armor(name);
            }

            if (cate.Equals("Weapon"))
            {
                Weapon(name);
            }

            if (cate.Equals("Tool"))
            {
                Tool(name);
            }
            else
            {
                //You done messed up, son
            }

        }

        // doesn't like my constructors at he moment, but it's 5am and I'm tired soooooo I'll worry about that later

        public void Armor(String name)
        {
            if (name.Equals("Padded"))
            {
                // converted to cp
                cost = 500;
                lb = 8;

                ac = 11;
                maxdex = 0;
                reqstr = 0;
                steath = true;
            }

            if (name.Equals("Leather"))
            {
                //gg you're not a nerd with padded armor
            }
        }

        public void Weapon(String name)
        {

        }

        public void Tool(String name)
        {

        }


    }
}

