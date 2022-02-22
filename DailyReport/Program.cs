using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // This prints to the console
            Console.WriteLine("The Tech Academy");
            

            // So will this
            Console.WriteLine("Student Daily Report");
            

            // This asks for their name, saves it as a variable and prints it to the console
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            

            // This asks for the course, saves it, and prints it too
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
           

            // This part asks what page, saves as a string, converts to an integer and displays
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int page = Convert.ToInt32(pageNumber);
            

            // This asks a true or false, takes the answer as a string, and converts it to a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);
            

            // This asks a question
            Console.WriteLine("Do you have any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            

            // This asks a question
            Console.WriteLine("Do you have any feedback you'd like to provide? Please be specific.");
            string feeback = Console.ReadLine();
            

            // This asks for their study hours, converts their string into a float
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            float studyHours = float.Parse(hoursStudied);
            

            // This prints a message to the console
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();












        }
    }
}
