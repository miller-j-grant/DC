using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawler__
{

    // not entirely sold on this class
    // honestly, Backgrounds are the biggest drawback to 5E
    // but it is technically optional, sooooooo ><
    class Background
    {
        private ArrayList prof { get; }
        private ArrayList lang { get; }
        private ArrayList equip { get; }
        private int wealth { get; }
        private string ft { get; }

        // extra is for like Charlatan "Favorite Schemes"
        private string []extra { get; }

        // Personality Trait
        private ArrayList person { get; }
        private ArrayList ideal { get; }
        private ArrayList bond { get; }
        private ArrayList flaw { get; }


        public Background()
        {

        }

        public Background(string bg)
        {
            if (bg.Equals("Acolyte"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Insight");
                prof.Add("Religion");

                lang.Add("Two of your choice");

                equip.Add("Holy Symbol");
                equip.Add("Prayer book or prayer wheel");
                equip.Add("5 sticks of incense");
                equip.Add("Vestments");
                equip.Add("Common clothes");

                // in gp
                wealth = 15;
                ft = "Shelther of the Faithful";

                // OTL fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
                person = new ArrayList { "I idolize a particular hero of my faith, and constantly refer to that person's deeds and example.",
                    "I can find common ground between the fiercest enemies, empathizing with them and always working toward peace.",
                    "I see omens in every event and action. The gods try to speak to us, we just need to listen.",
                    "Nothing can shake my optimistic attitude.",
                    "I quote [or misquote] sacred texts and proverbs in almost every situation.",
                    "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.",
                    "I've enjoyed fine food, drink, and high society among my temple's elite. Rough living grates on me.",
                    "I've spent so long in the temple that I have little practical experience dealing with people in the outside world."};

                ideal = new ArrayList { "Tradtion. The ancient traditions of worship and sacrifice must be preserved and upheld.",
                    "Charity. I always try to help those in need, no matter what the personal cost. (good)",
                    "Change. We must help bring about the changes the gods are constantly working in the world. (chaotic)",
                    "Power. I hope to one day rise to the top of my faith's religious hierarchy. (lawful)",
                    "Faith. I trust that my deity will guide my actions. I have faith that if I work hard, things will go well. (lawful)",
                    "Aspiration. I seek to prove myself worthy of my god's favor by matching my actions against his or her teachings. (Any)"};

                bond = new ArrayList { "I would die to recover an ancient relic of m faith that was lost long ago.",
                    "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
                    "I owe my life to the priest who took me in when my parents died.",
                    "Everything I do is for the common people.",
                    "I will do anything to protect the temple where I served.",
                    "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy."};

                flaw = new ArrayList { "I judge others harshly, and myself even more severely.",
                    "I put too much trust in those who wield power within my temple's hierarchy.",
                    "My piety sometimes leads me to blindly trust those that profess faith in my god.",
                    "I am inflexible in my thinking.",
                    "I am suspicious of strangers and expect the worst from them.",
                    "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life."};
            }

            if(bg.Equals("Charlatan"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Deception");
                prof.Add("Slight of Hand");
                prof.Add("Disguise Kit");
                prof.Add("Forgery Kit");

                equip.Add("A Set of Fine Clothes");
                equip.Add("A Disguise Kit");
                equip.Add("Tools of the Con of your choice");

                // in gp
                wealth = 15;
                ft = "False Identity";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Criminal"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Deception");
                prof.Add("Stealth");
                prof.Add("One type of Gaming Set");
                prof.Add("Theive's Tools");

                equip.Add("A Crowbar");
                equip.Add("A set of Dark Common Clothes, including a Hood");

                // in gp
                wealth = 15;
                ft = "Criminal Contact";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Entertainer"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Acrobatics");
                prof.Add("Performance");
                prof.Add("Disguise Kit");
                prof.Add("One type of musical instrument");

                equip.Add("A musical instrument (one of your choice)");
                equip.Add("The favor of an admirer (love letter, lock of hair, or trinket)");
                equip.Add("A costume");

                // in gp
                wealth = 15;
                ft = "By Popular Demand";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Folk Hero"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Animal Handling");
                prof.Add("Survival");
                prof.Add("One type of Artisan's Tools");
                prof.Add("Vehicles (land)");

                equip.Add("A set of Artisan's Tools (one of your choice)");
                equip.Add("An iron pot");
                equip.Add("A set of Common Clothes");

                // in gp
                wealth = 10;
                ft = "Rustic Hospitality";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Guild Artisan"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Insight");
                prof.Add("Persuasion");
                prof.Add("One type of Artisan's Tools");

                lang.Add("One of your choice");

                equip.Add("A set of Artisan's Tools");
                equip.Add("A letter of introduction from your guild");
                equip.Add("A set of Traveller's Clothes");

                // in gp
                wealth = 15;
                ft = "Guild Membership";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Hermit"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Medicine");
                prof.Add("Religion");
                prof.Add("Herbalism kit");

                lang.Add("One of your choice");

                equip.Add("A scroll case stuffed full of notes from your studies or prayers");
                equip.Add("A winter blanket");
                equip.Add("A set of Common Clothes");
                equip.Add("An Herbalism Kit");

                // in gp
                wealth = 5;
                ft = "Discovery";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Noble"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("History");
                prof.Add("Persuasion");
                prof.Add("One type of Game Set");

                lang.Add("One of your choice");

                equip.Add("A set of Fine Clothes");
                equip.Add("A signet ring");
                equip.Add("A scroll of pedigree");

                // in gp
                wealth = 25;
                ft = "Position of Privilege";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if (bg.Equals("Outlander"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Athletics");
                prof.Add("Survival");
                prof.Add("One type of Musical Instrument");

                lang.Add("One of your choice");

                equip.Add("A Staff");
                equip.Add("A hunting trap");
                equip.Add("A trophy from an animal you killed");
                equip.Add("A set of traveler's clothes");

                // in gp
                wealth = 10;
                ft = "Wanderer";

                person = new ArrayList { };

                ideal = new ArrayList { };

                bond = new ArrayList { };

                flaw = new ArrayList { };
            }

            if ()
            {

            }
        }
    }
}
