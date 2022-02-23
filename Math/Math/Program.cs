using System;


namespace Math
{
    class Program
    {
        static void Main()
        {
            int num1 = 5;
            int num2 = 8;
            int total = num1 + num2;
            Console.WriteLine(total);

            int num3 = 9;
            int num4 = 6;
            int remainder = num3 - num4;
            Console.WriteLine(total);

            int num5 = 10;
            int num6 = 4;
            int product = num5 * num6;
            Console.WriteLine(product);

            int num7 = 6;
            int num8 = 2;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            
            int num9 = 7;
            float num10 = 5.5f;
            // always assign the resulting data type to the most specific one or cast one of the numbers
            int newTotal = num9 + (Int32)num10;
            //Console.ReadLine();

            // This equation adds a double and a float.
            // We must put the data type of total as a 'double' because 
            // a float is 32-bit and double is 64-bit. It is a better fit for a data type.
            double num11 = 7.03230923;
            float num12 = 5.9f;
            double total_2 = num11 + num12;
            Console.WriteLine(total_2);
            // The compiler converts the 'float' to 'double' without being told to do so.
            // This is called an 'implicit conversion'

            // To convert a 'double' to a 'float' we use this.
            float total_1 = (float)num11 + num12;
            Console.WriteLine(total_1);

            // There is no implicit conversion for a 'float' or 'double' to 
            // a 'decimal'
            decimal num13 = 7.03230923m;
            decimal total_3 = num13 + num2;
            Console.WriteLine(total_3);

            // Or you could write it as..
            sbyte num14 = 5;
            decimal total_4 = num14 + num2;
            Console.WriteLine(total_4);

            // Math operations on strings, an example of string concatenation
            string firstName = "Cliff";
            string lastName = "Carpenter";
            Console.WriteLine(firstName + lastName);

            // An implicit conversion of data types
            string name = "Kai";
            int number = 5;
            Console.WriteLine(name + number);
            // The compiler implicitly converted the 'int' called 'number' to a string data type.

            // A math equation where the answer is given as a string
            int total_5 = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total_5.ToString());

            // An equation with a remainder, here we use a modulous operator
            int remainder_1 = 11 % 2;
            Console.WriteLine(remainder_1);

            //---------Comparison Operators---------
            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse);

            // To check for equality
            int roomTemperature = 69;
            int currentTemperature = 72;

            bool isWarm = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm);

            // This part will show how to get a number from the user, and give a boolean back if it's greater than 50
            Console.WriteLine("Type in a number: ");
            int randomNumber_1 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse_2 = randomNumber_1 > 50;
            Console.WriteLine("Is your number greater than 50? " + trueOrFalse_2);

            // Using the modulus operator to get the remainder
            Console.WriteLine("Type in a number: ");
            decimal randomNumber_2 = Convert.ToDecimal(Console.ReadLine());
            decimal newValue = randomNumber_2 % 7m;
            Console.WriteLine("The remainder is: " + newValue);

            Console.ReadLine();




            
                    












        }
    }
}
