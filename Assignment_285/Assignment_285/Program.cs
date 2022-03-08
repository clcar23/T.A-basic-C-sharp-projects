using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_285
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // *******This is an example of a 'Void Method' *******
            
            DivideByTwo divideByTwo = new DivideByTwo(); // first i instantiate the class
            Console.WriteLine("Please enter a number: "); // get the user's input
            int num = Convert.ToInt32(Console.ReadLine()); // convert it to an integer
            divideByTwo.MyMath(num, out int result);      // then call on my method in the divideByTwo class

                    
           
            // This is an example of Overloading a Method (continued on line 46)
            int subtrationTotal;
            int subtractionTotal = Subtraction(10, 5); // this version of Subtraction takes two Integer values
            Console.WriteLine(subtractionTotal);

            double subtractionTotal2;
            subtractionTotal2 = Subtraction(1000, 500, 100); // this version takes 3 Double values but shares the same name
            Console.WriteLine(subtractionTotal2);

            Console.ReadLine();

        }
        int x, y;
        public void Multiplication(out int x, out int y)
        {
            x = 5;
            y = 10;
            int result = x * y;
            Console.WriteLine("{0} multiplied by {1} = {2}", x, y, result);
            
        }


        // ******* This is an example of an Overload Method *******
        // Overloaded methods share the same name, but different parameters(types or amount of parameters)
        // This gives each Overloaded method its own 'Signature'
        
        // The first method
        public static int Subtraction(int a, int b) 
        {
            return a - b;
        }
        
         // Now the second method   
        public static double Subtraction(double a, double b, double c)
        {
            return a - b - c;
        }
        

        // ******* This is an example of a Static Class *******
        // this means it belongs to the type itself rather than to a specific object and is 
        // referenced through the name type. If the class is Static, then all the members of the class must be also
        static class Name
        {
            public static void PrintName()
            {
                string myName = "Cliff";
                Console.WriteLine("My name is " + myName);
            }
        }
    }
}
