using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_285
{

    class DivideByTwo
    {
        // created a method to take input, perform math on it, send it back to main program
        static void PrintQuotient(int num)
        {
            int result = num / 2;
            Console.WriteLine("Your number {0}, divided by two is {1}.", num, result);
        }
    }
}
