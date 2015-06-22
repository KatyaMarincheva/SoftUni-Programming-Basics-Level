// Problem 6. Calculate N! / K!

/* Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
   Use only one loop.

Examples:
n 	k 	n! / k!
5 	2 	60
6 	5 	6
8 	3 	6720
 */

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        int n;
        int k;
        // input
        do
        {
            Console.Write("Please, enter a value for n, so that (1 < k < n < 100): ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nPlease, enter a value for k, so that (1 < k < n < 100): ");
            k = int.Parse(Console.ReadLine());

        } while (!(1 < k && k < n && n < 100));         

        // declarations
        BigInteger quotient = 1;  // n!/k!

        // logic
        for (int i = k + 1; i <= n; i++)
        {
            quotient *= i;
        }

        // print
        Console.WriteLine("\nN!/K! = {0}\n", quotient);

/* logic explanation
        
Example: What is 7! / 4!

Let us write them out in full:
7 × 6 × 5 × 4 × 3 × 2 × 1
	= 7 × 6 × 5 = 210
4 × 3 × 2 × 1

The 4 × 3 × 2 × 1 "cancelled out", leaving only 7 × 6 × 5
 * Same for n!/k!
 */
    }
}

