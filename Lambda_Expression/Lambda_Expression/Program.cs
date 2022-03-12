using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Program
    {
        public void Main(string[] args)
        {

            // creating a list of employees
            List<Employee> employees = new List<Employee>
            {
            // adding names and id's to the list
            new Employee { FirstName = "Barry", LastName = "Aardvark", Id = 2},
            new Employee { FirstName = "Jooooo", LastName = "Baboon", Id = 345},
            new Employee { FirstName = "Joh", LastName = "Chimpanzee", Id = 3},
            new Employee { FirstName = "Jo", LastName = "Gibbon",  Id = 986},
            new Employee { FirstName = "Jho", LastName = "Orangutan", Id = 1},
            new Employee { FirstName = "Joe", LastName = "Spidermonkey", Id = 234},
            new Employee { FirstName = "Joe", LastName = "Gorrila", Id = 993},
            new Employee { FirstName = "JoJo", LastName = "Bonobo", Id = 3243},
            new Employee { FirstName = "Josephine", LastName = "Marmoset", Id = 122},
            new Employee { FirstName = "JojoTheDancingMonkey", LastName = "Rogers", Id = 666}
            };

            // creating a foreach loop to run through the list and find employees named 'Joe' and add them to a new list
            foreach (List<string> z in employees)
            {
                if (Employee.FirstName == "Joe")
                {
                    Employee.newList.Add(z);
                }
            }

            // created a lambda expression to do the same only shortened, then print to the console
            List<Employee> newList1 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(newList1);

            // created an expression to go thru the list and create a new list with Id's greater than 5
            List<Employee> newList2 = employees.Where(y => y.Id > 5).ToList();
            Console.WriteLine(newList2);
            Console.ReadLine();

        }

        // created class Employee
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
        }
    }
}

