using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------- Code Block -------
            // Here we create our string
            string[] names = { "Awesome", "Cool", "Fantastic", "Friendly", "Smelly?!?" };

            //Next we write to the console and get the users input
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();

            // Here's a quick 'if/else' statement to show to the user after they type in their name
            if (userName.Length < 4)
            {
                Console.WriteLine("I love that name!!");
            }
            // Depending on the length of their name, a different message will print, here it's 6 or less chars
            else if (userName.Length <= 6)
            {
                Console.WriteLine("That's a cool name!");
            }
            else
            {
                // Here it will be more that 6 chars long
                Console.WriteLine("That's a long name!");
            }

            // Here we create a 'for' loop that iterates through the names
            for (int i = 0; i < names.Length; i++)
            {
                // Now we create a new list with the users input added to it
                string[] newNames = { names[i] + " " + userName };

                // Now a 'for' loop that iterates through the new list of names
                for (int j = 0; j < newNames.Length; j++)
                {
                    // And print it to the console
                    Console.WriteLine(newNames[j]);
                }
            }


            // ------- Code Block -------

            // This section activates an infinte loop so it is commented out
            //int infinteLoop = 0;
            //Console.WriteLine("What's your favorite number?");
            //int favNumber = Convert.ToInt32(Console.ReadLine());
            //while (infinteLoop == 0)
            //{
            //    Console.WriteLine(infinteLoop);
                
            //}
            // You can deactivate it by changing the while statement or adding in an increment like 'infiniteLoop++'



            // ------- Code Block -------

            // Here's a list of unique items
            List<string> uniqueList = new List<string> { "horse", "cheese", "toenails", "big", "sparkles", "44", "swordfish", "munchkin" };

            // Here we write a line to the console, get the user's guess
            Console.WriteLine("I've got a random list of words I'm thinking of, see if you can guess one...(Hint, one's something you eat on pizza, one's something you ride on..");
            Console.WriteLine("Make your guess: ");
            string userGuess = Console.ReadLine();
            int wordCounter = 1;

            // Now we'll search for the user's guess through our list
            foreach (string u in uniqueList)
            {
                // Here is our if/else to check for the matching words, and display a message and the words index
                if (userGuess == u)
                {
                    Console.WriteLine(wordCounter + " is " + u + "!");
                    wordCounter++;
                    break;
                    
                }
                else
                {
                    wordCounter++;   
                }
            if (userGuess != u)
            {
                Console.WriteLine("Sorry, but " + userGuess + " in not on the list.");
            }
            }


            // ------- Code Block -------

            // First we create our list
            List<string> pets = new List<string> { "cat", "dog", "fish", "cat", "hamster", "bird", "lizard" };

            // Now we write to the console and save their response
            Console.WriteLine("Whats your favorite type of household pet?");
            string userPet = Console.ReadLine();
            // Here we add a value counter
            int value = 0;
            int value2 = 0;
            // This is our 'foreach' loop to check their answer against our list
            foreach (string p in pets)
            {
                // If the answer matches our list
                if (userPet == p)
                {
                    Console.WriteLine("We found your pet: " + p + " in index position: " + value);
                    value++;
                    value2++;
                }
                // If it does not match, we can increase the counter
                if (p != userPet)
                {
                    value++;
                }
                // If it does not match, we can keep this value to 0 and print to the console
                if (value2 == 0)
                {
                    Console.WriteLine("Sorry, but that pet isn't in this spot on our list.");
                    value2++;
                }
            }


            // ------- Code Block  -------

            // First we create our list of strings
            List<string> colors = new List<string> { "red", "blue", "yellow", "green", "purple", "orange", "black", "white", "brown", "pink", "red" };
            // Console log our question
            Console.WriteLine("What's your favorite color?");
            // Save their answer to a variable
            string favColor = Console.ReadLine();
            // This variable will be our counter through the list
            int colorValue = 1;

            // Now we create a 'foreach' loop that evaluates each list item
            foreach (string c in colors)
            {
                // This 'if' statement will check if their color matches one of ours
                if (favColor == c)
                {
                    // This will print the color and it's position on our list
                    Console.WriteLine("This is where the color " + c + " is on our list! " + colorValue + " of " + colors.Count);
                    // Now we add to the counter
                    colorValue++;
                }
                // If their color in not on the list, this will print instead.
                else
                {
                    Console.WriteLine("Sorry but this is a different color.");
                    // Here we still add to our counter
                    colorValue++;
                }
            }



            Console.ReadLine();







        }
    }
}
