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


            mathMethods.calculate();

            try
            {
                {
                    Console.WriteLine("Please enter a whole number: ");
                    int requiredInt = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter in another whole number, or don't, it doesn't matter: ");
                    int optionalInt = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Console.ReadLine();
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
