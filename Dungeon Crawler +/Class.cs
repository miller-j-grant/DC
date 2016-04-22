using System.Collections;

namespace Dungeon_Crawler__
{
    class Class
    {
        public string className { get; }
        public int hit { get; }

        // Proficiences ArrayList contains saves, skills, equipment
        public ArrayList prof { get; }

        // Static Array for now, might make it an ArrayList later

        private ArrayList skillSelection;

        public ArrayList skills { get; }
        private int choose { get; }


        // Soon TM
        // Since equipment has their own stats, probably should make a class. 
        // Will need to seperate into armor, weapons, tools
        // private Item() equip; <- jk not in this class or right now, but commenting as we might do something with it laster

        public ArrayList equip;
        public Equipment weapon1;
        public Equipment weapon2;
        public Equipment weapon3;
        public Equipment armor;
        public bool shield;
        public int wealth { get; }

        // Features
        public ArrayList ft { get; }

        // might need its own class @_@
        public int firstSpells { get; }
        public int spellsKnown { get; }
        public int cantripsKnown { get; }

        public string martialArts { get; }
        public int ki { get; }

        public string sneakAttack { get; }

        public int invocations { get; }

        public ArrayList spells { get; }

        public ArrayList columns { get; }

        public ArrayList vrow { get; }

        public Class()
        {

        }

