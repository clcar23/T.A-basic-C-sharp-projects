using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    // Here we have class Emplyee inheriting from class Person and Interface IQuittable
    public class Employee : Person, IQuittable
    {
        // create the Id property
        public int Id { get; set; }
        // create the name properties
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //overloading the '==' operator to check if two Employee objects are equal by comparing Id properties
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        // the '==' must be accompanied by the '!=' operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }


        // implemented SayName method from Person class, have it print to the console
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);   
        }
        // implement the Quit method from IQuittable 
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        

    }
}
