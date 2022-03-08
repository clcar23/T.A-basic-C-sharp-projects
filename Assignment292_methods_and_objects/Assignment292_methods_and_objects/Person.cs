using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment292_methods_and_objects
{
    class Person                                 // created class Person
    {
        public string FirstName;                 // added name variables
        public string LastName;

        public void SayName()                    // created SayName method
        {
            Console.WriteLine($"Name:{FirstName} {LastName}"); // prints the names to the console
        }
    }
}
