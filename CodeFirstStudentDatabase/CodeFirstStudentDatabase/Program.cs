using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstStudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is the code that will add students and their gpa into the database
            using (var ctx = new SchoolContext())
            {
                // create a variable for a new student
                var stud3 = new Student()
                {
                    StudentName = "Carl WhereamI", // their name
                    GPA = 1.02                     // their gpa
                };
                ctx.Students.Add(stud3);           // method to add the the database
                ctx.SaveChanges();                 // save the changes

                // here i wanted to add another student
                var stud2 = new Student()
                {
                    StudentName = "Karen IwannaSeeYourManager",
                    GPA = 3.44
                };
                ctx.Students.Add(stud2);
                ctx.SaveChanges();
            }
            Console.ReadLine();
        }
    }
    
    // Here is the values that will be put into the database
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public double GPA { get; set; }  

        public ICollection<Student> Students { get; set; }
    }

    // create a context class (required) used to query or save to the database
    public class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
