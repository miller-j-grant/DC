using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Dungeon_Crawler__
{


    class Race
    {

        // racial ability score bonuses
        private int str;
        private int dex;
        private int con;
        private int intel;
        private int wis;
        private int cha;

        // size could either be a String that we read or a number that we correspond with a size
        // might be easier to do number, but we'll see
        private String size;

        private int speed;

        private String traits;

        private String languages;

        // this might be dumb, but it's like 3:45am so whatever
        private string subrace;

        public Race()
        {
            str = 0;
            dex = 0;
            con = 0;
            intel = 0;
            wis = 0;
            cha = 0;

            size = "Medium";

            speed = 30;

            languages = "Common";
        }

        public Race(string race)
        {
            if (race.Equals("Elf")){
                dex = 2;
                size = "Medium";
                speed = 30;
                traits = "Darkvision, Keen Senses, Fey Ancestry, Trance";
                languages = "Common, Elvish";
                subrace = "High Elf, Wood Elves, Drow";
            }

            if (race.Equals("Dwarf"))
            {

            }

        }
    }
}
