﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    // Here we have class Emplyee inheriting from class Person
    public class Employee : Person
    {
        // create the Id property
        public int Id { get; set; }
        
        // implemented SayName method from Person class, have it print to the console
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);   
        }

        
      
    }
}