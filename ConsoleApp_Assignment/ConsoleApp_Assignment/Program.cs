using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Here we create our string
            //string[] names = { "Awesome", "Cool", "Fantastic", "Friendly", "Smelly?!?" };

            ////Next we write to the console and get the users input
            //Console.WriteLine("Please enter your name.");
            //string userName = Console.ReadLine();

            //// Here's a quick 'if/else' statement to show to the user after they type in their name
            //if (userName.Length < 4)
            //{
            //    Console.WriteLine("I love that name!!");
            //}
            //else if (userName.Length <= 6)
            //{
            //    Console.WriteLine("That's a cool name!");
            //}
            //else
            //{
            //    Console.WriteLine("That's a long name!");
            //}

            //// Here we create a 'for' loop that iterates through the names
            //for (int i = 0; i < names.Length; i++)
            //{
            //    // Now we create a new list with the users input added to it
            //    string[] newNames = { names[i] + " " + userName };

            //    // Now a 'for' loop that iterates through the new list of names
            //    for (int j = 0; j < newNames.Length; j++)
            //    {
            //        // And print it to the console
            //        Console.WriteLine(newNames[j]);
            //    }
            //}

            //// Here's a list of unique items
            //List<string> uniqueList = new List<string> { "horse", "cheese", "toenails", "big", "sparkles", "bathtub" };

            //// Here we write a line to the console, get the user's guess
            //Console.WriteLine("I've got a random list of 6 words I'm thinking of, see if you can guess one...(Hint, one's something you eat on pizza, one's something you ride on..");
            //Console.WriteLine("Make your guess: ");
            //string userGuess = Console.ReadLine();

            //// Now we'll search for the user's guess through our list
            //foreach (string word in uniqueList)
            //{
            //// Here is our if/else to check for the matching words, and display a message and the words index
            //    if (userGuess == word)
            //    {
            //    Console.WriteLine("You guessed a word correctly! " + uniqueList.IndexOf(word));
            //        break;
            //    }
            //    else 
            //    {                       
            //    Console.WriteLine("That's not one of the words! Please try again!");
            //        break;
            //    }
            //}

            List<string> pets = new List<string> { "cat", "dog", "fish", "cat", "hamster", "bird", "lizard" };

            Console.WriteLine("Whats your favorite type of household pet?");
            string userPet = Console.ReadLine();
            int value = 0;
            int value2 = 0;
            foreach (string p in pets)
            {
                
                if (userPet == p)
                {
                    Console.WriteLine("We found your pet: " + p + " in index position: " + value );
                    value++;
                }
                if (p != userPet)
                {
                    value++;
                    value2++;
                }
                               
            }
            if (value2 == 0)
            {
                Console.WriteLine("Sorry, but that pet isn't on our list.");
            }
            Console.ReadLine();







        }
    }
}