        public Class(string conClass)
        {
            prof = new ArrayList();
            skillSelection = new ArrayList();
            ft = new ArrayList();
            equip = new ArrayList();
            spells = new ArrayList();
            columns = new ArrayList();
            vrow = new ArrayList();


            if (conClass.Equals("Barbarian"))
            {
                className = "Barbarian";
                hit = 12;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Strength");
                prof.Add("Constituion");
                prof.Add("Light armor");
                prof.Add("Medium armor");
                prof.Add("Shields");
                prof.Add("Simple weapons");
                prof.Add("Martial weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

               // skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Athletics");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Nature");
                skillSelection.Add("Preception");
                skillSelection.Add("Survival");

                equip.Clear();

                //Class equipment
                weapon1 = new Equipment("WEAPON", "Greataxe");
                weapon2 = new Equipment("WEAPON", "Handaxe");
                weapon3 = new Equipment("WEAPON", "Javelin");
                shield = false;
                armor = new Equipment("ARMOR", "");
                equip.Add(armor.name);
                equip.Add("Explorer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);
            }

            if (conClass.Equals("Bard"))
            {
                className = "Bard";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Dexterity");
                prof.Add("Charisma");
                prof.Add("Light armor");
                prof.Add("Hand Crossbows");
                prof.Add("Longswords");
                prof.Add("Simple weapons");
                prof.Add("Rapiers");
                prof.Add("Shortswords");

                // number of skills to be selected FOR PROFICIENCY
                choose = 3;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Acrobatics");
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Arcana");
                skillSelection.Add("Athletics");
                skillSelection.Add("Deception");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Investigation");
                skillSelection.Add("Medicine");
                skillSelection.Add("Nature");
                skillSelection.Add("Preception");
                skillSelection.Add("Performance");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");
                skillSelection.Add("Slight of Hand");
                skillSelection.Add("Stealth");
                skillSelection.Add("Survival");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Rapier");
                weapon2 = new Equipment("WEAPON", "Dagger");
                weapon3 = new Equipment("WEAPON", "");
                shield = false;
                armor = new Equipment("ARMOR", "Leather Armor");
                equip.Add(armor.name);
                equip.Add("Lute");
                equip.Add("Entertainer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);


                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 2;
                spellsKnown = 4;
                firstSpells = 2;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Spellcasting, Bardic Inspiration (d6)");
                vrow.Add("3");
                vrow.Add("4");
                vrow.Add("2");
            }

            if (conClass.Equals("Cleric"))
            {
                className = "Cleric";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Wisdom");
                prof.Add("Charisma");
                prof.Add("Light armor");
                prof.Add("Medium Armor");
                prof.Add("Sheilds");
                prof.Add("Simple weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Medicine");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Mace");
                weapon2 = new Equipment("WEAPON", "Light Crossbow");
                weapon3 = new Equipment("WEAPON", "");
                shield = true;
                armor = new Equipment("ARMOR", "Scale Mail");
                equip.Add("Sheild");
                equip.Add(armor.name);
                equip.Add("20 bolts");
                equip.Add("Priest's Pack");
                equip.Add("Holy Symbil");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 3;
                spellsKnown = 0;
                firstSpells = 2;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Spellcasting, Divine Domain");
                vrow.Add("3");
                vrow.Add("2");
            }

            if (conClass.Equals("Druid"))
            {
                className = "Druid";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Intelligence");
                prof.Add("Wisdom");
                prof.Add("Light armor");
                prof.Add("Medium Armor");
                prof.Add("Shields");
                prof.Add("Clubs");
                prof.Add("Daggers");
                prof.Add("Darts");
                prof.Add("Javelins");
                prof.Add("Maces");
                prof.Add("Quarterstaffs");
                prof.Add("Scimitars");
                prof.Add("Sickles");
                prof.Add("Slings");
                prof.Add("Spears");
                prof.Add("Herbalism Kit");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Arcana");
                skillSelection.Add("Insight");
                skillSelection.Add("Medicine");
                skillSelection.Add("Nature");
                skillSelection.Add("Preception");
                skillSelection.Add("Religion");
                skillSelection.Add("Survival");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Scimitar");
                weapon2 = new Equipment("WEAPON", "");
                weapon3 = new Equipment("WEAPON", "");
                shield = true;
                armor = new Equipment("ARMOR", "Leather Armor");
                equip.Add(armor.name);
                equip.Add("Shield");
                equip.Add("Druidic Focus");
                equip.Add("Explorer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Spellcasting");
                //ft.Add("Druidic");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 2;
                spellsKnown = 0;
                firstSpells = 2;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Spellcasting, Druidic");
                vrow.Add("2");
                vrow.Add("2");
            }

            if (conClass.Equals("Fighter"))
            {
                className = "Fighter";
                hit = 10;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Strength");
                prof.Add("Constitution");
                prof.Add("All Armor");
                prof.Add("Shields");
                prof.Add("Martial Weapons");
                prof.Add("Simple weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Acrobatics");
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Athletics");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Preception");
                skillSelection.Add("Survival");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Shortsword");
                weapon2 = new Equipment("WEAPON", "Handaxe");
                weapon3 = new Equipment("WEAPON", "Longbow");
                shield = true;
                armor = new Equipment("ARMOR", "Chain Mail");
                equip.Add(armor.name);
                equip.Add("Shield");
                equip.Add("20 arrows");
                equip.Add("Dungeoneer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Fighting Style");
                //ft.Add("Second Wind");

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Fighting Style, Second Wind");
            }

            if (conClass.Equals("Monk"))
            {
                className = "Monk";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Dexterity");
                prof.Add("Strength");
                prof.Add("One Tool or one Instrument");
                prof.Add("Simple weapons");
                prof.Add("Shortswords");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Acrobatics");
                skillSelection.Add("Athletics");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Religion");
                skillSelection.Add("Stealth");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Shortsword");
                weapon2 = new Equipment("WEAPON", "Dart");
                weapon3 = new Equipment("WEAPON", "");
                shield = false;
                armor = new Equipment("ARMOR", "");
                equip.Add(armor.name);
                equip.Add("10 darts");
                equip.Add("Explorer's Pack");
                
                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //KI AND MARTIAL ARTS.
                ki = 0;
                martialArts = "1d4";

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Martial Arts");
                columns.Add("Ki Points");
                columns.Add("Unarmored Movement");
                columns.Add("Features");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("1d4");
                vrow.Add("0");
                vrow.Add("-");
                vrow.Add("Unarmored Defense, Martial Arts");
            }

            if (conClass.Equals("Paladin"))
            {
                className = "Paladin";
                hit = 10;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Wisdom");
                prof.Add("Charisma");
                prof.Add("All Armor");
                prof.Add("Shield");
                prof.Add("Martial Weapons");
                prof.Add("Simple weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Athletics");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Medicine");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Shortsword");
                weapon2 = new Equipment("WEAPON", "Javelin");
                weapon3 = new Equipment("WEAPON", "");
                shield = true;
                armor = new Equipment("ARMOR", "Chain Mail");
                equip.Add("5 Javelins");
                equip.Add(armor.name);
                equip.Add("Shield");
                equip.Add("Priest's Pack");
                equip.Add("Holy Symbol");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 0;
                spellsKnown = 0;
                firstSpells = 0;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Divine Sense, Lay on Hands");
                vrow.Add("0");
            }

            if (conClass.Equals("Ranger"))
            {
                className = "Ranger";
                hit = 10;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Dexterity");
                prof.Add("Strength");
                prof.Add("Light armor");
                prof.Add("Medium Armor");
                prof.Add("Shields");
                prof.Add("Simple weapons");
                prof.Add("Martial Weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 3;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Athletics");
                skillSelection.Add("Insight");
                skillSelection.Add("Investigation");
                skillSelection.Add("Nature");
                skillSelection.Add("Preception");
                skillSelection.Add("Stealth");
                skillSelection.Add("Survival");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Shortsword");
                weapon2 = new Equipment("WEAPON", "Longbow");
                weapon3 = new Equipment("WEAPON", "");
                shield = false;
                armor = new Equipment("ARMOR", "Leather Armor");
                equip.Add("20 arrows");
                equip.Add(armor.name);
                equip.Add("Explorer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 0;
                spellsKnown = 0;
                firstSpells = 0;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Spells Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Favored Enemy, Natural Explorer");
                vrow.Add("0");
                vrow.Add("0");
            }

            if (conClass.Equals("Rogue"))
            {
                className = "Rogue";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Dexterity");
                prof.Add("Intelligence");
                prof.Add("Light armor");
                prof.Add("Hand Crossbows");
                prof.Add("Longswords");
                prof.Add("Simple weapons");
                prof.Add("Rapiers");
                prof.Add("Shortswords");
                prof.Add("Thieves Tools");

                // number of skills to be selected FOR PROFICIENCY
                choose = 4;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Acrobatics");
                skillSelection.Add("Athletics");
                skillSelection.Add("Deception");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Investigation");
                skillSelection.Add("Preception");
                skillSelection.Add("Performance");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Slight of Hand");
                skillSelection.Add("Stealth");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Rapier");
                weapon2 = new Equipment("WEAPON", "Dagger");
                weapon3 = new Equipment("WEAPON", "Shortbow");
                shield = false;
                armor = new Equipment("ARMOR", "Leather Armor");
                equip.Add("20 arrows");
                equip.Add(armor.name);
                equip.Add("Theives Tools");
                equip.Add("Burglar's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                sneakAttack = "1d6";

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Sneak Attack");
                columns.Add("Features");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("1d6");
                vrow.Add("Expertise, Sneak Attack, Thieve's Cant");
            }

            if (conClass.Equals("Sorcerer"))
            {
                className = "Sorcerer";
                hit = 6;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Constitution");
                prof.Add("Charisma");
                prof.Add("Daggers");
                prof.Add("Darts");
                prof.Add("Slings");
                prof.Add("Quarterstaffs");
                prof.Add("Light Crossbows");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Arcana");
                skillSelection.Add("Deception");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Dagger");
                weapon2 = new Equipment("WEAPON", "Light Crossbow");
                weapon3 = new Equipment("WEAPON", "");
                shield = false;
                armor = new Equipment("ARMOR", "");
                equip.Add("20 bolts");
                equip.Add(armor.name);
                equip.Add("Arcane Focus");
                equip.Add("Explorer's Pack");
                
                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 4;
                spellsKnown = 2;
                firstSpells = 2;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Sorcery Points");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("0");
                vrow.Add("Spellcasting, Sorcerous Origin");
                vrow.Add("4");
                vrow.Add("2");
                vrow.Add("2");
            }

            if (conClass.Equals("Warlock"))
            {
                className = "Warlock";
                hit = 8;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Wisdom");
                prof.Add("Charisma");
                prof.Add("Light armor");
                prof.Add("Simple weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Arcana");
                skillSelection.Add("Deception");
                skillSelection.Add("History");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Investigation");
                skillSelection.Add("Nature");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Shortsword");
                weapon2 = new Equipment("WEAPON", "Dagger");
                weapon3 = new Equipment("WEAPON", "Light Crossbow");
                shield = false;
                armor = new Equipment("ARMOR", "Leather Armor");
                equip.Add("20 bolts");
                equip.Add(armor.name);
                equip.Add("Arcane Focus");
                equip.Add("Scholar's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 2;
                spellsKnown = 2;
                firstSpells = 1;
                invocations = 0;
                
                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("Spell Slots");
                columns.Add("Slot Level");
                columns.Add("Invocations Known");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Otherworldly Patron, Pact Magic");
                vrow.Add("2");
                vrow.Add("2");
                vrow.Add("1");
                vrow.Add("0");
            }

            if (conClass.Equals("Wizard"))
            {
                className = "Wizard";
                hit = 6;

                //prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Intelligence");
                prof.Add("Wisdom");
                prof.Add("Daggers");
                prof.Add("Darts");
                prof.Add("Slings");
                prof.Add("Quarterstaffs");
                prof.Add("Light Crossbows");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                //skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Arcana");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Investigation");
                skillSelection.Add("Medicine");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                weapon1 = new Equipment("WEAPON", "Quarterstaff");
                weapon2 = new Equipment("WEAPON", "Dagger");
                weapon3 = new Equipment("WEAPON", "");
                shield = false;
                armor = new Equipment("ARMOR", "");
                equip.Add(armor.name);
                equip.Add("Arcane Focus");
                equip.Add("Spellbook");
                equip.Add("Scholar's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 3;
                spellsKnown = 0;
                firstSpells = 2;

                //columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                //vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Spellcasting, Arcane Recovery");
                vrow.Add("3");
                vrow.Add("2");
            }
        }
    }
}
