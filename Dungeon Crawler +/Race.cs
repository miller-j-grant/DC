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
        private int[] stats { get; }

        // size could either be a String that we read or a number that we correspond with a size
        // might be easier to do number, but we'll see
        private string size { get; }

        private int speed { get; }

        private ArrayList traits { get; }

        private ArrayList tDesc { get; }

        private ArrayList languages { get; }

        // this might be dumb, but it's like 3:45am so whatever
        private ArrayList subrace { get; }

        public Race()
        {
            stats = new int[6] { 0, 0, 0, 0, 0, 0 };
            traits = new ArrayList();
            languages = new ArrayList();
            subrace = new ArrayList();
        }

        public Race(string race)
        {
            if (race.Equals("Dwarf"))
            {
                raceName = "Dwarf";

                stats = new int[6] { 0, 0, 2, 0, 0, 0 };
                size = "Medium";
                speed = 25;

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                traits.Add("Tool Proficiency");
                traits.Add("Stonecunning");

                tDesc.Clear();

                tDesc.Add("You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You have advantage on saving throws against poison, and you have resistance against poison damage.");
                tDesc.Add("You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer.");
                tDesc.Add("You gain proficiency with the artisan's tools of your choice: smith's tools, brewer's supplies, or mason's tools.");
                tDesc.Add("Whenever you make an Intelligence(History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check.");

                languages.Clear();

                languages.Add("Common");
                languages.Add("Dwarvish");

                subrace.Clear();

                subrace.Add("Hill Dwarf");
                subrace.Add("Mountain Dwarf");
            }

            if (race.Equals("Elf"))
            {
                raceName = "Elf";

                stats = new int[6] { 0, 2, 0, 0, 0, 0 };
                size = "Medium";
                speed = 30;

                traits.Clear();

                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");

                tDesc.Clear();

                tDesc.Add("You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You have proficiency in the Perception skill.");
                tDesc.Add("You have advantage on saving throws against being charmed, and magic can't put you to sleep.");
                tDesc.Add("Elves don't need to sleep. Instead, they meditate deeply, remaining semiconscious for 4 hours a day. After resting this way, you gain the same benefit that a human does from 8 hours of sleep.");

                languages.Clear();

                languages.Add("Common");
                languages.Add("Elvish");

                subrace.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");

                tDesc.Clear();

                tDesc.Add("When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.");
                tDesc.Add("You have advantage on saving throws against being frightened.");
                tDesc.Add("You can move throught the space of any creature that is of a size larger than yours.");

                languages.Clear();

                languages.Add("Common");
                languages.Add("Halfling");

                subrace.Clear();

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

                languages.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Draconic Ancestry");
                //USER MUST PICK A DRAGON ANCESTRY FROM THE INCLUDED TABLE.
                traits.Add("Breath Weapon");
                traits.Add("Damage Resistance");

                tDesc.Clear();

                tDesc.Add("Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the type.");
                tDesc.Add("You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage of the exhalation.");
                tDesc.Add("You have resistance to the damage type associated with your draconic ancestry.");

                languages.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");

                tDesc.Clear();

                tDesc.Add("You can see in dim light 60 feet of you as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You have advantage on all Intellegence, Wisdom, and Charisma saving throws against magic.");

                languages.Clear();

                languages.Add("Common");
                languages.Add("Gnomish");

                subrace.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Fey Ancestry");
                traits.Add("Skill Versatility");
                //USER MUST SELECT TWO SKILLS TO GET PROFICIENCY IN.

                tDesc.Clear();

                tDesc.Add("You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You have advantage on saving throws against being charmed, and magic can't put you to sleep.");
                tDesc.Add("You gain proficiency in two skills of your choice.");

                languages.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Menacing");
                traits.Add("Relentless Endurance");
                traits.Add("Savage Attacks");

                tDesc.Clear();

                tDesc.Add("You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You gain proficiency in the Intimidation skill.");
                tDesc.Add("When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can't use this feature agiain until you finish a long rest.");
                tDesc.Add("When you score a critical hit with a melee weapon attack, you can roll one of the weapon's damage dice one additional time and add it to the extra damage of the critical hit.");

                languages.Clear();

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

                traits.Clear();

                //MAKE TRAITS INTO DATABASE AT LATER TIME IN ORDER TO FETCH DESCRIPTIONS EASIER.
                traits.Add("Darkvision");
                traits.Add("Hellish Resistance");
                traits.Add("Infernal Legacy");

                tDesc.Clear();

                tDesc.Add("You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.");
                tDesc.Add("You have resistance to fire damage.");
                tDesc.Add("You know the thaumaturgy cantrip. At 3rd level, you can cast hellish rebuke 1/day. At 5th level, you can cast darkness 1/day. These are tested as CHA.");

                languages.Clear();

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

        public ArrayList getTDesc()
        {
            return tDesc;
        }
    }
}
