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
            }
        }
    }
}
