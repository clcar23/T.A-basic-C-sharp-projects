using System;
// This is the system we'll use for making lists
using System.Collections.Generic;

namespace Arrays_And_Lists
{
    class Program
    {
        static void Main()
        {   
            // This is how we make lists in C#, here is one for 'integers'
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            // Here i've created one for strings
            List<string> stringList = new List<string>();
            stringList.Add("Alpha");
            stringList.Add("Beta");
            stringList.Add("Charlie");
            stringList.Remove("Beta");

            // Lists can be created using any data type

            Console.WriteLine(stringList[0]);
            Console.ReadLine();



            //// In C# when creating an array you need to specify how big the array is, (how many). Here it's '5'.
            //// Items in the array can be changed but the length can not.
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //// This is a shorter way of creating the same array. Here you don't have to set the length like above.
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //// And here is an even SHORTER way of creating an array. Again w/o having to state its length.
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            
            //// Here we show how to change a number within the array.
            //numArray2[5] = 650;


            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
