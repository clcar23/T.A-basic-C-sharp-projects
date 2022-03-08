using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_285
{

    public class DivideByTwo
    {
       
     
        public void MyMath(int num, out int result)
        {
            result = num / 2;
            Console.WriteLine($"{num} divided by two = {result}.");
        }

    }
}
