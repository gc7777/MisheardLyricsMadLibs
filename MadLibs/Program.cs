using System;
using static System.Console;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            RowStory   r = new RowStory();
            Motivation m = new Motivation();
            Bohemian   b = new Bohemian();
            GoToMainMenu();

            void GoToMainMenu()
            {
                WriteLine("Welcome to Mad Libs");
                WriteLine("-------------------");
                WriteLine("Have you played Mad Libs before? Y / N");

                string response = ReadLine();
                if (response == "Y" || response == "y")
                {
                    PickCategory();
                }
                else if (response == "N" || response == "n")
                {
                    WriteLine("Here's how you play: " + Definitions.instructions);
                    WriteLine();
                    PickCategory();
                }
                else
                {
                    WriteLine("Please select either Y for yes or N for no");
                    GoToMainMenu();
                }
            }

            void PickCategory()
            {
                WriteLine("Alright, let's play!");
                WriteLine("Pick a story:");
                WriteLine("1. Row Row Row Your ______ (Kindergarten Mode - 6 Words)");
                WriteLine("2. Not Just Any Motivational YouTube Ad (Challenge Accepted Mode - 30 Word Choices)");
                WriteLine("3. Bohemian Rhapsody: Misheard Lyrics Edition (Epic Mode - 31 Word Choices)");
                
                int storyChoice = Convert.ToInt32(ReadLine());
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
                    b.PlayQueen();
                }
                else
                {
                    WriteLine("Sorry that choice is invalid. Please choose 1, 2, or 3.");
                    PickCategory();
                }
            }
        }
    }
}
