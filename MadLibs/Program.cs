using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("1. Row Row Row Your ______");
                Console.WriteLine("2. Bohemian Rhapsody: Misheard Lyrics Edition");
                Console.WriteLine("3. Not just any motivational YouTube Ad");
                int storyChoice = Convert.ToInt32(Console.ReadLine());
                if (storyChoice == 1)
                {
                    PlayRowYourBoat();
                }
                else if (storyChoice == 2)
                {
                    PlayQueen();
                }
                else if(storyChoice == 3)
                {
                    PlayMotivation();
                }
                else
                {
                    Console.WriteLine("Sorry that choice is invalid. Please choose 1, 2, or 3.");
                    PickCategory();
                }
            }

            void PlayRowYourBoat()
            {
                RowStory myRowStory = new RowStory();
                Console.WriteLine("You picked Row, row, row your ______");
                Console.WriteLine("Pick a noun");
                myRowStory.boatNoun = Console.ReadLine();

                Console.WriteLine("Pick another noun");
                myRowStory.streamNoun = Console.ReadLine();

                Console.WriteLine("Pick an adverb");
                myRowStory.merrilyAdverb = Console.ReadLine();

                Console.WriteLine("Pick another adverb");
                myRowStory.merrily2 = Console.ReadLine();

                Console.WriteLine("Pick a third adverb");
                myRowStory.merrily3 = Console.ReadLine();

                Console.WriteLine("Pick a noun finally");
                myRowStory.dreamNoun = Console.ReadLine();

                Console.WriteLine($"Row, row, row your {myRowStory.boatNoun} gently down the {myRowStory.streamNoun}. {myRowStory.merrilyAdverb}, merrily, {myRowStory.merrily2}, {myRowStory.merrily3} life is but a {myRowStory.dreamNoun}.");
            }

            void PlayQueen()
            {
                Bohemian b = new Bohemian();
                Console.WriteLine("You picked: Bohemian Rhapsody: Misheard Lyrics Edition");

                Console.WriteLine(
                    $"Is this the real {b.lifeNoun}? \n " +
                    "Is this just fantasy? \n " +
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
                    "Body's aching all the time.\n"+
                    "Goodbye, everybody, I've got to go\n"+
                    "Gotta leave you all behind and face the truth.\n"+
                    "  \n" +
                    $"Mama, ooh(Any way the wind {b.blowsVerb}), \n" +
                    $"I don't want to {b.dieVerb}, \n" +
                    "I sometimes wish I'd never been born at all.\n"+
                    "  \n" +
                    "I see a little silhouetto of a man,\n" +
                    "Scaramouche, Scaramouche, will you do the Fandango?\n" +
                    "Thunderbolt and lightning very, very frightening me.\n" +
                    "(Galileo) Galileo.\n" +
                    "(Galileo) Galileo,\n" +
                    "Galileo Figaro\n" +
                    "Magnifico - o - o - o - o.\n" +
                    "  \n" +
                    "I'm just a poor boy, nobody loves me.\n" +
                    "He's just a poor boy from a poor family,\n" +
                    "Spare him his life from this monstrosity.\n"+
                    "  \n" +
                    "come, easy go, will you let me go ?\n" +
                    "Bismillah! No, we will not let you go. (Let him go!)\n" +
                    "Bismillah! We will not let you go. (Let him go!)\n" +
                    "Bismillah! We will not let you go. (Let me go!)\n" +
                    "Will not let you go. (Let me go!)\n" +
                    "Never let you go(Never, never, never, never let me go)\n" +
                    "Oh oh oh oh\n" +
                    "No, no, no, no, no, no, no\n" +
                    "Oh, mama mia, mama mia(Mama mia, let me go.)\n" +
                    "Beelzebub has a devil put aside for me, for me, for me.\n" +
                    "  \n" +
                    "So you think you can stone me and spit in my eye ?\n" +
                    "So you think you can love me and leave me to die ?\n" +
                    "Oh, baby, can't do this to me, baby,\n" +
                    "Just gotta get out, just gotta get right outta here.\n" +
                    "  \n" +
                    "(Ooooh, ooh yeah, ooh yeah)\n" +
                    "  \n" +
                    "Nothing really matters,\n" +
                    "Anyone can see,\n" +
                    "Nothing really matters,\n" +
                    "Nothing really matters to me.\n" +
                    "  \n" +
                    $"Any way the wind {b.blowsVerb}..."
                    );

                //Console.Write("Hit enter to keep reading");
                
            }

            void PlayMotivation()
            {
                Motivation m = new Motivation();
                Console.WriteLine("You picked 'Not just any motivational YouTube Ad'");
                Console.WriteLine("Pick a washed up celebrity");
                m.celeb = Console.ReadLine();

                Console.WriteLine("Pick a number between 1-100");
                string response1 = Console.ReadLine();
                int value1;
                while (!int.TryParse(response1, out value1))
                {
                    Console.WriteLine("Didn't I make myself clear? Enter a NUMBER!");
                    response1 = Console.ReadLine();
                }
                m.number = value1;

                Console.WriteLine("Pick a famous talk show host");
                m.talkhost = Console.ReadLine();

                Console.WriteLine("Pick a car model (brand name followed by model)");
                m.carModel = Console.ReadLine();

                Console.WriteLine("Pick a number");
                string response2 = Console.ReadLine();
                int value2;
                while(!int.TryParse(response2, out value2))
                {
                    Console.WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response2 = Console.ReadLine();
                }
                m.number2 = value2;

                Console.WriteLine("Pick a car brand");
                m.carBrand = Console.ReadLine();

                Console.WriteLine("Pick a place");
                m.nounPlace = Console.ReadLine();

                Console.WriteLine("Pick a person");
                m.nounPerson = Console.ReadLine();

                Console.WriteLine("Pick a clothing brand");
                m.clothingBrand = Console.ReadLine();

                Console.WriteLine("Pick a cheap beverage");
                m.cheapBeverage = Console.ReadLine();

                Console.WriteLine($"Pick a plural noun ({Definitions.noun})");
                m.pluralNoun = Console.ReadLine();

                Console.WriteLine("Pick a number");
                string response3 = Console.ReadLine();
                int value3;
                while (!int.TryParse(response3, out value3))
                {
                    Console.WriteLine("Hmm that number looks strange, almost looks like it's NOT a number. Try again.");
                    response3 = Console.ReadLine();
                }
                m.number3 = value3;

                Console.WriteLine($"Pick another plural noun ({Definitions.noun})");
                m.pluralNoun2 = Console.ReadLine();

                Console.WriteLine($"Pick a country");
                m.country = Console.ReadLine();

                Console.WriteLine("Pick a number");
                string response4 = Console.ReadLine();
                int value4;
                while (!int.TryParse(response4, out value4))
                {
                    Console.WriteLine("Numbers only please! Try again. This time, with a number.");
                    response4 = Console.ReadLine();
                }
                m.percentage = value4;

                Console.WriteLine("Pick a website");
                m.website = Console.ReadLine();

                Console.WriteLine($"Pick an exclamation ({Definitions.exclamation})");
                m.exclamation = Console.ReadLine().ToUpper();

                Console.WriteLine("Pick a feeling");
                m.feeling = Console.ReadLine();

                Console.WriteLine("Pick a number");
                string response5 = Console.ReadLine();
                int value5;
                while (!int.TryParse(response5, out value5))
                {
                    Console.WriteLine("That number looks strange, almost like it's not a number. Give it another shot.");
                    response5 = Console.ReadLine();
                }
                m.amount = value5;

                Console.WriteLine("Pick a city");
                m.city = Console.ReadLine();

                Console.WriteLine($"Pick another plural noun ({Definitions.noun})");
                m.pluralNoun3 = Console.ReadLine();

                Console.WriteLine("Pick a number");
                string response6 = Console.ReadLine();
                int value6;
                while (!int.TryParse(response6, out value6))
                {
                    Console.WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response6 = Console.ReadLine();
                }
                m.percentage2 = value6;
               

                Console.WriteLine("Pick a verb ending in -ing eg. 'running'");
                m.verbING = Console.ReadLine();

                Console.WriteLine($"Pick a noun ({Definitions.noun})");
                m.noun = Console.ReadLine();

                Console.WriteLine("Pick a beverage");
                m.beverage = Console.ReadLine();

                Console.WriteLine($"Pick a place");
                m.place = Console.ReadLine();

                Console.WriteLine($"Pick a verb ({Definitions.verb})");
                m.verb = Console.ReadLine();

                Console.WriteLine($"Pick an adverb ({Definitions.adverb})");
                m.adverb = Console.ReadLine();

                Console.WriteLine("Almost there! Pick a number");
                string response7 = Console.ReadLine();
                int value7;
                while (!int.TryParse(response7, out value7))
                {
                    Console.WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response7 = Console.ReadLine();
                }
                m.number4 = value7;

                Console.WriteLine("Your patience has paid off. This is the last one: Pick a number");
                string response8 = Console.ReadLine();
                int value8;
                while (!int.TryParse(response8, out value8))
                {
                    Console.WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response8 = Console.ReadLine();
                }
                m.number4 = value8;

                Console.WriteLine("Here's the story you created: entitled 'Not just any motivational YouTube Ad'");
                Console.WriteLine($"Hi, my name is {m.celeb} and I'm gonna teach you about how I make ${m.number} while I'm sleeping. Pay attention, because I'm going to share with you the stuff not even {m.talkhost} will tell you about finance. I'm coming to you from my garage, just took my {m.carModel} out for a spin. I know what you're thinking. You see me standing in front of my {m.number2} {m.carBrand}s and you're asking yourself, '{m.celeb}, what's your secret?' By the end of this, you're gonna want to quit your day job. About six years ago, I was working at {m.nounPlace} when my mentor {m.nounPerson} came in wearing {m.clothingBrand} shoes and I just knew I had to be like them. We went out for a {m.cheapBeverage} and they told me, '{m.celeb}, in order to retire early you need to dropship {m.pluralNoun}.' At that time I had no idea what dropshipping was, but what I heard was so simple. {m.nounPerson} said, 'All you have to do is just buy {m.number3} {m.pluralNoun2} from {m.country} and sell them at a {m.percentage}% markup on {m.website}. That's it! That's all you gotta do.' When {m.nounPerson} told me how easy it was, I was so {m.feeling} just shouted from the rooftops, '{m.exclamation}!!' Then I just cash my cheque for ${m.amount} and then I can spend it on whatever I want. If I want to vacation in {m.city} no one's gonna stop me. I've got the freedom to buy {m.pluralNoun3} every day if I want to. I'll tell you what, {m.percentage2}% of people won't even try this. They'll be stuck {m.verbING} all day at a {m.noun} they hate and I'll be laughing, drinking my {m.beverage} by the {m.place}. And you can too if you buy my ebook, 'How to {m.verb} {m.adverb}' for the low, low price of ${m.number4} but only for the next {m.number5} minutes. We can't do this all day.");

                Console.Read();
            }
        }
    }
}
