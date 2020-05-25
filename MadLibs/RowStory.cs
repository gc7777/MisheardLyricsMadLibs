using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MadLibs
{
    public class RowStory
    {
        public string boatNoun      = "cat",
                      streamNoun    = "asteroid belt",
                      merrilyAdverb = "suddenly",
                      merrily2      = "effectively",
                      merrily3      = "trepidatiously",
                      dreamNoun     = "Chevrolet";

        public void PlayRow()
        {
            WriteLine("You picked: Row, row, row your ______ (Kindergarten Mode - 6 Words) \n You can skip questions by pressing enter, but where's the fun in that? \n" +
                "************************************************************************");

            WriteLine($"Question 1 of 6 - Pick a noun ({Definitions.noun})");
            string boatString = ReadLine();
            if (!string.IsNullOrEmpty(boatString))
            {
                boatNoun = boatString;
            }

            WriteLine($"Question 2 of 6 - Pick another noun ({Definitions.noun})");
            string streamString = ReadLine();
            if (!string.IsNullOrEmpty(streamString))
            {
                streamNoun = streamString;
            }

            WriteLine($"Question 3 of 6 - Pick an adverb ({Definitions.adverb})");
            string merrilyString = ReadLine();
            if (!string.IsNullOrEmpty(merrilyString))
            {
                merrilyAdverb = merrilyString;
            }

            WriteLine($"Question 4 of 6 - Pick another adverb ({Definitions.adverb})");
            string merrily2String = ReadLine();
            if (!string.IsNullOrEmpty(merrily2String))
            {
                merrily2 = merrily2String;
            }

            WriteLine($"Question 5 of 6 - Pick a third adverb ({Definitions.adverb})");
            string merrily3String = ReadLine();
            if (!string.IsNullOrEmpty(merrily3String))
            {
                merrily3 = merrily3String;
            }

            WriteLine($"Last one! Pick a noun finally ({Definitions.noun})");
            string dreamString = ReadLine();
            if (!string.IsNullOrEmpty(dreamString))
            {
                dreamNoun = dreamString;
            }

            WriteLine($"Here's the story you created, entitled 'Row, row, row your ______' \n Row, row, row your {boatNoun} gently down the {streamNoun}. {merrilyAdverb}, merrily, {merrily2}, {merrily3} life is but a {dreamNoun}.");
        }
    }
}
