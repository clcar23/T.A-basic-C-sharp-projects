using System;
using System.Collections.Generic;

namespace Constructor_Assignment
{
    public class Program 
    {
        static void Main(string[] args)
        {
           
            // this is an example of a const (constant) variable. My name isn't going to ever change so i can set it as a const
            const string myName = "Cliff";
            // here is a var that the program can understand that its a string data type
            var isAwesome = " is one awesome dude!";
            // now i'll concatenate them for fun
            Console.WriteLine("{0}" + "{1}", myName, isAwesome);

            // here i'm creating from my main constructor down below and printing all 3 parameters
            Bugs a = new Bugs("big ugly", 8, true);
            Console.WriteLine("{0}, with " + a.legCount + " legs and is it scary?.." + a.isScary, a.type);

            // and here from the other i print the single parameter
            Bugs b = new Bugs("unknown");
            Console.WriteLine(b.type);

            Console.ReadLine();
        }
        // created the class Bugs
        public class Bugs 
        {
            // here are some variables
            public string type;
            public int legCount;
            public bool isScary;

            // this is a chained constructor that take 1 parameter that is the same as the original
            public Bugs(string type):this(type, 8, false)
            {
                this.type = type;
                Console.WriteLine("This is a chained constructor from the first one!");
            }

            // here i've created the main constructor with 3 parameters
            public Bugs(string type, int legCount, bool isScary)
            {
                this.type = type;
                this.legCount = legCount;
                this.isScary = isScary;
            }
           
        }
        
    }
}
