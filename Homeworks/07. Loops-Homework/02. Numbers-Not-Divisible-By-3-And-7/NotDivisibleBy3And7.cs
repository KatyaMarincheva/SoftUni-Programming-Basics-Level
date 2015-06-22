// Problem 2. Numbers Not Divisible by 3 and 7

/* Write a program that enters from the console a positive integer n 
 * and prints all the numbers from 1 to n not divisible by 3 and 7, 
 * on a single line, separated by a space.

Examples:
n 	output
3 	1 2
10 	1 2 4 5 8 10
 */

using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a value for the int n: ");
        int n = int.Parse(Console.ReadLine());

        // logic
        for (int i = 1; i <= n; i++)
        {
            // skips numbers divisible by 3*7
            if ((i % 3) == 0 || (i % 7) == 0)
                continue;

            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

