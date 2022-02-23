using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");
            
            // This asks for user input for their hourly rate
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate: ");
            //This next line converts from a string to a decimal
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            // Now we get their hours worked per week
            Console.WriteLine("Please enter your hours worked per week: ");
            // Then convert that data from string to decimal
            decimal hoursWorkedPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            // We do the same steps for person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your hours worked per week: ");
            decimal hoursWorkedPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            // Here we do the calculations
            decimal totalSalary1 = hourlyRate1 * hoursWorkedPerWeek1;
            decimal totalSalary2 = hourlyRate2 * hoursWorkedPerWeek2;

            // And give the total for each
            Console.WriteLine("Annual Salary of Person 1: ");
            Console.WriteLine(totalSalary1);

            Console.WriteLine("Annual Salary of Person 2: ");
            Console.WriteLine(totalSalary2);

            //Finally the comparison in a true/false statement
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isOneMore = totalSalary1 > totalSalary2;
            Console.WriteLine(isOneMore);
            Console.ReadLine();





        }
    }
}
