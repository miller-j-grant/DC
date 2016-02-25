﻿using System;
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
        public ArrayList prof { get; }
        public ArrayList lang { get; }
        public ArrayList equip { get; }
        public int wealth { get; }
        public string ft { get; }

        // extra is for like Charlatan "Favorite Schemes"
        public ArrayList extra { get; }

        // Personality Trait
        public ArrayList person { get; }
        public ArrayList ideal { get; }
        public ArrayList bond { get; }
        public ArrayList flaw { get; }


        public Background()
        {

        }

        public Background(string bg)
        {
            prof = new ArrayList();
            lang = new ArrayList();
            equip = new ArrayList();
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

                person = new ArrayList {"I fall in and out of love easily, and am always pursuing someone.",
                    "I have a joke for every occasion, especially occasions where humor is inappropriate.",
                    "Flattery is my preffered trick for getting what I want.",
                    "I'm a born gambler who can't resist taking a risk for a potential payoff.",
                    "I lie about almost everything, even when there's no good reason to.",
                    "Sarcasm and insults are my weapon of choice.",
                    "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
                    "I pocket anything I see that might have some value."};

                ideal = new ArrayList {"Independence. I am a free spirit - no one tells me what to do. (chaotic)",
                    "Fairness. I never target people who can't afford to lose a few coins. (Lawful)",
                    "Charity. I distribute the money I aquire to the people who really need it. (good)",
                    "Creativity. I never run the same con twice. (chaotic)",
                    "Friendship. Material goods come and go. Bonds of friendship last forever. (good)",
                    "Aspiration. I'm determined to make something of myself. (any)"};

                bond = new ArrayList {"I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
                    "I owe everything to my mentor - a horrible person who's probably rotting in jail somewhere.",
                    "Somewhere out ther, I have a child who doesn't know me. I'm making the world better for him or her.",
                    "I come from a noble family, and one day I'll reclaim my lands and title from those who stole them from me.",
                    "A powerful person killed someone I love. Some day soon, I'll have my revenge.",
                    "I swindled and ruined a person who didn't deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."};

                flaw = new ArrayList {"I can't resist a pretty face.",
                    "I'm alwats in debt. I spend my ill gotten gains on decadent luxuries faster than I bring them in.",
                    "I'm convinced that no one could ever fool me the way I fool others.",
                    "I'm too greedy for my own good. I can't resist taking a risk if there's money involved.",
                    "I can't resist swindling people who are more powerful than me.",
                    "I hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough."};
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

                person = new ArrayList {"I always have a plan for what to do when things go wrong.",
                    "I am always calm no matter what the situation. I never raise my voice or let my emotions control me.",
                    "The first thing I do in a new place is note the locations of everything valuable - or where such things could be hidden.",
                    "I would rather make a new friend than a new enemy.",
                    "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
                    "I don't pay attention to the risks in a situation. Never tell me the odds.",
                    "The best way to get me to do something is to tell me I can't do it.",
                    "I blow up at the slightest insult."};

                ideal = new ArrayList {"Honor. I don't steal from others in the trade. (lawful)",
                    "Freedom. Chains are meant to be broken, as are those who would forge them. (chaotic)",
                    "Charity. I steal from the weathy so that I can help people in need. (good)",
                    "Greed. I will do whatever it takes to become wealthy. (evil)",
                    "People. I'm loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (neutral)",
                    "Redemption. There's a spark of good in everyone. (good)"};

                bond = new ArrayList {"I'm trying to pay off an old debt I owe to a generous benefactor.",
                    "My ill-gotten gains go to support my family.",
                    "Something important was taken from me, and I aim to steal it back.",
                    "I will become the greatest thief that ever lived.",
                    "I'm guilty of a terrible crime. I hope I can redeem myself for it.",
                    "Someone I loved died because of 1 mistake I made. That will never happen again."};

                flaw = new ArrayList {"When I see something valuable, I can't think about anything but how to steal it.",
                    "When faced with a choice between money and my friends, I usually choose the money.",
                    "If there's a plan, I'll forget it. If I don't forget it, I'll ignore it.",
                    "I have a 'tell' that reveals when I'm lying.",
                    "An innocent person is in prison for a crime that I commited. I'm okay with that."};
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

                person = new ArrayList {"I know a story relevant to almost every situation.",
                    "Whenever I come to a new place, I collect local rumors and spread gossip.",
                    "I'm a hopeless romantic, always searching for that 'special someone'.",
                    "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
                    "I love a good insult, even one directed at me.",
                    "I get bitter if I'm not the center of attention.",
                    "I'll settle for nothing less than perfection.",
                    "I change my mood or my mind as quickly as I change key in a song."};

                ideal = new ArrayList {"Beauty. When I perform, I make the world better then it was. (good)",
                    "Tradition. The stories, legends, and songs of the past must never be forgotten, for they teach us who we are. (lawful)",
                    "Creativity. The world is in need of new ideas and bold action. (chaotic)",
                    "Greed. I'm only in it for the money and fame. (evil)",
                    "People. I like seeing the smiles on people's faces when I perform. That's all that matters. (neutral)",
                    "Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (any)"};

                bond = new ArrayList {"My instrument is my most treasured possession, and it reminds me of someone I love.",
                    "Someone stole my precious instrument, and someday I'll get it back.",
                    "I want to be famous, whatever it takes.",
                    "I idolize a hero of the old tales and measure my deeds against that person's.",
                    "I will do anything to prove myself superior to my hated rival.",
                    "I would do anything for the other members of my old troupe."};

                flaw = new ArrayList {"I'll do anything to win fame and renown.",
                    "I'm a sucker for a pretty face.",
                    "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
                    "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
                    "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
                    "Despite my best efforts, I am unreliable to my friends."};
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

                person = new ArrayList {"I judge people by their actions, not their words.",
                    "If someone is in trouble, I'm always ready to lend help.",
                    "When I set my mind to something, I follow through no matter what gets in my way.",
                    "I have a strong sense of fair play and always try to find the most equitable solutions to arguments.",
                    "I'm confident in my own abilities and do what I can to instill confidence in others.",
                    "Thinking is for other people. I prefer action.",
                    "I misuse long words in an attempt to sound smarter.",
                    "I get bored easily. When am I going to get on with my destiny?"};

                ideal = new ArrayList {"Respect. People deserve to be treated with dignity and respect. (good)",
                    "Fairness. No one should get preferential treatment before the law, and no one is above the law. (lawful)",
                    "Freedom. Tyrants must not be allowed to oppress the people. (chaotic)",
                    "Might. If I become strong, I can take what I want ... what I desrve. (evil)",
                    "Sincerity. There's no good in pretending to be something I'm not. (nuetral)",
                    "Destiny. Nothing and no one can steer me away from my higher calling. (any)"};

                bond = new ArrayList {"I have a family, but I have no idea where they are. One day, I hope to see them again.",
                    "I worked the land, I love the land, and I will protect the land.",
                    "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.",
                    "My tools are symbols of my past life, and I carry them so that I will never forget my roots.",
                    "I protect those who cannot protect themselves.",
                    "I wish my childhood sweetheart had come with me to pursue my destiny."};

                flaw = new ArrayList {"The tyrant who rules my land will stop at nothing to see me killed.",
                    "I'm convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.",
                    "The people who knew me when I was yound know my shameful secret, so I can never go home again.",
                    "I have a weakness for the vices of the city, especially hard drink.",
                    "Secretly, I believe that things would be better if I were a tyrant lording over the land.",
                    "I have trouble trusting in my allies."};
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

                person = new ArrayList {"I believe that anything worth doing is worth doing right. I can't help it - I'm a perfectionist.",
                    "I'm a snob who looks down on those who can't appreciate fine art.",
                    "I always want to know how things work and what makes people tick.",
                    "I'm full of witty aphorisms and have a proverb for every occasion.",
                    "I'm rude to people who lack my commitment to hard work and fair play.",
                    "I like to talk at length about my profession.",
                    "I don't part with my money easily and will haggle tirelessly to get the best deal possible.",
                    "I'm well known for my work, and I want to make sure everyone appreciates it. I'm always taken aback when people haven't heard of me."};

                ideal = new ArrayList {"Community. It is the duty of all civilized people to strengthen the bonds of community and the security of civilization. (lawful)",
                    "Generosity. My talents were given to me so that I could use them to benefit the world. (good)",
                    "Freedom. Everyone should be free to pursue his or her own livelihood. (chaotic)",
                    "Greed. I'm only in it for the money. (evil)",
                    "People. I'm committed to the people I care about, not to ideals. (neutral)",
                    "Aspiration. I work hard to be the best ther is at my craft. (any)"};

                bond = new ArrayList {"The workshop where I learned my trade is the most important place in the world to me.",
                    "I created a great work for someone, and then found them unworthy to receive it. I'm still looking for someone worthy.",
                    "I owe my guild a great debt for forging me into the person I am today.",
                    "I pursue wealth to secure someone's love.",
                    "One day I will return to my guild and prove that I am the greatest artisan of them all.",
                    "I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood."};

                flaw = new ArrayList {"I'll do anything to get my hands on something rare or priceless.",
                    "I'm quick to assume that someone is trying to cheat me.",
                    "No one must ever learn that I once stole money from guild coffers.",
                    "I'm never satisfied with what I have - I always want more.",
                    "I would kill to acquire a noble title.",
                    "I'm horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I'm surrounded by rivals."};
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

                person = new ArrayList {"I've been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.",
                    "I am utterly seren, even in the face of disaster.",
                    "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.",
                    "I feel tremendous empathy for all who suffer.",
                    "I'm oblivious to etiquette and social expectations.",
                    "I connect everything that happends to me in a grand, cosmic plan.",
                    "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.",
                    "I am working on a grand philosophical theory and love sharing my ideas."};

                ideal = new ArrayList {"Greater Good. My gifts are meant to be shared with all, not used for my own benefit. (good)",
                    "Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking. (lawful)",
                    "Free Thinking. Inquiry and curiosity are the pillars of progress. (chaotic)",
                    "Power. Solitude and contemplation are paths toward msytical or magical power. (evil)",
                    "Live and Let Live. Meddling in the affairs of others only causes trouble. (neutral)",
                    "Self-Knowledge. If you know yourself, there's nothing left to know. (any)"};

                bond = new ArrayList {"Nothing is more important than the other members of my hermitage, order, or association.",
                    "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.",
                    "I'm still seeking the enlightenment I pursued in my seclusion, and it still eludes me.",
                    "I entered seculsion because I loved someone I could not have.",
                    "Should my discovery come to light, it could bring ruin to the world.",
                    "My isolation gave me great insight into a great evil that only I can destroy."};

                flaw = new ArrayList {"Now that I've returned to the world, I enjoy its delights a little too much.",
                    "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.",
                    "I am dogmatic in my thoughts and philosophy.",
                    "I let my need to win arguments overshadow friendships and harmony.",
                    "I'd risk too much to uncover a lost bit of knowledge.",
                    "I like keeping secrets and won't share them with anyone."};
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

                person = new ArrayList {"My eloquent flattery makes everyone I talk to feel like the most wonderful and important person in the world.",
                    "The common folk love me for my kindness and generosity.",
                    "No one could doubt by looking at my regal bearing that I am a cut above the unwashed masses.",
                    "I take great pains to always look my best and follow the latest fashions.",
                    "I don't like to get my hands dirty, and I won't be caught dead in unsuitable accomodations.",
                    "Despite my noble birth, I do not place myself above other folk. We all have the same blood.",
                    "My favor, once lost, is lost forever.",
                    "If you do me an injury, I will crush you, ruin your name, and salt your fields."};

                ideal = new ArrayList {"Respect. Respect is due to me because of my position, but all people regardless of station deserve to be treated with dignity. (good)",
                    "Responsibility. It is my duty to respect the authority of those above me, just as those below me must respect mine. (lawful)",
                    "Independence. I must prove that I can handle myself without the coddling of my family. (chaotic)",
                    "Power. If I can attain more power, no one will tell me what to do. (evil)",
                    "Family. Blood runs thicker than water. (any)",
                    "Noble Obligation. It is my duty to protect and care for the people beneath me. (good)"};

                bond = new ArrayList {"I will face any challenge to win the approval of my family.",
                    "My house's alliance with another noble family must be sustained at all costs.",
                    "Nothing is more important than the other members of my family.",
                    "I am in love with the heir of a family that my family despises.",
                    "My loyalty to my sovereign is unwavering.",
                    "The common folk must see me as a hero of the people."};

                flaw = new ArrayList {"I secretly believe that everyone is beneath me.",
                    "I hide a truly scandalous secret that could ruin my family forever.",
                    "I too often hear veilded insults and threats in every word addressed to me, and I'm quick to anger.",
                    "I have an insatiable desire for carnal pleasures.",
                    "In fact, the world does revolve around me.",
                    "By my words and actions, I often bring shame to my family."};
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

                person = new ArrayList {"I'm driven by a wanderlust that led me away from home.",
                    "I watch over my friends as if they were a litter of newborn pups.",
                    "I once ran twenty-five miles without stopping to warn my clan of an approaching orc horde. I'd do it again if I had to.",
                    "I have a lesson for every situation, drawn from observing nature.",
                    "I place no stock in wealthy or well-mannerd folk. Money and manners won't save you from a hungry owlbear.",
                    "I'm always picking things up, absently fiddling with them, and sometimes accidentally breaking them.",
                    "I feel far more comfortable around animals than people.",
                    "I was, in fact, raised by wolves."};

                ideal = new ArrayList {"Change. Life is like the season, in constant change, and we must change with it. (chaotic)",
                    "Greater Good. It is each person's responsibility to make the most happiness for the whole tribe. (good)",
                    "Honor. If I dishonor myself, I dishonor my whole clan. (lawful)",
                    "Might. The strongest are meant to rule. (evil)",
                    "Nature. The natural world is more important than all the contructs of civilization. (neutral)",
                    "Glory. I must earn glory in battle, for myself and my clan. (any)"};

                bond = new ArrayList {"My family, clan, or tribe is the most important thing in my life, even when they are far from me.",
                    "An injury to the unspoiled wilderness of my home is an injury to me.",
                    "I will bring terrible wrath down on the evildoers who destroyed my homeland.",
                    "I am the last of my tribe, and it is up to me to ensure their names enter legend.",
                    "I suffer awful visions of a comin disaster and will do anything to prevent it.",
                    "I is my duty to provide children to sustain my tribe."};

                flaw = new ArrayList {"I am too enamored of ale, wine, and other intoxicants.",
                    "There's no room for caution in a life lived to the fullest.",
                    "I remember every insult I've received and nurse a silent resentment toward anyone who's ever wronged me.",
                    "I am slow to trust members of other races, tribes, and socities.",
                    "Violence is my answer to almost any challenge.",
                    "Don't expect me to save those who can't save themselves. It is nature's way that the strong thrive and the weak perish."};
            }

            if (bg.Equals("Sage"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Arcana");
                prof.Add("History");

                lang.Add("Two of your choice");

                equip.Add("A bottle of black ink");
                equip.Add("A quill");
                equip.Add("A small knife");
                equip.Add("A letter from a dead colleague posing a question you have not yet been able to answer");
                equip.Add("A set of common clothes");

                // in gp
                wealth = 10;
                ft = "Researcher";

                person = new ArrayList {"I use polysyllabic words that convey the impression of great erudition.",
                    "I've read every book in the world's greatest libraries - or I like to boast that I have.",
                    "I'm used to helping out those who aren't as smart as I am, and I patiently explain anything and everything to others.",
                    "There's nothing I like more than a good mystery.",
                    "I'm willing to listen to every side of an argument before I make my own judgement.",
                    "I speak very slowly when talking to idiots which almost everyone is compared to me.",
                    "I am horribly, horribly awkward in social situations.",
                    "I'm convinced that people are always trying to steal my secrets."};

                ideal = new ArrayList {"Knowledge. The path to power and self-improvement is through knowledge. (neutral)",
                    "Beauty. What is beautiful points us beyond itself toward what is true. (good)",
                    "Logic. Emotions must not cloud our logical thinking. (lawful)",
                    "No Limits. Nothing should fetter the infinite possibility inherent in all existence. (chaotic)",
                    "Power. Knowledge is the path to power and domination. (evil)",
                    "Self-Improvement. The goal of a life of study is the betterment of oneself. (any)"};

                bond = new ArrayList {"It is my duty to protect my students.",
                    "I have an ancient text that holds terrible secrets that must not fall into the wrong hands.",
                    "I work to preserve a library, university, scriptorum, or monastery.",
                    "My life's work is a series of tomes related to a specific field of lore.",
                    "I've been searching my whole life for the answer to a certain question.",
                    "I sold my soul for knowledge. I hope to do great deeds and win it back."};

                flaw = new ArrayList {"I am easily distracted by the promise of information.",
                    "Most people scream and run when they see a demon. I stop and take notes on its anatomy.",
                    "Unlocking an ancient mystery is worth the price of a civilization.",
                    "I overlook obvious solutions in favor of complicated ones.",
                    "I speak without really thinking through my words, invariably insulting others.",
                    "I can't keep a secret to save my life, or anyone else's."};
            }

            if (bg.Equals("Sailor"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Athletics");
                prof.Add("Perception");
                prof.Add("Navigator's Tools");
                prof.Add("vehicles (water)");

                equip.Add("A belaying pin (club)");
                equip.Add("A 50 ft of silk rope");
                equip.Add("A lucky charm");
                equip.Add("A set of common clothers");

                // in gp
                wealth = 10;
                ft = "Ship's Passage";

                person = new ArrayList {"My friends know they can rely on me, no matter what.",
                    "I work hard so that I can play hard when the work is done.",
                    "I enjoy sailing into new ports and making new friends over a flagon of ale.",
                    "I stretch the truth for the sake of a good story.",
                    "To me, a tavern brawl is a nice way to get to know a new city.",
                    "I never pass up a friendly wager.",
                    "My language is as foul as an otyugh nest.",
                    "I like a job well done, especially if I can convince someone else to do it."};

                ideal = new ArrayList {"Respect. The thing that keeps a ship together is mutual respect between captain and crew. (good)",
                    "Fairness. We all do the work, so we all share in the rewards. (lawful)",
                    "Freedom. The sea is freedom - the freedom to go anywhere and do anything. (chaotic)",
                    "Mastery. I'm a predator, and the other ships on the sea are my prey. (evil)",
                    "People. I'm committed to my crewmates, not to ideals. (neutral)",
                    "Aspiration. Someday I'll own my own ship and chart my own destiny. (any)"};

                bond = new ArrayList {"I'm loyal to my captain first, everything else second.",
                    "The ship is most important - crewmates and captains come and go.",
                    "I'll always remember my first ship.",
                    "In a harbor town, I have a paramour whose eyes nearly stole me from the sea.",
                    "I was cheated out of my fair share of the profits, and I want to get my due.",
                    "Ruthless pirates murdered my captain and crewmates, plundered our ship, and left me to die. Vengeance will be mine."};

                flaw = new ArrayList {"I follow orders, even if I think they're wrong.",
                    "I'll say anything to avoid having to do extra work.",
                    "Once someone questions my courage, I never back down no matter how dangerous the situation.",
                    "Once I start drinking, it's hard for me to stop.",
                    "I can't help but pocket loose coins and other trinkets I come across.",
                    "My pride will probably lead to my destruction."};
            }

            if (bg.Equals("Soldier"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Athletics");
                prof.Add("Intimidation");
                prof.Add("One type of gaming set");
                prof.Add("Vehicles (land)");

                equip.Add("An insignia of rank");
                equip.Add("A trophy taken from a fallen enemy");
                equip.Add("A set of bone dice or cards");
                equip.Add("A set of common clothes");

                // in gp
                wealth = 10;
                ft = "Military Rank";

                person = new ArrayList {"I'm always polite and respectful.",
                    "I'm haunted by memories of war. I can't get the images of violence out of my mind.",
                    "I've lost too many friends, and I'm slow to make new ones.",
                    "I'm full of inspiring and cautionary tales from my military experience relevant to almost every combat situation.",
                    "I can stare down a hell hound without flinching.",
                    "I enjoy being strong and like breaking things.",
                    "I have a crude sense of humor.",
                    "I face problems head-on. A simple, direct solution is the best path to success."};

                ideal = new ArrayList {"Greater Good. Our lot is to lay down our lives in defense of others. (good)",
                    "Responsibility. I do what I must and obey just authority. (lawful)",
                    "Independence. When people follow orders blindly, they embrace a kind of tyranny. (chaotic)",
                    "Might. In life as in ware, the stronger force wins. (evil)",
                    "Live and Let Live. Ideals aren't worth killing over or going to war for. (neutral)",
                    "Nation. My city, nation, or people are all that matter. (any)"};

                bond = new ArrayList {"I would still lay down my life for the people I served with.",
                    "Someone saved my life on the battlefield. To this day, I will never leave a friend behind.",
                    "My honor is my life.",
                    "I'll never forget the crushing defeat my company suffered or the enemies who deals it.",
                    "Those who fight beside me are those worth dying for.",
                    "I fight for those who cannot fight for themselves."};

                flaw = new ArrayList {"The monstrous enemy we faced in battle still leaves me quivering with fear.",
                    "I have little respect for anyone who is not a proven warrior.",
                    "I made a terrible mistake in battle cost many lives - and I would do anything to keep that mistake secret.",
                    "My hatred of my enemies is blind and unreasoning.",
                    "I obey the law, even if the law causes misery.",
                    "I'd rather eat my armor than admit when I'm wrong."};
            }

            if (bg.Equals("Urchin"))
            {
                lang.Clear();
                prof.Clear();
                ft = "";
                person.Clear();
                ideal.Clear();
                bond.Clear();
                flaw.Clear();

                prof.Add("Sleight of Hand");
                prof.Add("Stealth");
                prof.Add("Disguise Kit");
                prof.Add("Thieve's Tools");

                equip.Add("A small knife");
                equip.Add("A map of the city you grow up in");
                equip.Add("A pet mouse");
                equip.Add("A token to remember your parents by");
                equip.Add("A set of common clothes");

                // in gp
                wealth = 10;
                ft = "City Secrets";

                person = new ArrayList {"I hide scraps of food and trinkets away in my pockets.",
                    "I ask a lot of questions.",
                    "I like to squeeze into small places where no one else can get to me.",
                    "I sleep with my back to a wall or tree, with everything I own wrapped in a bundle in my arms.",
                    "I eat like a pig and have bad manners.",
                    "I think anyone who's nice to me is hiding evil intent.",
                    "I don't like to bathe.",
                    "I bluntly say what other people are hinting at or hiding."};

                ideal = new ArrayList {"Respect. All people, rich or poor, deserve respect. (good)",
                    "Community. We have to take care of each other, because no one else is going to do it. (lawful)",
                    "Change. The low are lifted up, and the high and might are brought donw. Change is the nature of things. (chaotic)",
                    "Retribution. The rich need to be shown what life and death are like in the gutters. (evil)",
                    "People. I help the people who help me - that's what keeps us alive. (neutral)",
                    "Aspiration. I'm going to prove that I'm worthy of a better life."};

                bond = new ArrayList {"My town or city is my home, and I'll fight to defend it.",
                    "I sponsor an orphanage to keep others from enduring what I was forced to endure.",
                    "I owe my survival to another urchin who taught me to live on the streets.",
                    "I owe a debt I can never repay to the person who took pity on me.",
                    "I escaped my life of poverty by robbing an important person, and I'm wanted for it.",
                    "No one else should have to endure the hardships I've been through."};

                flaw = new ArrayList {"If I'm outnumbered, I will run away from a fight.",
                    "Gold seemse like a lot of money to me, and I'll do just about anything for more of it.",
                    "I will never fully trust anyone other than myself.",
                    "I'd rather kill someone in their sleep than fight fair.",
                    "It's not stealing if I need it more than someone else.",
                    "People who can't take care of themselves get what they deserve."};
            }
        }
    }
}
