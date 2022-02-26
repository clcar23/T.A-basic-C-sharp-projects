using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_while_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we begin the app with the question and user input.

            Console.WriteLine("How are you doing today? Pick a number from 0-5.\n 5 = (Master of the Universe!!) - 0 = (The lowliest slug in the scum-pile)  \n >>>: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // This line states that the statement will be true when the number equals 5
            bool perfect = number == 5;

            // Here is my 'do/while' loop
            do
            {
                switch (number)
                {
                    // These lines check through the different unput cases and give the different outputs
                    case 0:
                        Console.WriteLine("You should seek professional help immediately, everything's gonna be ok buddy!");
                        Console.WriteLine("Feeling any better? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("Find a puppy and play with until you feel better.");
                        Console.WriteLine("Feeling any better? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Call a close friend and get your favorite food.");
                        Console.WriteLine("Feeling any better? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Get yourself a delicious beverage that cheers you up.");
                        Console.WriteLine("Feeling any better? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Go for a walk outside and enjoy being alive.");
                        Console.WriteLine("Feeling any better? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    // Here is when the user inputs 5, the highest or 'truest' input
                    case 5:
                        Console.WriteLine("Congratulations on feeling amazing! Now go out there and make someone else feel amazing too!");
                        perfect = true;
                        break;
                    // I put in a default if they guesses outside our range of numbers
                    default:
                        Console.WriteLine("I don't recognize that number, try something else.");
                        Console.WriteLine("How are you doing today? Pick a number from 0-5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // Here is our while loop
            while (!perfect);
            
            Console.ReadLine();

        }
    }
}
