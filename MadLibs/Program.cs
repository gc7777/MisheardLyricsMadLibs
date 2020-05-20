using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            RowStory r = new RowStory();
            Motivation m = new Motivation();
            GoToMainMenu();

            void GoToMainMenu()
            {
                Console.WriteLine("Welcome to Mad Libs");
                Console.WriteLine("-------------------");
                Console.WriteLine("Have you played Mad Libs before? Y / N");

                string response = Console.ReadLine();
                if (response == "Y" || response == "y")
                {
                    PickCategory();
                }
                else if (response == "N" || response == "n")
                {
                    Console.WriteLine("No problem. Here's how you play: " + Definitions.instructions);
                    Console.WriteLine();
                    PickCategory();
                }
                else
                {
                    Console.WriteLine("Please select either Y for yes or N for no");
                    GoToMainMenu();
                }
            }

            void PickCategory()
            {
                Console.WriteLine("Alright, let's play!");
                Console.WriteLine("Pick a story:");
                Console.WriteLine("1. Row Row Row Your ______ (Kindergarten Mode - 6 Words)");
                Console.WriteLine("2. Not just any motivational YouTube Ad (Challenge Accepted Mode - 30 Word Choices)");
                Console.WriteLine("3. Bohemian Rhapsody: Misheard Lyrics Edition (Epic Mode - 31 Word Choices)");
                
                int storyChoice = Convert.ToInt32(Console.ReadLine());
                if (storyChoice == 1)
                {
                    r.PlayRow();
                }
                else if (storyChoice == 2)
                {
                    m.PlayMotivation();
                }
                else if(storyChoice == 3)
                {
                    PlayQueen();
                }
                else
                {
                    Console.WriteLine("Sorry that choice is invalid. Please choose 1, 2, or 3.");
                    PickCategory();
                }
            }

          
            void PlayQueen()
            {
                Bohemian b = new Bohemian();
                Console.WriteLine("You picked: Bohemian Rhapsody: Misheard Lyrics Edition (31 words)");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine($"Pick a noun ({Definitions.noun})");
                b.lifeNoun = Console.ReadLine();

                Console.WriteLine("Question 1 of 31 - Pick a natural disaster eg. flood");
                b.naturalDisaster = Console.ReadLine();

                Console.WriteLine("2 of 31 - Pick a cartoon character");
                b.cartoonCharacter = Console.ReadLine();

                Console.WriteLine($"3 of 31 - Pick a verb in present tense ({Definitions.verb})");
                b.runVerb = Console.ReadLine();

                Console.WriteLine($"4 of 31 - Pick a noun ({Definitions.noun})");
                b.boyNoun = Console.ReadLine();

                Console.WriteLine($"5 of 31 - Pick a verb in present tense({Definitions.verb})");
                b.blowsVerb = Console.ReadLine();

                Console.WriteLine("6 of 31 - Pick a person's name");
                b.personName = Console.ReadLine();

                Console.WriteLine($"7 of 31 - Pick a noun ({Definitions.noun})");
                b.manNoun = Console.ReadLine();

                Console.WriteLine("8 of 31 - Pick a part of the body");
                b.headBodyPart = Console.ReadLine();

                Console.WriteLine($"9 of 31 - Pick an adjective ({Definitions.adjective})");
                b.deadWord = Console.ReadLine();

                Console.WriteLine($"10 of 31 - Pick a past tense verb ({Definitions.verb})");
                b.thrownVerb = Console.ReadLine();

                Console.WriteLine("11 of 31 - Pick a point in time or a date");
                b.tomorrowDate = Console.ReadLine();

                Console.WriteLine("12 of 31 - Pick an outdated saying, eg. 'Keep on Truckin''");
                b.carryOnSaying = Console.ReadLine();

                Console.WriteLine("13 of 31 - Pick a mode of transport");
                b.timeModeTransport = Console.ReadLine();

                Console.WriteLine("14 of 31 - Pick an emotion eg. sadness");
                b.shiversPluralNoun = Console.ReadLine();

                Console.WriteLine("15 of 31 - Pick a verb ending in -ing eg. dancing");
                b.achingVerb = Console.ReadLine();

                Console.WriteLine("16 of 31 - Pick a videogame boss name eg. Wario");
                b.truthBoss = Console.ReadLine();

                Console.WriteLine($"17 of 31 - Pick a present tense verb ({Definitions.verb})");
                b.dieVerb = Console.ReadLine();

                Console.WriteLine($"18 of 31 - Pick a singular noun ({Definitions.noun})");
                b.silhouettoNoun = Console.ReadLine();

                Console.WriteLine("19 of 31 - Pick a famous gangster name");
                b.scaramoucheFamousGangster = Console.ReadLine();

                Console.WriteLine("20 of 31 - Pick a style of dance");
                b.fandangoDanceMove = Console.ReadLine();

                Console.WriteLine($"21 of 31 - Pick an adjective ({Definitions.adjective})");
                b.frighteningAdjective = Console.ReadLine();

                Console.WriteLine("22 of 31 - Pick a famous person");
                b.galileoFamousPerson = Console.ReadLine();

                Console.WriteLine("23 of 31 - Pick an exclamation eg. 'Holy Moly!' or 'Needs more cowbell!'");
                b.magnificoExcitedRemark = Console.ReadLine();

                Console.WriteLine("24 of 31 - Name one of your prized possessions");
                b.lifePossession = Console.ReadLine();

                Console.WriteLine("25 of 31 - Pick a famous British person");
                b.bismillahFamousBritishPerson = Console.ReadLine();

                Console.WriteLine("26 of 31 - Choose an animal sound");
                b.noAnimalSound = Console.ReadLine();

                Console.WriteLine("27 of 31 - Choose a pet's name");
                b.beezlebubPetName = Console.ReadLine();

                Console.WriteLine($"28 of 31 - Pick a verb in present tense ({Definitions.verb})");
                b.stoneVerb = Console.ReadLine();

                Console.WriteLine("29 of 31 - Pick a body part");
                b.eyeBodyPart = Console.ReadLine();

                Console.WriteLine($"30 of 31 - Almost done! Pick a verb ({Definitions.verb})");
                b.loveVerb = Console.ReadLine();

                Console.WriteLine("Last one! Pick something that is sentimental to you");
                b.nothingNoun = Console.ReadLine();


                Console.WriteLine(
                    $"Is this the real {b.lifeNoun}? \n" +
                    "Is this just fantasy? \n" +
                    $"Caught in a {b.naturalDisaster}, \n" +
                    $"No escape from {b.cartoonCharacter}. \n" +
                    "  \n" +
                    "Open your eyes \n" +
                    $"Look up to the skies and {b.runVerb}, \n" + 
                    $"I'm just a poor {b.boyNoun}, I need no sympathy, \n" +
                    "Because I'm easy come, easy go,\n" +
                    "Little high, little low,\n" +
                    $"any way the wind {b.blowsVerb} doesn't really matter to {b.personName}, to {b.personName}.\n" +
                    "  \n" +
                    $"Mama, just killed a {b.manNoun}, \n" +
                    $"Put a gun against his {b.headBodyPart}, \n" +
                    $"Pulled my trigger, now he's {b.deadWord}.\n" +
                    "Mama, life had just begun,\n" +
                    $"But now I've gone and {b.thrownVerb} it all away.\n" +
                    "  \n" +
                    "Mama, ooh, \n" +
                    "Didn't mean to make you cry,\n" +
                    $"If I'm not back again this time {b.tomorrowDate},\n" +
                    $"{b.carryOnSaying}, {b.carryOnSaying} as if nothing really matters.\n" +
                    "  \n" +
                    $"Too late, my {b.timeModeTransport} has come,\n" +
                    $"Sends {b.shiversPluralNoun} down my spine,\n"+
                    $"Body's {b.achingVerb} all the time.\n"+
                    "Goodbye, everybody, I've got to go\n"+
                    $"Gotta leave you all behind and face {b.truthBoss}.\n"+
                    "  \n" +
                    $"Mama, ooh(Any way the wind {b.blowsVerb}), \n" +
                    $"I don't want to {b.dieVerb}, \n" +
                    "I sometimes wish I'd never been born at all.\n"+
                    "  \n" +
                    $"I see a little {b.silhouettoNoun} of a man,\n" +
                    $"{b.scaramoucheFamousGangster}, {b.scaramoucheFamousGangster}, will you do the {b.fandangoDanceMove}?\n" +
                    $"Thunderbolt and lightning very, very {b.frighteningAdjective} me.\n" +
                    $"({b.galileoFamousPerson}) {b.galileoFamousPerson}.\n" +
                    $"({b.galileoFamousPerson}) {b.galileoFamousPerson},\n" +
                    $"{b.galileoFamousPerson} Figaro\n" +
                    $"{b.magnificoExcitedRemark} - o - o - o - o.\n" +
                    "  \n" +
                    $"I'm just a poor {b.boyNoun}, nobody loves me.\n" +
                    $"He's just a poor {b.boyNoun} from a poor family,\n" +
                    $"Spare him his {b.lifePossession} from this monstrosity.\n"+
                    "  \n" +
                    "easy come, easy go, will you let me go ?\n" +
                    $"{b.bismillahFamousBritishPerson}! No, we will not let you go. (Let him go!)\n" +
                    $"{b.bismillahFamousBritishPerson}! We will not let you go. (Let him go!)\n" +
                    $"{b.bismillahFamousBritishPerson}! We will not let you go. (Let me go!)\n" +
                    "Will not let you go. (Let me go!)\n" +
                    "Never let you go(Never, never, never, never let me go)\n" +
                    "Oh oh oh oh\n" +
                    $"{b.noAnimalSound}, {b.noAnimalSound}, {b.noAnimalSound}, {b.noAnimalSound}, {b.noAnimalSound},{b.noAnimalSound}, {b.noAnimalSound},\n" +
                    "Oh, mama mia, mama mia(Mama mia, let me go.)\n" +
                    $"{b.beezlebubPetName} has a devil put aside for me, for me, for me.\n" +
                    "  \n" +
                    $"So you think you can {b.stoneVerb} me and spit in my {b.eyeBodyPart}?\n" +
                    $"So you think you can {b.loveVerb} me and leave me to {b.dieVerb} ?\n" +
                    $"Oh, {b.beezlebubPetName}, can't do this to me, {b.beezlebubPetName},\n" +
                    "Just gotta get out, just gotta get right outta here.\n" +
                    "  \n" +
                    "(Ooooh, ooh yeah, ooh yeah)\n" +
                    "  \n" +
                    $"{b.nothingNoun} really matters,\n" +
                    "Anyone can see,\n" +
                    $"{b.nothingNoun} really matters,\n" +
                    $"{b.nothingNoun} really matters to me.\n" +
                    "  \n" +
                    $"Any way the wind {b.blowsVerb}..."
                    );

                //Console.Write("Hit enter to keep reading");
                
            }

        }
    }
}
