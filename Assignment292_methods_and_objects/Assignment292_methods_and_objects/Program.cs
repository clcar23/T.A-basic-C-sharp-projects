using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment292_methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate the employee class
            employee.FirstName = "Sample";      // set the first and last names from the Person class
            employee.LastName = "Student";
            employee.SayName();                 // calls the superclass method SayName() in the Person Class

            Console.ReadLine();
        }
    }
}
