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

        public ArrayList equip { get; }
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
            equip = new ArrayList();
            ft = new ArrayList();
            spells = new ArrayList();

            if (conClass.Equals("Barbarian"))
            {
                className = "Barbarian";
                hit = 12;

                prof.Clear();

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

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Animal Handling");
                skillSelection.Add("Athletics");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Nature");
                skillSelection.Add("Preception");
                skillSelection.Add("Survival");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Greataxe or other Martial Weapon");
                equip.Add("Two Handaxes or any Simple Weapon");
                equip.Add("Explorer's Pack");
                equip.Add("4 Javelins");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Rage");
                //ft.Add("Unarmored Defense");

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Rages");
                columns.Add("Rage Damage");

                vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Unarmored Defense, Rage");
                vrow.Add("2");
                vrow.Add("+2");
            }

            if (conClass.Equals("Bard"))
            {
                className = "Bard";
                hit = 8;

                prof.Clear();

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

                skillSelection.Clear();

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
                equip.Add("Rapier, Longsword, or any Simple Weapon");
                equip.Add("Diplomat's Pack or Entertainer's Pack");
                equip.Add("Lute or other musical instrument");
                equip.Add("Leather Armor");
                equip.Add("Dagger");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Spellcasting");
                //ft.Add("Bardic Inspiration (d6)");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 2;
                spellsKnown = 4;
                firstSpells = 2;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("1st");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Medicine");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Mace or a Warhammer");
                equip.Add("Scale Mail, Leather Armor, or Chain Mail");
                equip.Add("Light Crossbow + 20 bolts or any Simple Weapon");
                equip.Add("Priest's Pack or Explorer's Pack");
                equip.Add("Sheild");
                equip.Add("Holy Symbol");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Spellcasting");
                //ft.Add("Divine Domain");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 3;
                spellsKnown = 0;
                firstSpells = 2;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

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
                equip.Add("Wooden Shield or any Simple Weapon");
                equip.Add("Scimitar or any Simple Melee Weapon");
                equip.Add("Explorer's Pack");
                equip.Add("Leather Armor");
                equip.Add("Druidic Focus");

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

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

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
                equip.Add("Chain Mail or Leather, Longbow, and 20 arrows");
                equip.Add("Martial Weapon and Shield or two Martial Weapons");
                equip.Add("Light Crossbow and 20 bolts or two Handaxes");
                equip.Add("Dungeoneer's Pack or Explorer's Pack");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Fighting Style");
                //ft.Add("Second Wind");

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");

                vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Fighting Style, Second Wind");
            }

            if (conClass.Equals("Monk"))
            {
                className = "Monk";
                hit = 8;

                prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Dexterity");
                prof.Add("Strength");
                prof.Add("One Tool or one Instrument");
                prof.Add("Simple weapons");
                prof.Add("Shortswords");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Acrobatics");
                skillSelection.Add("Athletics");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Religion");
                skillSelection.Add("Stealth");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Shortsword, or any Simple Weapon");
                equip.Add("Dungeoneer's Pack or Explorer's Pack");
                equip.Add("10 darts");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Unarmored Defense");
                //ft.Add("Martial Arts");

                //KI AND MARTIAL ARTS.
                ki = 0;
                martialArts = "1d4";

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Martial Arts");
                columns.Add("Ki Points");
                columns.Add("Unarmored Movement");
                columns.Add("Features");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Athletics");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Medicine");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Martial Weapon and Shield, or two Martial Weapons");
                equip.Add("Five Javelins or any Simple Melee Weapon");
                equip.Add("Priest's Pack or an Explorer's Pack");
                equip.Add("Chain Mail and Holy Symbol");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Divine Sense");
                //ft.Add("Lay on Hands");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 0;
                spellsKnown = 0;
                firstSpells = 0;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("1st");

                vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Divine Sense, Lay on Hands");
                vrow.Add("0");
            }

            if (conClass.Equals("Ranger"))
            {
                className = "Ranger";
                hit = 10;

                prof.Clear();

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

                skillSelection.Clear();

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
                equip.Add("Scale Mail or Leather Armor");
                equip.Add("Two Shortswords or two Simple Melee Weapons");
                equip.Add("Dungeoneer's Pack or Explorer's Pack");
                equip.Add("Longbow and 20 arrows");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Favored Enemy");
                //ft.Add("Natural Explorer");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 0;
                spellsKnown = 0;
                firstSpells = 0;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Spells Known");
                columns.Add("1st");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

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
                equip.Add("Rapier or a Shortsword");
                equip.Add("Shortbow and 20 arrows or a Shortsword");
                equip.Add("Burglar's Pack, Dungeoneer's Pack, or an Explorer's Pack");
                equip.Add("Leather Armor, two Daggers, and theives tools");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Expertise");
                //ft.Add("Sneak Attack");
                //ft.Add("Thieve's Cant");

                sneakAttack = "1d6";

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Sneak Attack");
                columns.Add("Features");

                vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("1d6");
                vrow.Add("Expertise, Sneak Attack, Thieve's Cant");
            }

            if (conClass.Equals("Sorcerer"))
            {
                className = "Sorcerer";
                hit = 6;

                prof.Clear();

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

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Arcana");
                skillSelection.Add("Deception");
                skillSelection.Add("Insight");
                skillSelection.Add("Intimidation");
                skillSelection.Add("Persuasion");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Light Crossbow and 20 bolts or any Simple Weapon");
                equip.Add("Components pouch or Arcane Focus");
                equip.Add("Dungeoneer's Pack or Explorer's Pack");
                equip.Add("Two Daggers");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Spellcasting");
                //ft.Add("Sorcerous Origin");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 4;
                spellsKnown = 2;
                firstSpells = 2;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Sorcery Points");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("1st");

                vrow.Clear();

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

                prof.Clear();

                // long strings might get long
                //CLASS PROFICIENCIES.
                prof.Add("Wisdom");
                prof.Add("Charisma");
                prof.Add("Light armor");
                prof.Add("Simple weapons");

                // number of skills to be selected FOR PROFICIENCY
                choose = 2;

                skillSelection.Clear();

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
                equip.Add("Light Crossbow and 20 bolts or any Simple Weapon");
                equip.Add("Component Pouch and Arcane Focus");
                equip.Add("Scholar's Pack or Dungeoneer's Pack");
                equip.Add("Leather Armor");
                equip.Add("Any Simple weapon");
                equip.Add("Two Daggers");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Otherworldly Patron");
                //ft.Add("Pact Magic");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 2;
                spellsKnown = 2;
                firstSpells = 1;
                invocations = 0;
                
                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("Spells Known");
                columns.Add("Spell Slots");
                columns.Add("Slot Level");
                columns.Add("Invocations Known");

                vrow.Clear();

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

                prof.Clear();

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

                skillSelection.Clear();

                //skills are to be selected from the options below at the amount above and then added to the prof Arraylist
                skillSelection.Add("Arcana");
                skillSelection.Add("History");
                skillSelection.Add("Insight");
                skillSelection.Add("Investigation");
                skillSelection.Add("Medicine");
                skillSelection.Add("Religion");

                equip.Clear();

                //UPON CLASS SELECTION, USER MUST CHOOSE EQUIPMENT.
                equip.Add("Quarterstaff or a Dagger");
                equip.Add("Component Pouch or Arcane Focus");
                equip.Add("Scholar's Pack or Explorer's Pack");
                equip.Add("Spellbook");

                // send className to calculations to get wealth back
                wealth = Calculations.calcWealth(className);

                // we'll have to decide how to put more features if we add level > 1 characters
                // maybe a level up method here in class. Dunno.

                //ft.Clear();

                ////FEATURES NEEDS A DATABASE FOR DESCRIPTIONS.
                //ft.Add("Spellcasting");
                //ft.Add("Arcane Recovery");

                //SPELLS KNOWN AND SPELL SLOTS.
                cantripsKnown = 3;
                spellsKnown = 0;
                firstSpells = 2;

                columns.Clear();

                columns.Add("Level");
                columns.Add("Proficiency Bonus");
                columns.Add("Features");
                columns.Add("Cantrips Known");
                columns.Add("1st");

                vrow.Clear();

                vrow.Add("1st");
                vrow.Add("+2");
                vrow.Add("Spellcasting, Arcane Recovery");
                vrow.Add("3");
                vrow.Add("2");
            }
        }
    }
}
