using System;


namespace DateTime_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // getting the current datetime and printing it to the console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            // aksing the user to input a number, saving that number to a variable, converting that value to a double
            Console.WriteLine("Please input a whole number..");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            // creating a new variable, newTime, and using the AddHours method to add the userNumber to it. 
            DateTime newTime = currentTime.AddHours(userNumber);
            Console.WriteLine(newTime);

            Console.ReadLine();
        }
        public static DateTime Now { get; set; }
    }
}
