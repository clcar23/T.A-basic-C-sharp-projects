using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // beginning of try/catch block to check for errors
            try
            {
                // get the age of the user, convert to integer
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());

                // create a For loop if the user enters in anything below a zero
                if (age < 0)
                {
                    Console.WriteLine("That is not possible.");
                    Console.ReadLine();
                    return;
                }
                // creating a variable for the year now
                var timeNow = DateTime.Now.Year;
                // creating a variable that is this year minus the users age
                var yearBorn = timeNow - age;
                // writing to the console
                Console.WriteLine(age + " years ago it was... " + yearBorn);
                Console.ReadLine();
            }
            // this catch block will display if the users entry is other than a whole number
            catch (FormatException)
            {
                Console.WriteLine("Please enter whole digits only.");
                Console.ReadLine();
                return;
            }
            // this catch block will handle anything else
            catch (Exception) 
            {
                Console.WriteLine("An error occurred, try a different approach.");
                return;

            }
           
        }
        public int Year { get; }
    }
        
  
}
