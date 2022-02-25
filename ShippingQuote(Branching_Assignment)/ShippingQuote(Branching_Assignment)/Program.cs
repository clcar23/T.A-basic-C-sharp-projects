using System;
using System.Globalization;

namespace ShippingQuote_Branching_Assignment_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asking user for the package weight and converting it to an integer
            Console.WriteLine("Please enter your package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Writing an if/else statement to make sure the weight isn't too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            // If not too heavy this part will execute getting the rest of the package measurements and converting to integers
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                // Checking again for excessive size and using an if/else statement
                if (width + length + height > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                // Combining the measurements, and converting them to a dollar amount on line 42
                else
                {
                    int totalArea = (height * width * length);
                    int packageTotal = (totalArea * weight);
                    decimal quote = (packageTotal / 100m);
                    string quoteInDollars = quote.ToString("C");
                    Console.WriteLine("Your estimated total for shipping this package is: " + quoteInDollars);
                    Console.WriteLine("Thank you!");
                }
            Console.ReadLine();
            }
        }
    }
}
