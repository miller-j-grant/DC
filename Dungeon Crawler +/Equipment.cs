using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
    class Equipment
    {
        public string name { get; set; }
        public string type { get; }

        //armor only
        public int ac { get; set; }

        // weapon only
        public string roll { get; set; }
        // damage type: piercing, bludgeoning, slashing, -
        public string damage { get; set; }


        public Equipment()
        {

        }

        // equipment is split into  three categories: Armor, Weapon, Tool
        public Equipment(string cate, string n)
        {
            
            if (cate.Equals("ARMOR"))
            {
                Armor(n);
            }

            if (cate.Equals("WEAPON"))
            {
                Weapon(n);
            }
            else
            {
                //You done messed up, son
            }

        }

        public Equipment Armor(string n)
        {
            Equipment armor = new Equipment();
            if (n.Equals("Leather armor"))
            {
                name = "Leather Armor";
                ac = 11;
            }

            else if (n.Equals("Scale Mail"))
            {
                name = "Scale Mail";
                ac = 14;
            }

            else if (n.Equals("Chain Mail"))
            {
                name = "Chain Mail";
                ac = 16;
            }
            else
            {
                name = "Unarmored";
                ac = 10;
            }

            return armor;
        }

        public Equipment Weapon(string n)
        {
            Equipment weapon = new Equipment();
            
            if (n.Equals("Dagger"))
            {
                name = "Dagger";
                roll = "1d4";
                damage = "P";
            }

            else if (n.Equals("Handaxe"))
            {
                name = "Handaxe";
                roll = "1d6";
                damage = "S";
            }

            else if (n.Equals("Javelin"))
            {
                name = "Javelin";
                roll = "1d6";
                damage = "P";
            }

            else if (n.Equals("Mace"))
            {
                name = "Mace";
                roll = "2d6";
                damage = "B";
            }

            else if (n.Equals("Quarterstaff"))
            {
                name = "Quarterstaff";
                roll = "1d6";
                damage = "B";
            }

            else if (n.Equals("Light Crossbow"))
            {
                name = "Light Crossbow";
                roll = "1d8";
                damage = "P";
            }

            else if (n.Equals("Dart"))
            {
                name = "Dart";
                roll = "1d4";
                damage = "P";
            }

            else if (n.Equals("Shortbow"))
            {
                name = "Shortbow";
                roll = "1d6";
                damage = "P";
            }

            else if (n.Equals("Greataxe"))
            {
                name = "Greataxe";
                roll = "1d12";
                damage = "S";
            }

            else if (n.Equals("Rapier"))
            {
                name = "Rapier";
                roll = "1d8";
                damage = "P";
            }

            else if (n.Equals("Scimitar"))
            {
                name = "Scimitar";
                roll = "1d6";
                damage = "S";
            }

            else if (n.Equals("Shortsword"))
            {
                name = "Shortsword";
                roll = "1d6";
                damage = "P";
            }

            else if (n.Equals("Longbow"))
            {
                name = "Longbow";
                roll = "1d8";
                damage = "P";
            }

            else
            {
                name = "Unarmed";
                roll = "1";
                damage = "B";
            }

            return weapon;
        }

    }
}

