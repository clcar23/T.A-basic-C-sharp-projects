using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class 'myMethods' and method 'numMethod', then passing in the integer 6
            int intResult = myMethods.numMethod(6);
            Console.WriteLine(intResult);

            // Doing the same as above but calling the 'decimalMethod' and passing in 6.6
            decimal decimalResult = myMethods.decimalMethod(6.6m);
            Console.WriteLine(decimalResult);

            // Finally passing a string '66' and getting back an integer
            int stringResult = myMethods.stringMethod("66");
            Console.WriteLine(stringResult);

            Console.ReadLine();
        }

        
    }
}
