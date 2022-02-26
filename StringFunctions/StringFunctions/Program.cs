using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we created three strings
            string name = "Steve";
            string isCool = " He is a cool dude. ";
            string isNotCool = " Until one day he cut his hair, now he has a mullet.";

            // We can make his name all uppercase using this
            name.ToUpper();

            // Now we will concatenate them together
            Console.WriteLine("Once there was a man named " + name + "."  + isCool + isNotCool);


            // Here we are going to create an instance of C# stringbuilder function, this helps expand/contract strings
            StringBuilder sb = new StringBuilder("The story of Sad Steve: ");

            // Below we can add the strings together using 'append'
            sb.Append("There once was a cool dude named Steve. ");
            // Also replace a word in the previous string
            sb.Replace("cool", "sad");
            sb.Append("His haircut was outdated and goofy. ");
            sb.Append("He didn't understand why people didn't want to hang out with him.");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
