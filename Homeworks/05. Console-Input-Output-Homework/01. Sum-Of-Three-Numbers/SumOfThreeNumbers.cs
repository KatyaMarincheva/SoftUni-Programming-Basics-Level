// Problem 1. Sum of 3 Numbers

/* Write a program that reads 3 real numbers from the console and prints their sum.

Examples:
  a 	    b 	    c 	    sum
  3 	    4 	    11 	    18
 -2 	    0 	     3 	     1
5.5 	    4.5 	20.1 	30.1  */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfThreeNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;
        float number;

        string intro = @"This program invites you to enter three real numbers, 
reads the three numbers from the console, and prints their sum.";
        Console.WriteLine(intro);

        List<float> numbers = new List<float>();

        // limits the number entries to 3, and numbers the input entries
        for (int i = 1; i < 4; i++)
        {
            do // validate input for number
            {
                Console.Write("\nPlease, enter number {0}: ", i);
                input = Console.ReadLine().Replace(",", ".");
                 
            } while (!float.TryParse(input, out number));

            numbers.Add(number); // adds the entered numbers into the numbers list
        }

        // prints the entire numbers list, along with their sum
        Console.WriteLine("\nYou have entered the numbers {0}\nTheir sum is {1}\n", string.
            Join(", ", numbers.ToArray()), numbers.Sum());
    }
}

