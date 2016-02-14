using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    class Equipment
    {

        private string equip;

        private string type;
        private string subtype;

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
        private string roll;
        // damage type: piercing, bludgeoning, slashing, -
        private string damage;
        // properties
        private string[] prop;


        public Equipment()
        {

        }

        // equipment is split into  three categories: Armor, Weapon, Tool
        public Equipment(string cate, string name)
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

        public void Armor(string name)
        {
            if (name.Equals("Padded"))
            {
                // converted to cp
                cost = 500;
                lb = 8;
                subtype = "Light";
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

        public void Weapon(string name)
        {

        }

        public void Tool(string name)
        {

        }


    }
}

