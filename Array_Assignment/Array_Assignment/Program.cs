using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {

            // Here we create a string array.
            string[] stringArray = { "Baron", "Captain", "Lord", "General", "Sir", "Inmate" };

          
            // Now ask the user to choose a number in the array.
            Console.WriteLine("Please pick a number, 0-5");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // Here is a if/else statement if the user goes outside our number range
            if (userNumber <= 5)
            {
                Console.WriteLine(stringArray[userNumber]);

                // This is an integer array that has them choose again
                int[] numArray = { 3, 24, 101, 44, 1000 };
                Console.WriteLine("Please choose a number between 0 and 5, once again.");
                int userNumber2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numArray[userNumber2]);

                // Now a string array 
                string[] funnyNames = { "Underpants", "Googley-Eyes", "Cabbage-breath", "Ferret-Face", "Smelly-Head", "Cheese-Brain" };
                Console.WriteLine("Please choose a number between 0 and 5, this is the last time, I promise.");
                int userNumber3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(funnyNames[userNumber3]);

                // Finally we concatenate and display their choices
                Console.WriteLine("Congratulations, you are now " + stringArray[userNumber] + " " + funnyNames[userNumber3] + " and your IQ is " + numArray[userNumber2] + "!");

                while (numArray[userNumber2] < 4)
                {
                    Console.WriteLine("Ouch that's not an impressive I.Q score is it?");
                    numArray[userNumber2]++;
                }
            }
            // And for those who don't follow instructions!
            else
            {
                Console.WriteLine("Please choose a number between 0 and 5, or get a 3 year old to come help you!");
            }

            Console.ReadLine();

        }
    }
}
