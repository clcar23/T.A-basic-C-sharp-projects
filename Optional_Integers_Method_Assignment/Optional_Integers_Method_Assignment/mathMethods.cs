using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Integers_Method_Assignment
{
    public class mathMethods
    {
        
        public int calculate(int requiredInt, int optionalInt = 10)
        {
            
            int result = requiredInt * optionalInt;
            return result;

        }

        internal static void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
