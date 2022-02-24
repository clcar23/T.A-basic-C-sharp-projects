using System;

namespace Boolean_Logic_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This first line gets the users age, converts to an integer
            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            // This line sees if they have a DUI 
            Console.WriteLine("Have you ever had a DUI? Yes or No");
            string dui = Console.ReadLine();

            // This line finds how many speeding tickets, converts to an integer
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Here I wrote an if/else statement to get a qualified result or not
            // I added in different operators to account for all the conditions
            if (age > 15 && dui == "No" || dui == "no" && tickets <= 3)
            {
                Console.WriteLine("What is your age? ");
                Console.WriteLine(age);
                Console.WriteLine("Have you ever had a DUI? Yes or No");
                Console.WriteLine(dui);
                Console.WriteLine("How many speeding tickets do you have? ");
                Console.WriteLine(tickets);
                Console.WriteLine("Qualified? ");
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("What is your age? ");
                Console.WriteLine(age);
                Console.WriteLine("Have you ever had a DUI? Yes or No");
                Console.WriteLine(dui);
                Console.WriteLine("How many speeding tickets do you have? ");
                Console.WriteLine(tickets);
                Console.WriteLine("Qualified? ");
                Console.WriteLine("False");
            }

            Console.ReadLine();


            

        }
    }
}
