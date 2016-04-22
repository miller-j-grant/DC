using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{
	/// <summary>
	/// A class that contains all details specific to equipment </summary>
	/// <remarks>
	/// author: Patrick Dishaw, Grant Miller, Mitch Couturier
	/// version: 2/22/2016 </remarks>
    class Equipment
    {
        public string name { get; set; }
        public string type { get; }
        
        //=====ARMOR ONLY======
		/// <summary>  </summary>
        public int ac { get; set; }

        //=====WEAPON ONLY======
		/// <summary>  </summary>
        public string roll { get; set; }
		/// <summary> damage type: piercing, bludgeoning, slashing, - </summary>
        public string damage { get; set; }

		/// <summary>
        /// lolz
        /// </summary>
        public Equipment()
        {

        }

		/// <summary>
        /// Determines the category of the equipment object and then initializes for 
		/// that category </summary>
		/// <param name="cate"> Equipment is split into  three categories: Armor, Weapon, Tool </param>
		/// <param name="n"> This represents what the name of this item is </param>
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

        /// <summary>
        /// Initializes an Armor item based on the name parameter </summary>
        /// <param name="n"> This represents what the name of this item is </param>
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

        /// <summary>
        /// Initializes a Weapon item based on the name parameter </summary>
        /// <param name="n"> This represents what the name of this item is </param>
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

