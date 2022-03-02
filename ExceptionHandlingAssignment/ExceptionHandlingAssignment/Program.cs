using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This begins our TRY block
            try 
            {
                // Here we have a list of numbers
                List<int> numberList = new List<int>() { 20, 66, 97, 1082, 33756 };
                // Now we ask for the user to input a number, and save it to a variable
                Console.WriteLine("Please type in a number.");
                // Convert the variable from string to an integer
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Below we have our math and print the answers to the console
                int numberOne = numberList[0] / userNumber;
                Console.WriteLine(numberList[0] + " divided by " + userNumber + " equals: " + numberOne);

                int numberTwo = numberList[1] / userNumber;
                Console.WriteLine(numberList[1] + " divided by " + userNumber + " equals: " + numberTwo);

                int numberThree = numberList[2] / userNumber;
                Console.WriteLine(numberList[2] + " divided by " + userNumber + " equals: " + numberThree);

                int numberFour = numberList[3] / userNumber;
                Console.WriteLine(numberList[3] + " divided by " + userNumber + " equals: " + numberFour);

                int numberFive = numberList[4] / userNumber;
                Console.WriteLine(numberList[4] + " divided by " + userNumber + " equals: " + numberFive);
                return;
            }
            // Here are our CATCH blocks, this one displays when the user inputs a zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero. Please try another number.");
                return;
            }
            // This block will handle any other wrong inputs
            catch (SystemException ex)
            {
                Console.WriteLine("Please type in a whole number.");
                return;
            }
            Console.WriteLine("Program has emerged from the try/catch block and continued with execution.");

            Console.ReadLine();
        }
        
    }
    
}
