using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_285
{
    class Program
    {
        // Instantiate the class
        DivideByTwo divideByTwo = new DivideByTwo();
        
        static void Main(string[] args)
        {
            // create the method to take the users input
            void UserNumber(out int num)
            {
                Console.WriteLine("Please enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }            
            Console.ReadLine();

            
           
                  
        }
        int x, y;
        public static void Multiplication(out x, out y)
        {
            
            Console.WriteLine("{0} multiplied by {1} = {2}", x, y, z);
            z = 5;
            z *= z;
        }
        
    }
}
