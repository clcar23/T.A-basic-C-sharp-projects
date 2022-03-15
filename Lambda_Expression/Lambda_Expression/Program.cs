using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class Program
    {
        static void Main(string[] args)
        {

            // creating a list of employees
            List<Employee> employee = new List<Employee>
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
            List<Employee> joeList = new List<Employee>();
            foreach (var e in employee)
            {
                if (e.FirstName == "Joe")
                {
                    joeList.Add(e);
                    Console.WriteLine(e.FirstName + " was added to the list.");
                }
            }

            // created a lambda expression to do the same only shortened, then print to the console
            List<Employee> newList1 = employee.Where(x => x.FirstName == "Joe").ToList();
            newList1.ForEach(x => Console.WriteLine(x.FirstName));
            

            // created an expression to go thru the list and create a new list with Id's greater than 5
            List<Employee> newList2 = employee.Where(y => y.Id > 5).ToList();
            newList2.ForEach(y => Console.WriteLine(y.Id));
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

