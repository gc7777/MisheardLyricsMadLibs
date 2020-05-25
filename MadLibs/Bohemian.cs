using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MadLibs
{
    class Bohemian
    {
        public string
            lifeNoun                     = "life",
            naturalDisaster              = "landslide",
            cartoonCharacter             = "reality",
            runVerb                      = "see",
            boyNoun                      = "boy",
            blowsVerb                    = "blows",
            personName                   = "me",
            manNoun                      = "man",
            headBodyPart                 = "head",
            deadWord                     = "dead",
            thrownVerb                   = "thrown",
            tomorrowDate                 = "tomorrow",
            carryOnSaying                = "carry on", //old motto "keep on truckin"
            timeModeTransport            = "time", // transport like bus
            shiversPluralNoun            = "shivers",
            achingVerb                   = "aching",
            truthBoss                    = "truth",
            dieVerb                      = "die",
            silhouettoNoun               = "silhouetto",
            scaramoucheFamousGangster    = "scaramouche",
            fandangoDanceMove            = "fandango",
            frighteningAdjective         = "frightening",
            galileoFamousPerson          = "galileo",
            magnificoExcitedRemark       = "magnifico",
            lifePossession               = "life",
            bismillahFamousBritishPerson = "Bismillah",
            noAnimalSound                = "no",
            beezlebubPetName             = "Beezelbub",
            stoneVerb                    = "stone",
            eyeBodyPart                  = "eye",
            loveVerb                     = "love",
            nothingNoun                  = "nothing"; // user's sentimental item

        public void PlayQueen()
        {
            WriteLine("You picked: Bohemian Rhapsody: Misheard Lyrics Edition (31 words) \n You can skip questions, but they where's the fun in that? \n *****************************************************************");
            WriteLine();

            WriteLine($"Question 1 of 31 - Pick a noun ({Definitions.noun})");
            lifeNoun = ReadLine();

            WriteLine("2 of 31 - Pick a natural disaster eg. flood");
            naturalDisaster = ReadLine();

            WriteLine("3 of 31 - Pick a cartoon character");
            cartoonCharacter = ReadLine();

            WriteLine($"4 of 31 - Pick a verb in present tense ({Definitions.verb})");
            runVerb = ReadLine();

            WriteLine($"5 of 31 - Pick a noun ({Definitions.noun})");
            boyNoun = ReadLine();

            WriteLine($"6 of 31 - Pick a verb in present tense({Definitions.verb})");
            blowsVerb = ReadLine();

            WriteLine("7 of 31 - Pick a person's name");
            personName = ReadLine();

            WriteLine($"8 of 31 - Pick a noun ({Definitions.noun})");
            manNoun = ReadLine();

            WriteLine("9 of 31 - Pick a part of the body");
            headBodyPart = ReadLine();

            WriteLine($"10 of 31 - Pick an adjective ({Definitions.adjective})");
            deadWord = ReadLine();

            WriteLine($"11 of 31 - Pick a past tense verb ({Definitions.verb})");
            thrownVerb = ReadLine();

            WriteLine("12 of 31 - Pick a point in time or a date");
            tomorrowDate = ReadLine();

            WriteLine("13 of 31 - Pick an outdated saying, eg. 'Keep on Truckin''");
            carryOnSaying = ReadLine();

            WriteLine("14 of 31 - Pick a mode of transport");
            timeModeTransport = ReadLine();

            WriteLine("15 of 31 - Pick an emotion eg. sadness");
            shiversPluralNoun = ReadLine();

            WriteLine("16 of 31 - Pick a verb ending in -ing eg. dancing");
            achingVerb = ReadLine();

            WriteLine("17 of 31 - Pick a videogame boss name eg. Wario");
            truthBoss = ReadLine();

            WriteLine($"18 of 31 - Pick a present tense verb ({Definitions.verb})");
            dieVerb = ReadLine();

            WriteLine($"19 of 31 - Pick a singular noun ({Definitions.noun})");
            silhouettoNoun = ReadLine();

            WriteLine("20 of 31 - Pick a famous gangster name");
            scaramoucheFamousGangster = ReadLine();

            WriteLine("21 of 31 - Pick a style of dance");
            fandangoDanceMove = ReadLine();

            WriteLine($"22 of 31 - Pick an adjective ({Definitions.adjective})");
            frighteningAdjective = ReadLine();

            WriteLine("23 of 31 - Pick a famous person");
            galileoFamousPerson = ReadLine();

            WriteLine("24 of 31 - Pick an exclamation eg. 'Holy Moly!' or 'Needs more cowbell!'");
            magnificoExcitedRemark = ReadLine();

            WriteLine("25 of 31 - Name one of your prized possessions");
            lifePossession = ReadLine();

            WriteLine("26 of 31 - Pick a famous British person");
            bismillahFamousBritishPerson = ReadLine();

            WriteLine("27 of 31 - Choose an animal sound");
            noAnimalSound = ReadLine();

            WriteLine("28 of 31 - Choose a pet's name");
            beezlebubPetName = ReadLine();

            WriteLine($"29 of 31 - Pick a verb in present tense ({Definitions.verb})");
            stoneVerb = ReadLine();

            WriteLine("30 of 31 - Pick a body part");
            eyeBodyPart = ReadLine();

            WriteLine($"31 of 31 - Almost done! Pick a verb ({Definitions.verb})");
            loveVerb = ReadLine();

            WriteLine("Last one! Pick something that is sentimental to you");
            nothingNoun = ReadLine();

            WriteLine(
                    $"Is this the real {lifeNoun}? \n" +
                    "Is this just fantasy? \n" +
                    $"Caught in a {naturalDisaster}, \n" +
                    $"No escape from {cartoonCharacter}. \n" +
                    "  \n" +
                    "Open your eyes \n" +
                    $"Look up to the skies and {runVerb}, \n" +
                    $"I'm just a poor {boyNoun}, I need no sympathy, \n" +
                    "Because I'm easy come, easy go,\n" +
                    "Little high, little low,\n" +
                    $"any way the wind {blowsVerb} doesn't really matter to {personName}, to {personName}.\n" +
                    "  \n" +
                    $"Mama, just killed a {manNoun}, \n" +
                    $"Put a gun against his {headBodyPart}, \n" +
                    $"Pulled my trigger, now he's {deadWord}.\n" +
                    "Mama, life had just begun,\n" +
                    $"But now I've gone and {thrownVerb} it all away.\n" +
                    "  \n" +
                    "Mama, ooh, \n" +
                    "Didn't mean to make you cry,\n" +
                    $"If I'm not back again this time {tomorrowDate},\n" +
                    $"{carryOnSaying}, {carryOnSaying} as if nothing really matters.\n" +
                    "  \n" +
                    $"Too late, my {timeModeTransport} has come,\n" +
                    $"Sends {shiversPluralNoun} down my spine,\n" +
                    $"Body's {achingVerb} all the time.\n" +
                    "Goodbye, everybody, I've got to go\n" +
                    $"Gotta leave you all behind and face {truthBoss}.\n" +
                    "  \n" +
                    $"Mama, ooh(Any way the wind {blowsVerb}), \n" +
                    $"I don't want to {dieVerb}, \n" +
                    "I sometimes wish I'd never been born at all.\n" +
                    "  \n" +
                    $"I see a little {silhouettoNoun} of a man,\n" +
                    $"{scaramoucheFamousGangster}, {scaramoucheFamousGangster}, will you do the {fandangoDanceMove}?\n" +
                    $"Thunderbolt and lightning very, very {frighteningAdjective} me.\n" +
                    $"({galileoFamousPerson}) {galileoFamousPerson}.\n" +
                    $"({galileoFamousPerson}) {galileoFamousPerson},\n" +
                    $"{galileoFamousPerson} Figaro\n" +
                    $"{magnificoExcitedRemark} - o - o - o - o.\n" +
                    "  \n" +
                    $"I'm just a poor {boyNoun}, nobody loves me.\n" +
                    $"He's just a poor {boyNoun} from a poor family,\n" +
                    $"Spare him his {lifePossession} from this monstrosity.\n" +
                    "  \n" +
                    "easy come, easy go, will you let me go ?\n" +
                    $"{bismillahFamousBritishPerson}! No, we will not let you go. (Let him go!)\n" +
                    $"{bismillahFamousBritishPerson}! We will not let you go. (Let him go!)\n" +
                    $"{bismillahFamousBritishPerson}! We will not let you go. (Let me go!)\n" +
                    "Will not let you go. (Let me go!)\n" +
                    "Never let you go(Never, never, never, never let me go)\n" +
                    "Oh oh oh oh\n" +
                    $"{noAnimalSound}, {noAnimalSound}, {noAnimalSound}, {noAnimalSound}, {noAnimalSound},{noAnimalSound}, {noAnimalSound},\n" +
                    "Oh, mama mia, mama mia(Mama mia, let me go.)\n" +
                    $"{beezlebubPetName} has a devil put aside for me, for me, for me.\n" +
                    "  \n" +
                    $"So you think you can {stoneVerb} me and spit in my {eyeBodyPart}?\n" +
                    $"So you think you can {loveVerb} me and leave me to {dieVerb} ?\n" +
                    $"Oh, {beezlebubPetName}, can't do this to me, {beezlebubPetName},\n" +
                    "Just gotta get out, just gotta get right outta here.\n" +
                    "  \n" +
                    "(Ooooh, ooh yeah, ooh yeah)\n" +
                    "  \n" +
                    $"{nothingNoun} really matters,\n" +
                    "Anyone can see,\n" +
                    $"{nothingNoun} really matters,\n" +
                    $"{nothingNoun} really matters to me.\n" +
                    "  \n" +
                    $"Any way the wind {blowsVerb}..."
                    );
        }
    }
}
