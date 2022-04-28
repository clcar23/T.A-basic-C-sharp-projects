using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambda_Expression2
{
    class Program
    {
        // Here are a couple examples of using Lambdas
        static void Main(string[] args)
        {
            // First we create a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            // Next we put in our Lambda expression
            Func<int, int> squared = x => x * x;

            // Then we call the function, enter a number, and print to the console
            Console.WriteLine(squared(5));

            // Here is another
            Func<int, bool> checkOdd = x => x % 2 != 0;

            var oddNumbers = numbers.Where(checkOdd).ToList();

            oddNumbers.ForEach(x => Console.WriteLine(x));

            // This is an example of a Lambda statement
            Action<int> exponent = x =>
            {
                var square = x * x;
                var cube = x * x * x;
                Console.WriteLine($"{x} : Squared = {square}, and cubed = {cube}");
            };

            var otherNumbers = numbers.Where(checkOdd).ToList();

            otherNumbers.ForEach(exponent);
            
            Console.ReadLine();
        }
    }
}
