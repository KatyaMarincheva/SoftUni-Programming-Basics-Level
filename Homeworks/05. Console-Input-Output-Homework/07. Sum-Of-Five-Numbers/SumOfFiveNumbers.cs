// Problem 7. Sum of 5 Numbers

/*    Write a program that enters 5 numbers (given in a single line, separated by a space),
 * calculates and prints their sum.

Examples:
numbers 	        sum
1 2 3 4 5 	        15
10 10 10 10 10 	    50
1.5 3.14 8.2 -1 0 	11.84
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;

        string intro = @"This program enters 5 numbers (given in a single line, 
separated by a space), calculates and prints their sum.";
        Console.WriteLine(intro);

        float sum = 0f;

        Console.Write("\nPlease, enter 5 numbers in a signle line \nseparated by a space: ");

        input = Console.ReadLine(); 
        string[] numStr = input.Split(' '); // splits entry into array of strings

        for (int i = 0; i < numStr.Length; i++)
			{
                // parse and sum
			    sum += float.Parse(numStr[i]);
			}
        
        // print
        Console.WriteLine("\nThe sum of numbers {0} is {1}\n", string.
            Join(", ", numStr), sum);
    }
}


