using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Integers_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using a try/ catch here in case the user doesn't want to play fair
            try
            {
                // Instatiating the class
                mathMethods mathMethods = new mathMethods();

                // Having the user enter in a number, required
                Console.WriteLine("Please enter a whole number: ");
                int requiredInt = Convert.ToInt32(Console.ReadLine());

                // The next input is optional, if they don't enter a number, it will automatically be a zero
                Console.WriteLine("Please enter in another whole number, or don't, it doesn't matter: ");
                int optionalInt = Convert.ToInt32(Console.ReadLine());
                // I added in an 'if' statement to compensate for the user not typing anything at all
                if (optionalInt == null)
                {
                    optionalInt = 0;
                }

                Console.WriteLine(mathMethods.calculate(requiredInt, optionalInt));
   
            }
            // This will catch any errors from the user and give them a message
            catch (SystemException)
            {
                Console.WriteLine("You must at least type in a zero.");
            }
            Console.ReadLine();
        }
            
                
                
                
           
        }
    }

