// Problem 1. Numbers from 1 to N

/* Write a program that enters from the console a positive integer n 
 * and prints all the numbers from 1 to n, on a single line, separated by a space.

Examples:
n 	output
3 	1 2 3
5 	1 2 3 4 5
 */

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a value for the int n: ");
        int n = int.Parse(Console.ReadLine());

        // logic
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", (i + 1));
        }
        Console.WriteLine();
    }
}

