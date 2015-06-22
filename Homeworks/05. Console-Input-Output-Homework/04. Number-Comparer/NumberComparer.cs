// Problem 4. Number Comparer

/*  Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

Examples:
 a 	    b 	    greater
 5 	    6 	    6
10 	    5 	   10
 0 	    0 	    0
-5 	   -2 	   -2
 1.5 	1.6 	1.6
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;
        float number;

        string intro = @"This program gets two numbers from the console 
and prints the greater of them.";

        Console.WriteLine(intro);

        List<float> numbers = new List<float>();

        // limits the number entries to 2, and numbers the input entries
        for (int i = 1; i < 3; i++)
        {
            do // validate input for number
            {
                Console.Write("\nPlease, enter number {0}: ", i);
                input = Console.ReadLine().Replace(",", ".");

            } while (!float.TryParse(input, out number));

            numbers.Add(number); // adds the entered numbers into the numbers list
        }

        // selects Max value element from the numbers list, and prints it
        Console.WriteLine("\nThe greater number is {0}\n", numbers.Max());
    }
}

