using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MadLibs
{
    public class RowStory
    {
        public string boatNoun      = "boat",
                      streamNoun    = "stream",
                      merrilyAdverb = "merrily",
                      merrily2      = "merrily",
                      merrily3      = "merrily",
                      dreamNoun     = "noun";


        public void Play()
        {
            WriteLine("You picked Row, row, row your ______");
            WriteLine($"Pick a noun ({Definitions.noun})");
            boatNoun = ReadLine();

            WriteLine($"Pick another noun");
            streamNoun = ReadLine();

            WriteLine($"Pick an adverb");
            merrilyAdverb = ReadLine();

            WriteLine($"Pick another adverb");
            merrily2 = ReadLine();

            WriteLine($"Pick a third adverb");
            merrily3 = ReadLine();

            WriteLine($"Pick a noun finally");
            dreamNoun = ReadLine();

            WriteLine($"Row, row, row your {boatNoun} gently down the {streamNoun}. {merrilyAdverb}, merrily, {merrily2}, {merrily3} life is but a {dreamNoun}.");
        }
    }
}
