using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the employee object
            Employee employee = new Employee();

            // created new objects with it
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // call SayName method
            employee.SayName(); 


            Console.ReadLine();
        }

            

    }
}
