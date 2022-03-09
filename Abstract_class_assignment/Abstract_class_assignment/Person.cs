using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    // created an abstract class Person
    public abstract class Person
    {
        // create the two properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // and one method
        public abstract void SayName();
            
    };
}
