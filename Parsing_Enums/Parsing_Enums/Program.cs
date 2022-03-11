using System;

namespace Parsing_Enums
{
    class Program
    {
        // created enum for DayOfWeek and assigned int values
        enum DayOfWeek
        {
            sunday = 1,
            monday = 2,
            tuesday = 3,
            wednesday = 4,
            thursday = 5,
            friday = 6,
            saturday = 7
        }

        static void Main(string[] args)
        {
            // using try/catch block to look for potential errors
            try
            {
                // getting the users input, assigning it to value- day
                Console.WriteLine("Please enter the current day of the week: ");
                string day = Console.ReadLine();

                // reassigning the user input to an enum, converting to lowercase to avoid errors
                DayOfWeek Day = Enum.Parse<DayOfWeek>(day.ToLower());
                // entering in the actual day today
                DayOfWeek Today = DayOfWeek.thursday;
                // creating a loop to check if the data matches
                if (Day == Today)
                {
                    Console.WriteLine("Correct!"); // if it matches our data
                }
                else
                {
                    Console.WriteLine("Incorrect"); // if they got the day wrong
                }
            }
            catch (ArgumentException ex) // if they entered in something else
            {
                Console.WriteLine($"Please enter the actual day of the week.");
            }
            
            
           
           
            Console.ReadLine();
        }

        
        
    }
}
