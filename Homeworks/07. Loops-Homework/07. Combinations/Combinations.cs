// Problem 7. Calculate N! / (K! * (N-K)!)

/* In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
   Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

Examples:
 n 	k 	n! / (k! * (n-k)!)
 3 	2 	      3
 4 	2 	      6
10 	6 	    210
52 	5 	2598960
 */

using System;
using System.Numerics;

class Combinations
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
        BigInteger quotient = 1;  // n! / k!
        BigInteger factorialNMinusK = 1; // (n - k)!

        // logic
        for (int i = k + 1; i <= n; i++)
        {
            quotient *= i;
        }

        for (int j = 1; j <= (n - k); j++)
        {
            factorialNMinusK *= j;
        }

        // final calculations and print
        Console.WriteLine("\nn! / (k! * (n-k)!) = {0}\n", quotient / factorialNMinusK);

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

