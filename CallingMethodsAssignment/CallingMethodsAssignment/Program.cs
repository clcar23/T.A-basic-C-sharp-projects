using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing to the console and converting the user number to a double, 'just in case'
            Console.WriteLine("Please enter a number:");
            double num = Convert.ToDouble(Console.ReadLine());

            // Calling on methodOne from the mathMethods class to operate on their number
            double resultOne = mathMethods.methodOne(num);
            Console.WriteLine("Your number to the 3rd power is: " + resultOne );

            // Calling on methodTwo to get the square root
            double resultTwo = mathMethods.methodTwo(num);
            Console.WriteLine("The square root of your number is: " + resultTwo );

            // Rounding their number with methodThree called
            double resultThree = mathMethods.methodThree(num);
            Console.WriteLine("Your number rounded up is: " + resultThree);
            Console.ReadLine();
        }
        
    }
}
