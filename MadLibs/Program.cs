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
                Console.WriteLine("2. I wanna know what ______ is.");
                Console.WriteLine("3. Not just any motivational YouTube Ad");
                int storyChoice = Convert.ToInt32(Console.ReadLine());
                if (storyChoice == 1)
                {
                    PlayRowYourBoat();
                }
                else if (storyChoice == 2)
                {
                    PlayForeigner();
                }
                else if(storyChoice == 3)
                {
                    PlayMotivation();
                }
                else
                {
                    Console.WriteLine("Sorry that choice is invalid. Please choose 1 or 2");
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

                //ReadRow();
                Console.WriteLine($"Row, row, row your {myRowStory.boatNoun} gently down the {myRowStory.streamNoun}. {myRowStory.merrilyAdverb}, merrily, {myRowStory.merrily2}, {myRowStory.merrily3} life is but a {myRowStory.dreamNoun}.");
            }

            void PlayForeigner()
            {
                Console.WriteLine("You picked 'I wanna know what  ______ is.");
            }

            void PlayMotivation()
            {
                Motivation m = new Motivation();
                Console.WriteLine("You picked 'Not just any motivational YouTube Ad'");
                Console.WriteLine("Pick a washed up celebrity");
                m.celeb = Console.ReadLine();

                Console.WriteLine("Pick a dollar amount");
                m.number = Console.ReadLine();

                Console.WriteLine("Pick a famous talk show host");
                m.talkhost = Console.ReadLine();

                Console.WriteLine("Pick a car brand");
                m.carBrand = Console.ReadLine();

                Console.WriteLine("Pick a number");
                m.number = Console.ReadLine();

                Console.WriteLine("Pick another car brand");
                m.carBrand2 = Console.ReadLine();

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
                m.number3 = Console.ReadLine();

                Console.WriteLine($"Pick another plural noun ({Definitions.noun})");
                m.pluralNoun2 = Console.ReadLine();

                Console.WriteLine("Pick a percentage eg. 50");
                m.percentage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a website");
                m.website = Console.ReadLine();

                Console.WriteLine("Pick a whole dollar amount (leave out the $ sign) eg. 500");
                m.amount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a city");
                m.city = Console.ReadLine();

                Console.WriteLine($"Pick another plural noun ({Definitions.noun})");
                m.pluralNoun3 = Console.ReadLine();

                Console.WriteLine("Pick a number");
                m.percentage2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a verb ending in -ing eg. 'running'");
                m.verbING = Console.ReadLine();

                Console.WriteLine($"Pick a noun ({Definitions.noun})");
                m.noun = Console.ReadLine();

                Console.WriteLine("Pick a beverage");
                m.beverage = Console.ReadLine();

                Console.WriteLine($"Pick another noun ({Definitions.noun})");
                m.noun2 = Console.ReadLine();

                Console.WriteLine($"Pick a verb ({Definitions.verb})");
                m.verb = Console.ReadLine();

                Console.WriteLine($"Pick an adverb ({Definitions.adverb})");
                m.adverb = Console.ReadLine();

                Console.WriteLine("Last one! Pick a number");
                m.number4 = Console.ReadLine();

                Console.WriteLine("Here's the story you created: entitled 'Not just any motivational YouTube Ad'");
                Console.WriteLine($"Hi, my name is {m.celeb} and I'm gonna teach you about how I make $ {m.number} while I'm sleeping. Pay attention, because I'm going to tell you stuff not even {m.talkhost} will tell you about finance. I'm coming to you from my garage, just took my {m.carBrand} out for a spin. I know what you're thinking. You see me standing in front of my {m.number2} {m.carBrand2}s and you're asking yourself, '{m.celeb} what's your secret?' Pay attention and I'll teach you everything. About six years ago, I was working at {m.nounPlace} and my mentor {m.nounPerson} came in wearing {m.clothingBrand} shoes and I just knew I had to be like him. I took him out for {m.cheapBeverage} and he told me, '{m.celeb}, you need to dropship {m.pluralNoun}.' At that time I had no idea what dropshipping was, but what he told me was so simple. All you have to do is just buy {m.number2} {m.pluralNoun2} from {m.country} and sell them at a {m.percentage} markup on {m.website}. That's it! That is all I do. Then I just cash my cheque for ${m.amount} and then I can spend it on whatever I want. If I want to vacation in {m.city} no one's gonna stop me. I've got the freedom to buy {m.pluralNoun3} every day if I want to. I'll tell you what, {m.percentage2} of people won't even try this. They'll be stuck {m.verbING} all day at a {m.noun} they hate and I'll be laughing, drinking my {m.beverage} by the {m.noun2}. And you can too if you buy my ebook, 'How to {m.verb} {m.adverb}' but only for the next {m.number4} minutes. We can't do this all day.");
            }
        }
    }
}
