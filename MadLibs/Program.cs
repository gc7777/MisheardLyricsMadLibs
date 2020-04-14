using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mad Libs");
            Console.WriteLine("-------------------");
            Console.WriteLine("Have you played Mad Libs before? Y / N");
            string response = Console.ReadLine();
            if(response == "Y" || response == "y")
            {
                Console.WriteLine("Okay then! Let's start then!");
                Console.WriteLine("Pick a category:");
                Console.WriteLine("1. Romance");
                Console.WriteLine("2. Action");
            } else if (response == "N" || response == "n")
            {
                Console.WriteLine("No problem. Here's how you play:");
            } else
            {
                Console.WriteLine("Please select either Y for yes or N for no");
            }
        }
    }
}
