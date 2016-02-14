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
            if (race.Equals("Elf")){
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

            if (race.Equals("Dwarf"))
            {

            }

        }
    }
}
