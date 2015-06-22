// Problem 8. Catalan Numbers

/* In combinatorics, the Catalan numbers are calculated by the following formula: (2n)!/((n+1)! * n!)
   Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

Examples:
n 	Catalan(n)
0 	1
5 	42
10 	16796
15 	9694845
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n;

        // input
        do
        {
            Console.Write("Please, enter a value for n, so that (0 <= n <= 100): ");
            n = int.Parse(Console.ReadLine());


        } while (!(0 <= n && n <= 100));

        // declarations
        BigInteger quotient = 1;  // (2n)! / n!
        BigInteger factorialNPlus1 = 1; // (n + 1)!

        // logic
        for (int i = n + 1; i <= 2*n; i++)
        {
            quotient *= i;
        }

        for (int j = 1; j <= (n + 1); j++)
        {
            factorialNPlus1 *= j;
        }

        // final calculations and print
        Console.WriteLine("\nn! / (k! * (n-k)!) = {0}\n", quotient / factorialNPlus1);

        /* logic explanation
        
        Example: What is 7! / 4!

        Let us write them out in full:
        7 × 6 × 5 × 4 × 3 × 2 × 1
            = 7 × 6 × 5 = 210
        4 × 3 × 2 × 1

        The 4 × 3 × 2 × 1 "cancelled out", leaving only 7 × 6 × 5
         * Same for (2n)!/n!
         */
    }
}

