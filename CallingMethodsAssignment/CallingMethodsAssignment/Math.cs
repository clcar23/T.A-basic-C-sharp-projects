using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethodsAssignment
{
    // Created class mathMethods
    public class mathMethods
    {
        // Created first method 
        public static Double methodOne(double num)
        {           
            // Inside this method the given numbers exponent of 3 will be found 
            double resultOne = Math.Pow(num, 3);
            return resultOne;
        }

        // Created the second method
        public static Double methodTwo(double num)
        {
            // This operation will find the square root of a given number
            double resultTwo = Math.Sqrt(num);
            return resultTwo;
        }

        //Created the third method
        public static Double methodThree(double num)
        {
            // This operation will round up a decimal number
            double resultThree = Math.Ceiling(num);
            return resultThree;
        }



    }
}
