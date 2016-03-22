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
		/// <summary>  </summary>
        private string equip { get; }
		
		/// <summary>  </summary>
        private string type { get; }
		
		/// <summary>  </summary>
        private string subtype { get; }

        // might wanna do this in terms of cp and convert?
		/// <summary>  </summary>
        private int cost { get; }

        //weight
		/// <summary>  </summary>
        private int lb { get; }

        //=====ARMOR ONLY======
		/// <summary>  </summary>
        private int ac { get; }
		
		/// <summary>  </summary>
        private int maxdex { get; }
		
		/// <summary>  </summary>
        private int reqstr { get; }
		
        // true: gives disadvantage to steath; false: does not
		/// <summary>  </summary>
        Boolean steath { get; }

        //=====WEAPON ONLY======
		/// <summary>  </summary>
        private string roll { get; }
		
        // damage type: piercing, bludgeoning, slashing, -
		/// <summary>  </summary>
        private string damage { get; }
		
        // properties
		/// <summary>  </summary>
        private string[] prop { get; }

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
		/// <param name="name"> This represents what the name of this item is </param>
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
		
		/// <summary>
        /// Initializes an Armor item based on the name parameter </summary>
		/// <param name="name"> This represents what the name of this item is </param>
        public void Armor(string name)
        {
            if (name.Equals("Padded"))
            {
                // converted to cp
                //cost = 500;
                //lb = 8;
                //subtype = "Light";
                //ac = 11;
                //maxdex = 0;
                //reqstr = 0;
                //steath = true;
            }

            if (name.Equals("Leather"))
            {
                //gg you're not a nerd with padded armor
            }
        }

		/// <summary>
        /// Initializes a Weapon item based on the name parameter </summary>
		/// <param name="name"> This represents what the name of this item is </param>
        public void Weapon(string name)
        {

        }

		/// <summary>
        /// Initializes a Tool item based on the name parameter </summary>
		/// <param name="name"> This represents what the name of this item is </param>
        public void Tool(string name)
        {

        }


    }
}

