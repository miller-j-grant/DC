using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Dungeon_Crawler__
{


    class Race
    {
        private string raceName;
        
        // racial ability score bonuses
        // 0 Str, 1 Dex, 2 Con, 3 Int, 4 Wis, 5 Cha
        private int[] stats;

        // size could either be a String that we read or a number that we correspond with a size
        // might be easier to do number, but we'll see
        private string size;

        private int speed;

        private ArrayList traits;

        private ArrayList languages;

        // this might be dumb, but it's like 3:45am so whatever
        private ArrayList subrace;

        public Race()
        {
            stats = new int[6] { 0, 0, 0, 0, 0, 0 };

            size = null;

            speed = 0;

            languages = null;
        }

        public Race(string race)
        {
            if (race.Equals("Dwarf"))
            {
                raceName = "Dwarf";

                stats = new int[6] { 0, 0, 2, 0, 0, 0 };
                size = "Medium";
                speed = 25;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                traits.Add("Tool Proficiency");
                traits.Add("Stonecunning");

                languages.Add("Common");
                languages.Add("Dwarvish");

                subrace.Add("Hill Dwarf");
                subrace.Add("Mountain Dwarf");
            }

            if (race.Equals("Elf"))
            {
                raceName = "Elf";

                stats = new int[6] { 0, 2, 0, 0, 0, 0 };
                size = "Medium";
                speed = 30;

                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");

                languages.Add("Common");
                languages.Add("Elvish");

                subrace.Add("High Elf");
                subrace.Add("Wood Elves");
                subrace.Add("Drow");
            }

            if (race.Equals("Halfling"))
            {
                raceName = "Halfling";

                stats = new int[6] { 0, 2, 0, 0, 0, 0 };
                size = "Small";
                speed = 25;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");

                languages.Add("Common");
                languages.Add("Halfling");

                subrace.Add("Lightfoot");
                subrace.Add("Stout");
            }

            if (race.Equals("Human"))
            {
                raceName = "Human";

                stats = new int[6] { 1, 1, 1, 1, 1, 1};
                size = "Medium";
                speed = 30;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.

                languages.Add("Common");
                //HUMANS GET AN EXTRA LANGUAGE, WHICH NEEDS TO BE PICKED BY THE USER languages.Add();

                //HUMANS DO NOT HAVE ANY SUBRACES.
            }

            if (race.Equals("Dragonborn"))
            {
                raceName = "Dragonborn";

                stats = new int[6] { 2, 0, 0, 0, 0, 1};
                size = "Medium";
                speed = 30;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Draconic Ancestry");
                //USER MUST PICK A DRAGON ANCESTRY FROM THE INCLUDED TABLE.
                traits.Add("Breath Weapon");
                traits.Add("Damage Resistance");

                languages.Add("Common");
                languages.Add("Draconic");

                //DRAGONBORN DO NOT HAVE SUBRACES.
            }

            if (race.Equals("Gnome"))
            {
                raceName = "Gnome";

                stats = new int[6] { 0, 0, 0, 2, 0, 0 };
                size = "Small";
                speed = 25;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");

                languages.Add("Common");
                languages.Add("Gnomish");

                subrace.Add("Forest Gnome");
                subrace.Add("Rock Gnome");
            }

            if (race.Equals("Half-Elf"))
            {
                raceName = "Half-Elf";

                stats = new int[6] { 0, 0, 0, 0, 0, 2};
                //USER MUST PICK TWO DIFFERENT ATTRIBUTES TO PUT 1 POINT INTO.
                size = "Medium";
                speed = 30;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Fey Ancestry");
                traits.Add("Skill Versatility");
                //USER MUST SELECT TWO SKILLS TO GET PROFICIENCY IN.

                languages.Add("Common");
                languages.Add("Elvish");
                //USER MUST SELECT ANOTHER LANGUAGE languages.Add();

                //HALF-ELVES DO NOT HAVE ANY SUBRACES.
            }

            if (race.Equals("Half-Orc"))
            {
                raceName = "Half-Orc";

                stats = new int[6] { 2, 0, 1, 0, 0, 0 };
                size = "Medium";
                speed = 30;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Menacing");
                traits.Add("Relentless Endurance");
                traits.Add("Savage Attacks");

                languages.Add("Common");
                languages.Add("Orc");

                //HALF-ORC DOES NOT HAVE ANY SUBRACES.
            }

            if (race.Equals("Tiefling"))
            {
                raceName = "Tiefling";

                stats = new int[6] { 0, 0, 0, 1, 0, 2};
                size = "Medium";
                speed = 30;

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Hellish Resistance");
                traits.Add("Infernal Legacy");

                languages.Add("Common");
                languages.Add("Infernal");

                //TIEFLING DO NOT HAVE SUBRACES.
            }
        }

        public ArrayList getTraits()
        {
            return traits;
        }

        public ArrayList getLanguages()
        {
            return languages;
        }

        public int[] getStats()
        {
            return stats;
        }

        public ArrayList getSubrace()
        {
            return subrace;
        }

        public String getRaceName()
        {
            return raceName;
        }

        public String getSize()
        {
            return size;
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
