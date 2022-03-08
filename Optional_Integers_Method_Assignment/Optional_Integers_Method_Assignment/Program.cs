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
           
                // Instatiating the class
                mathMethods mathMethods = new mathMethods();

                // Having the user enter in a number, required
                Console.WriteLine("Please enter a whole number: ");
                int requiredInt = Convert.ToInt32(Console.ReadLine());

                // Now we ask for the user to input a second number
                Console.WriteLine("Please enter in another whole number, or don't, it doesn't matter: ");
                
            // Here we implement a try/catch block in case they dont submit a second number
            try
            {
                int optionalInt = Convert.ToInt32(Console.ReadLine()); // convert their input to a string
                int results = mathMethods.calculate(requiredInt, optionalInt); // get the results from our other class
                Console.WriteLine(requiredInt + " + " + optionalInt + " = " + results); // display the results
            }
            // if they do not submit a number, this block will run
            catch
            {
                int results = mathMethods.calculate(requiredInt); // we get the results of the first number and ours combined
                Console.WriteLine(requiredInt + " + (our number) = " + results); // and print the results
            }

            Console.ReadLine();
           
            
           
        }
            
                
                
                
           
        }
    }

