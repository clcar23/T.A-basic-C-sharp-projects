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
            Employee employee = new Employee();

            // instantiate the employee2 object
            Employee employee2 = new Employee();

            // create an employee with an Id number
            employee2.FirstName = "Cliff";
            employee2.Id = 1234;

            //instantiate another employee
            Employee employee1 = new Employee();

            // create another employee with number
            employee1.FirstName = "Gary";
            employee1.Id = 2345;

            // compare the two and print to the console
            Console.WriteLine(employee2 == employee1);
            

            // created new objects with it
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // call SayName method
            employee.SayName();

            // calling the quit method on employee
            employee.Quit();

            Console.ReadLine();
        }
    }
}
