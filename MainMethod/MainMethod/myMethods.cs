using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    // Created the class MainMethod above, below we have created the myMethod method
    public class myMethods
    {
        // This method will take an integer, create a math op for it, then return the answer
        public static int numMethod(int num)
        {
            int numResult = num + 44;
            return numResult;
        }
        // This method will take a decimal, round it down, then return it as an integer to the main program
        public static decimal decimalMethod(decimal num2)
        {
            // Rounding the decimal down
            decimal decimalResult = Math.Floor(num2);
            // Returning the converted integer
            return Convert.ToInt32(decimalResult);

        }
        // This last method takes in a string number, coverts it to an integer, performs a math op on it, then returns it to the main program
        public static int stringMethod(string name)
        {
            // The conversion to integer
            int newName = Convert.ToInt32(name);            
            return newName * 2;
        }
    }
}
