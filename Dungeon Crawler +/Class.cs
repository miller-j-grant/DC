using System.Collections;

namespace Dungeon_Crawler__
{
    class Class
    {
        private string className { get; }
        private int hit { get; }

        // Proficiences ArrayList contains saves, skills, equipment
        private ArrayList prof { get; }

        // Static Array for now, might make it an ArrayList later
        private ArrayList skills { get; }
        private int choose { get; }


        // Soon TM
        // Since equipment has their own stats, probably should make a class. 
        // Will need to seperate into armor, weapons, tools
        // private Item() equip; <- jk not in this class or right now, but commenting as we might do something with it laster
        private string[] equip { get; }
        private int wealth { get; }

        // Features
        private ArrayList ft { get; }

        // might need its own class @_@
        private ArrayList spells { get; };


        public Class()
        {

        }

        public Class(string selectClass)
        {
            if(selectClass.Equals("Barbarian"))
            {
                className = "Barbarian";
                hit = 12;
                // long strings might get long
                prof.Add("Strength");
                prof.Add("Constituion");
                prof.Add("Light armor");
                prof.Add("Medium armor");
                prof.Add("Shields");
                prof.Add("Simple weapons");
                prof.Add("Martial weapons");
                
                // number of skills to be selected
                choose = 2;
                //skills are to be selected from the amount above and then added to the prof Arraylist
                skills.Add("Animal Handling");
                skills.Add("Athletics");
                skills.Add("Intimidation");
                skills.Add("Nature");
                skills.Add("Preception");
                skills.Add("Survival");
                // not quite sure how to go about these, selected items will be added to inventory ArrayList
                equip = new string[] { "Greataxe or an martial weapon", "Two handaxes or any simple weapon",
                    "An explorer's pack and four javelins" };

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.
                ft.Add("Rage");
                ft.Add("Unarmored Defense");

            }
        }


    }
}
