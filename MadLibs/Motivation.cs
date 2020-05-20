using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MadLibs
{
    public class Motivation
    {
        public string 
          celeb         = "",
          talkhost      = "",
          carModel      = "",
          carBrand      = "",
          nounPlace     = "",
          nounPerson    = "",
          clothingBrand = "",
          cheapBeverage = "",
          pluralNoun    = "",
          pluralNoun2   = "",
          country       = "",
          website       = "",
          exclamation   = "",
          feeling       = "",
          city          = "",
          pluralNoun3   = "",
          verbING       = "",
          noun          = "",
          beverage      = "",
          place         = "",
          verb          = "",
          adverb        = "";

        public int 
          number           = 0,
          number2          = 0,
          number3          = 0,
          percentage       = 0,
          amount           = 0,
          percentage2      = 0,
          number4          = 0,
          number5          = 0;

        public void PlayMotivation()
        {
            WriteLine("You picked 'Not just any motivational YouTube Ad'");
            WriteLine("Pick a washed up celebrity");
            celeb = ReadLine();

            WriteLine("Pick a number between 1-100");
            string response1 = ReadLine();
            int value1;
            while (!int.TryParse(response1, out value1))
            {
                WriteLine("Didn't I make myself clear? Enter a NUMBER!");
                response1 = ReadLine();
            }
            number = value1;

            WriteLine("Pick a famous talk show host");
            talkhost = ReadLine();

            WriteLine("Pick a car model (brand name followed by model)");
            carModel = ReadLine();

            WriteLine("Pick a number");
            string response2 = ReadLine();
            int value2;
            while (!int.TryParse(response2, out value2))
            {
                WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                response2 = ReadLine();
            }
            number2 = value2;

            WriteLine("Pick a car brand");
            carBrand = ReadLine();

            WriteLine("Pick a place");
            nounPlace = ReadLine();

            WriteLine("Pick a person");
            nounPerson = ReadLine();

            WriteLine("Pick a clothing brand");
            clothingBrand = ReadLine();

            WriteLine("Pick a cheap beverage");
            cheapBeverage = ReadLine();

            WriteLine($"Pick a plural noun ({Definitions.noun})");
            pluralNoun = ReadLine();

            WriteLine("Pick a number");
            string response3 = ReadLine();
            int value3;
            while (!int.TryParse(response3, out value3))
            {
                WriteLine("Hmm that number looks strange, almost looks like it's NOT a number. Try again.");
                response3 = ReadLine();
            }
            number3 = value3;

            WriteLine($"Pick another plural noun ({Definitions.noun})");
            pluralNoun2 = ReadLine();

            WriteLine($"Pick a country");
            country = ReadLine();

            WriteLine("Pick a number");
            string response4 = ReadLine();
            int value4;
            while (!int.TryParse(response4, out value4))
            {
                WriteLine("Numbers only please! Try again. This time, with a number.");
                response4 = ReadLine();
            }
            percentage = value4;

            WriteLine("Pick a website");
            website = ReadLine();

            WriteLine($"Pick an exclamation ({Definitions.exclamation})");
            exclamation = ReadLine().ToUpper();

            WriteLine("Pick a feeling");
            feeling = ReadLine();

            WriteLine("Pick a number");
            string response5 = ReadLine();
            int value5;
            while (!int.TryParse(response5, out value5))
            {
                WriteLine("That number looks strange, almost like it's not a number. Give it another shot.");
                response5 = ReadLine();
            }
            amount = value5;

            WriteLine("Pick a city");
            city = ReadLine();

            WriteLine($"Pick another plural noun ({Definitions.noun})");
            pluralNoun3 = ReadLine();

            WriteLine("Pick a number");
            string response6 = ReadLine();
            int value6;
            while (!int.TryParse(response6, out value6))
            {
                WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                response6 = ReadLine();
            }
            percentage2 = value6;


            WriteLine("Pick a verb ending in -ing eg. 'running'");
            verbING = ReadLine();

            WriteLine($"Pick a noun ({Definitions.noun})");
            noun = ReadLine();

            WriteLine("Pick a beverage");
            beverage = ReadLine();

            WriteLine($"Pick a place");
            place = ReadLine();

            WriteLine($"Pick a verb ({Definitions.verb})");
            verb = ReadLine();

            WriteLine($"Pick an adverb ({Definitions.adverb})");
            adverb = ReadLine();

            WriteLine("Almost there! Pick a number");
            string response7 = ReadLine();
            int value7;
            while (!int.TryParse(response7, out value7))
            {
                WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                response7 = ReadLine();
            }
            number4 = value7;

            WriteLine("Your patience has paid off. This is the last one: Pick a number");
            string response8 = ReadLine();
            int value8;
            while (!int.TryParse(response8, out value8))
            {
                WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                response8 = ReadLine();
            }
            number4 = value8;

            WriteLine("Here's the story you created: entitled 'Not just any motivational YouTube Ad'");
            WriteLine($"Hi, my name is {celeb} and I'm gonna teach you about how I make ${number} while I'm sleeping. Pay attention, because I'm going to share with you the stuff not even {talkhost} will tell you about finance. I'm coming to you from my garage, just took my {carModel} out for a spin. I know what you're thinking. You see me standing in front of my {number2} {carBrand}s and you're asking yourself, '{celeb}, what's your secret?' By the end of this, you're gonna want to quit your day job. About six years ago, I was working at {nounPlace} when my mentor {nounPerson} came in wearing {clothingBrand} shoes and I just knew I had to be like the We went out for a {cheapBeverage} and they told me, '{celeb}, in order to retire early you need to dropship {pluralNoun}.' At that time I had no idea what dropshipping was, but what I heard was so simple. {nounPerson} said, 'All you have to do is just buy {number3} {pluralNoun2} from {country} and sell them at a {percentage}% markup on {website}. That's it! That's all you gotta do.' When {nounPerson} told me how easy it was, I was so {feeling} just shouted from the rooftops, '{exclamation}!!' Then I just cash my cheque for ${amount} and then I can spend it on whatever I want. If I want to vacation in {city} no one's gonna stop me. I've got the freedom to buy {pluralNoun3} every day if I want to. I'll tell you what, {percentage2}% of people won't even try this. They'll be stuck {verbING} all day at a {noun} they hate and I'll be laughing, drinking my {beverage} by the {place}. And you can too if you buy my ebook, 'How to {verb} {adverb}' for the low, low price of ${number4} but only for the next {number5} minutes. We can't do this all day.");

            Read();
        }
    }
}
