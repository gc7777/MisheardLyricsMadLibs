using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace MadLibs
{
    public class Motivation
    {
        public string 
          celeb         = "Justin Bieber",
          talkhost      = "Maury Povich",
          carModel      = "1993 Honda Civic",
          carBrand      = "Datsun",
          nounPlace     = "Lifeguard Tower",
          nounPerson    = "Crocodile Dundee",
          clothingBrand = "George by Walmart",
          cheapBeverage = "RC Cola",
          pluralNoun    = "free samples of dental floss",
          pluralNoun2   = "sandpaper",
          country       = "Republic of Congo",
          website       = "myspace.com",
          exclamation   = "Tame Impala is not a band it's just one guy!",
          feeling       = "trepidatious",
          city          = "Pyong Jang",
          pluralNoun3   = "sloths",
          verbING       = "understanding",
          noun          = "8 track",
          beverage      = "President's Choice brand cream soda",
          place         = "wormhole",
          verb          = "reverb",
          adverb        = "interestingly";

        public int 
          number           = 10,
          number2          = 8000,
          number3          = 23,
          percentage       = 75,
          amount           = 3000,
          percentage2      = 2,
          number4          = 1330,
          number5          = 220;

        public void PlayMotivation()
        {
            WriteLine("You picked: 'Not just any motivational YouTube Ad (Challenge Accepted Mode - 30 Word Choices)' \n You can skip questions by pressing enter, but where's the fun in that? \n" +
                "************************************************************************");

            WriteLine("Question 1 of 30 - Pick a washed up celebrity");
            string celebString = ReadLine();
            if (!string.IsNullOrEmpty(celebString))
            {
                celeb = celebString;
            }

            WriteLine("Question 2 of 30 - Pick a number between 1-100");
            string response1 = ReadLine();
            int value1;
            if (!string.IsNullOrEmpty(response1))
            {
                while (!int.TryParse(response1, out value1))
                {
                    WriteLine("Didn't I make myself clear? Enter a NUMBER!");
                    response1 = ReadLine();
                }
                number = value1;
            }

            WriteLine("Question 3 of 30 - Pick a famous talk show host");
            string hostString = ReadLine();
            if (!string.IsNullOrEmpty(hostString))
            {
                talkhost = hostString;
            }

            WriteLine("Question 4 of 30 - Pick a car model (brand name followed by model)");
            string carModelString = ReadLine();
            if (!string.IsNullOrEmpty(carModelString))
            {
                carModel = carModelString;
            }
                

            WriteLine("Question 5 of 30 - Pick a number");
            string response2 = ReadLine();
            int value2;
            if (!string.IsNullOrEmpty(response2))
            {
                while (!int.TryParse(response2, out value2))
                {
                    WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response2 = ReadLine();
                }
                number2 = value2;
            }   

            WriteLine("Question 6 of 30 - Pick a car brand");
            string carBrandString = ReadLine();
            if (!string.IsNullOrEmpty(carBrandString))
                carBrand = carBrandString;

            WriteLine("Question 7 of 30 - Pick a place");
            string nounPlaceString = ReadLine();
            if (!string.IsNullOrEmpty(nounPlaceString))
                nounPlace = nounPlaceString;

            WriteLine("Question 8 of 30 - Pick a person");
            string personString = ReadLine();
            if (!string.IsNullOrEmpty(personString))
                nounPerson = personString;

            WriteLine("Question 9 of 30 - Pick a clothing brand");
            string clothingString = ReadLine();
            if (!string.IsNullOrEmpty(clothingString))
                clothingBrand = clothingString;

            WriteLine("Question 10 of 30 - Pick a cheap beverage");
            string cheapBeverageString = ReadLine();
            if (!string.IsNullOrEmpty(cheapBeverageString))
                cheapBeverage = cheapBeverageString;

            WriteLine($"Question 11 of 30 - Pick a plural noun ({Definitions.noun})");
            string pluralNounString = ReadLine();
            if (!string.IsNullOrEmpty(pluralNounString))
                pluralNoun = pluralNounString;

            WriteLine("Question 12 of 30 - Pick a number");
            string response3 = ReadLine();
            int value3;
            if (!string.IsNullOrEmpty(response3))
            {
                while (!int.TryParse(response3, out value3))
                {
                    WriteLine("Hmm that number looks strange, almost looks like it's NOT a number. Try again.");
                    response3 = ReadLine();
                }
                number3 = value3;
            }   

            WriteLine($"Question 13 of 30 - Pick another plural noun ({Definitions.noun})");
            string pluralNoun2String = ReadLine();
            if (!string.IsNullOrEmpty(pluralNoun2String))
                pluralNoun2 = pluralNoun2String;

            WriteLine($"Question 14 of 30 - Pick a country");
            string countryString = ReadLine();
            if (!string.IsNullOrEmpty(countryString))
                country = countryString;

            WriteLine("Question 15 of 30 - Pick a number");
            string response4 = ReadLine();
            int value4;
            if (!string.IsNullOrEmpty(response4))
            {
                while (!int.TryParse(response4, out value4))
                {
                    WriteLine("Numbers only please! Come on, we talked about this. This time, with a number.");
                    response4 = ReadLine();
                }
                percentage = value4;
            }  

            WriteLine("Question 16 of 30 - Pick a website");
            string websiteString = ReadLine();
            if (!string.IsNullOrEmpty(websiteString))
                website = websiteString;

            WriteLine($"Question 17 of 30 - Pick an exclamation ({Definitions.exclamation})");
            string exclamationString = ReadLine(); //read what user wrote
            if (!string.IsNullOrEmpty(exclamationString)) //user enters something
            { 
                exclamation = exclamationString.ToUpper();
            }  // default, user presses enter without typing anything, use defaults

            WriteLine("Question 18 of 30 - Pick a feeling");
            string feelingString = ReadLine();
            if (!string.IsNullOrEmpty(feelingString))
                feeling = feelingString;

            WriteLine("Question 19 of 30 - Pick a number");
            string response5 = ReadLine();
            int value5;
            if (!string.IsNullOrEmpty(response5))
            {
                while (!int.TryParse(response5, out value5))
                {
                    WriteLine("That number looks strange, almost like it's.. not a number. Give it another shot.");
                    response5 = ReadLine();
                }
                amount = value5;
            }   

            WriteLine("Question 20 of 30 - Pick a city");
            string cityString = ReadLine();
            if (!string.IsNullOrEmpty(cityString))
                city = cityString;

            WriteLine($"Question 21 of Pick another plural noun ({Definitions.noun})");
            string pluralNoun3String = ReadLine();
            if (!string.IsNullOrEmpty(pluralNoun3String))
                pluralNoun3 = pluralNoun3String;

            WriteLine("Question 22 of 30 - Pick a number");
            string response6 = ReadLine();
            int value6;
            if (!string.IsNullOrEmpty(response6))
            {
                while (!int.TryParse(response6, out value6))
                {
                    WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response6 = ReadLine();
                }
                percentage2 = value6;
            }

            WriteLine("Question 23 of 30 - Pick a verb ending in -ing eg. 'running'");
            string verbINGString = ReadLine();
            if (!string.IsNullOrEmpty(verbINGString))
                verbING = verbINGString;

            WriteLine($"Question 24 of 30 - Pick a noun ({Definitions.noun})");
            string nounString = ReadLine();
            if (!string.IsNullOrEmpty(nounString))
                noun = nounString;

            WriteLine("Question 25 of 30 - Pick a beverage");
            string beverageString = ReadLine();
            if (!string.IsNullOrEmpty(beverageString))
                beverage = beverageString;

            WriteLine($"Question 26 of 30 - Pick a place");
            string placeString = ReadLine();
            if (!string.IsNullOrEmpty(placeString))
                place = placeString;

            WriteLine($"Question 27 of 30 - Pick a verb ({Definitions.verb})");
            string verbString = ReadLine();
            if (!string.IsNullOrEmpty(verbString))
                verb = verbString;

            WriteLine($"Question 28 of Pick an adverb ({Definitions.adverb})");
            string adverbString = ReadLine();
            if (!string.IsNullOrEmpty(adverbString))
                adverb = adverbString;

            WriteLine("Question 30 of 30 - Almost there! Pick a number");
            string response7 = ReadLine();
            int value7;
            if (!string.IsNullOrEmpty(response7))
            {
                while (!int.TryParse(response7, out value7))
                {
                    WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response7 = ReadLine();
                }
                number4 = value7;
            }
            
            WriteLine("Question 30 of Your patience has paid off. This is the last one: Pick a number");
            string response8 = ReadLine();
            int value8;
            if (!string.IsNullOrEmpty(response8))
            {
                while (!int.TryParse(response8, out value8))
                {
                    WriteLine("Hmmm that doesn't look like a number to me! Try again.");
                    response8 = ReadLine();
                }
                number5 = value8;
            }    

            WriteLine("Here's the story you created: entitled 'Not just any motivational YouTube Ad'");
            WriteLine($"Hi, my name is {celeb} and I'm gonna teach you about how I make ${number} while I'm sleeping. Pay attention, because I'm going to share with you the stuff not even {talkhost} will tell you about finance. \n " +

                $"I'm coming to you from my garage, just took my {carModel} out for a spin. I know what you're thinking. You see me standing in front of my {number2} {carBrand}s and you're asking yourself, '{celeb}, what's your secret?' By the end of this, you're gonna want to quit your day job. \n " +

                $"About six years ago, I was working at {nounPlace} when my mentor {nounPerson} came in wearing {clothingBrand} shoes and I just knew I had to be like them. We went out for a {cheapBeverage} and they told me, '{celeb}, in order to retire early you need to dropship {pluralNoun}.' At that time I had no idea what dropshipping was, but what I heard was so simple. \n" +
                
                $"{nounPerson} said, 'All you have to do is just buy {number3} {pluralNoun2} from {country} and sell them at a {percentage}% markup on {website}. That's it! That's all you gotta do.' When {nounPerson} told me how easy it was, I was so {feeling} just shouted from the rooftops, '{exclamation.ToUpper()}!!' Then I just cash my cheque for ${amount} and then I can spend it on whatever I want. If I want to vacation in {city} no one's gonna stop me. \n " +
                
                $"I've got the freedom units to buy {pluralNoun3} every day if I want to. I'll tell you what, {percentage2}% of people won't even try this. They'll be stuck {verbING} all day at a {noun} they hate and I'll be laughing, drinking my {beverage} by the {place}. And you can too if you buy my ebook, 'How to {verb} {adverb}' for the low, low price of ${number4} but only for the next {number5} minutes. We can't do this all day.");

            Read();
        }
    }
}
