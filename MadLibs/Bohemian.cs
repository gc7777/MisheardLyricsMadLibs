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
            WriteLine("You picked: Bohemian Rhapsody: Misheard Lyrics Edition (31 words) \n You can skip questions, but then where's the fun in that? \n *****************************************************************");
            WriteLine();

            WriteLine($"Question 1 of 31 - Pick a noun ({Definitions.noun})");
            string lifeString = ReadLine();
            if (!string.IsNullOrEmpty(lifeString))
            {
                lifeNoun = lifeString;
            }

            WriteLine("2 of 31 - Pick a natural disaster eg. flood");
            string naturalString = ReadLine();
            if (!string.IsNullOrEmpty(naturalString))
            {
                naturalDisaster = naturalString;
            }

            WriteLine("3 of 31 - Pick a cartoon character");
            string cartoonString = ReadLine();
            if (!string.IsNullOrEmpty(cartoonString))
            {
                cartoonCharacter = cartoonString;
            }

            WriteLine($"4 of 31 - Pick a verb in present tense ({Definitions.verb})");
            string runString = ReadLine();
            if (!string.IsNullOrEmpty(runString))
            {
                runVerb = runString;
            }

            WriteLine($"5 of 31 - Pick a noun ({Definitions.noun})");
            string boyString = ReadLine();
            if (!string.IsNullOrEmpty(boyString))
            {
                boyNoun = boyString;
            }

            WriteLine($"6 of 31 - Pick a verb in present tense({Definitions.verb})");
            string blowString = ReadLine();
            if (!string.IsNullOrEmpty(blowString))
            {
                blowsVerb = blowString;
            }

            WriteLine("7 of 31 - Pick a person's name");
            string personNameString = ReadLine();
            if (!string.IsNullOrEmpty(personNameString))
            {
                personName = personNameString;
            }

            WriteLine($"8 of 31 - Pick a noun ({Definitions.noun})");
            string manString = ReadLine();
            if (!string.IsNullOrEmpty(manString))
            {
                manNoun = manString;
            }

            WriteLine("9 of 31 - Pick a part of the body");
            string headString = ReadLine();
            if (!string.IsNullOrEmpty(headString))
            {
                headBodyPart = headString;
            }

            WriteLine($"10 of 31 - Pick an adjective ({Definitions.adjective})");
            string deadString = ReadLine();
            if (!string.IsNullOrEmpty(deadString))
            {
                deadWord = deadString;
            }

            WriteLine($"11 of 31 - Pick a past tense verb ({Definitions.verb})");
            string thrownVerbString = ReadLine();
            if (!string.IsNullOrEmpty(thrownVerbString))
            {
                thrownVerb = thrownVerbString;
            }

            WriteLine("12 of 31 - Pick a point in time or a date");
            string tomorrowString = ReadLine();
            if (!string.IsNullOrEmpty(tomorrowString))
            {
                tomorrowDate = tomorrowString;
            }

            WriteLine("13 of 31 - Pick an outdated saying, eg. 'Keep on Truckin''");
            string carryOnSayingString = ReadLine();
            if (!string.IsNullOrEmpty(carryOnSayingString))
            {
                carryOnSaying = carryOnSayingString;
            }

            WriteLine("14 of 31 - Pick a mode of transport");
            string timeString = ReadLine();
            if (!string.IsNullOrEmpty(timeString))
            {
                timeModeTransport = timeString;
            }

            WriteLine("15 of 31 - Pick an emotion eg. sadness");
            string shiversString = ReadLine();
            if (!string.IsNullOrEmpty(shiversString))
            {
                shiversPluralNoun = shiversString;
            }

            WriteLine("16 of 31 - Pick a verb ending in -ing eg. dancing");
            string achingString = ReadLine();
            if (!string.IsNullOrEmpty(achingString))
            {
                achingVerb = achingString;
            }

            WriteLine("17 of 31 - Pick a videogame boss name eg. Wario");
            string truthString = ReadLine();
            if (!string.IsNullOrEmpty(truthString))
            {
                truthBoss = truthString;
            }

            WriteLine($"18 of 31 - Pick a present tense verb ({Definitions.verb})");
            string dieString = ReadLine();
            if (!string.IsNullOrEmpty(dieString))
            {
                dieVerb = dieString;
            }

            WriteLine($"19 of 31 - Pick a singular noun ({Definitions.noun})");
            string silhouettoString = ReadLine();
            if (!string.IsNullOrEmpty(silhouettoString))
            {
                silhouettoNoun = silhouettoString;
            }

            WriteLine("20 of 31 - Pick a famous gangster name");
            string scaramoucheString = ReadLine();
            if (!string.IsNullOrEmpty(scaramoucheString))
            {
                scaramoucheFamousGangster = scaramoucheString;
            }

            WriteLine("21 of 31 - Pick a style of dance");
            string fandangoString = ReadLine();
            if (!string.IsNullOrEmpty(fandangoString))
            {
                fandangoDanceMove = fandangoString;
            }

            WriteLine($"22 of 31 - Pick an adjective ({Definitions.adjective})");
            string frighteningString = ReadLine();
            if (!string.IsNullOrEmpty(frighteningString))
            {
                frighteningAdjective = frighteningString;
            }

            WriteLine("23 of 31 - Pick a famous person");
            string galileoString = ReadLine();
            if (!string.IsNullOrEmpty(galileoString))
            {
                galileoFamousPerson = galileoString;
            }

            WriteLine("24 of 31 - Pick an exclamation eg. 'Holy Moly!' or 'Needs more cowbell!'");
            string magnificoString = ReadLine();
            if (!string.IsNullOrEmpty(magnificoString))
            {
                magnificoExcitedRemark = magnificoString;
            }

            WriteLine("25 of 31 - Name one of your prized possessions");
            string lifePossessionString = ReadLine();
            if (!string.IsNullOrEmpty(lifePossessionString))
            {
                lifePossession = lifePossessionString;
            }

            WriteLine("26 of 31 - Pick a famous British person");
            string bismillahString = ReadLine();
            if (!string.IsNullOrEmpty(bismillahString))
            {
                bismillahFamousBritishPerson = bismillahString;
            }

            WriteLine("27 of 31 - Choose an animal sound");
            string noAnimalSoundString = ReadLine();
            if (!string.IsNullOrEmpty(noAnimalSoundString))
            {
                noAnimalSound = noAnimalSoundString;
            }

            WriteLine("28 of 31 - Choose a pet's name");
            string beezlebubString = ReadLine();
            if (!string.IsNullOrEmpty(beezlebubString))
            {
                beezlebubPetName = beezlebubString;
            }
            beezlebubPetName = ReadLine();

            WriteLine($"29 of 31 - Pick a verb in present tense ({Definitions.verb})");
            string stoneVerbString = ReadLine();
            if (!string.IsNullOrEmpty(stoneVerbString))
            {
                stoneVerb = stoneVerbString;
            }

            WriteLine("30 of 31 - Pick a body part");
            string eyeString = ReadLine();
            if (!string.IsNullOrEmpty(eyeString))
            {
                eyeBodyPart = eyeString;
            }

            WriteLine($"31 of 31 - Almost done! Pick a verb ({Definitions.verb})");
            string loveString = ReadLine();
            if (!string.IsNullOrEmpty(loveString))
            {
                loveVerb = loveString;
            }

            WriteLine("Last one! Pick something that is sentimental to you");
            string nothingString = ReadLine();
            if (!string.IsNullOrEmpty(nothingString))
            {
                nothingNoun = nothingString;
            }

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
                    "  \n");

            //WriteLine("Press any key to continue..");

            WriteLine(
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
