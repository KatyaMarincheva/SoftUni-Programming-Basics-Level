// Problem 11.* Numbers in Interval Dividable by Given Number

/* Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0.

Examples:
start 	end 	p 	comments
17 	    25 	    2 	20, 25
5 	    30 	    6 	5, 10, 15, 20, 25, 30
3 	    33 	    6 	5, 10, 15, 20, 25, 30
3 	    4 	    0 	-
99 	    120 	5 	100, 105, 110, 115, 120
107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
 */

using System;
using System.Collections.Generic;
using System.Linq;

class NumbersInIntervalDividableByN
{
    static void Main()
    {
        string intro =
@"This program reads two positive integer numbers 
and prints how many numbers p exist between them such 
that the reminder of the division by 5 is 0.";

        Console.WriteLine(intro);

        string inputA;
        int a;

        string inputB;
        int b;

        do // validates input for a
        {
            Console.Write("\nPlease, enter a value for a: ");
            inputA = Console.ReadLine();

        } while (!int.TryParse(inputA, out a) || a < 0);

                do // validates input for b
        {
            Console.Write("\nPlease, enter a value for b: ");
            inputB = Console.ReadLine();

        } while (!int.TryParse(inputB, out b) || b < 0);

        List<int> nums = new List<int>();

        // stores all numbers between a and b into the nums array
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                nums.Add(i);
            }
        }

        // prints a, b, number of 5x numbers between a and b, the 5x numbers themseles
        Console.WriteLine("\nBetween {0} and {1} there are {2} members of the 5x sequence:\n{3}\n", a, b, nums.Count, string.Join(", ", nums));
    }
}


