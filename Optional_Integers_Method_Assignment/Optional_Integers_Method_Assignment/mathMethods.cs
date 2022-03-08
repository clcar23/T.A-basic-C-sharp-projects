using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Integers_Method_Assignment
{
    // Creating the class
    public class mathMethods
    {
        // Here is the method that will be called, a required value, and an optional one with a default of one
        public int calculate(int requiredInt, int optionalInt = 1)
        {
            // Returning the two values added together
            int result = requiredInt + optionalInt;
            return result;
        }
  
    }
        

    
}
