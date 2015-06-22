/* Problem 2.	Prime Checker
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
 * Examples:
n	IsPrime(n)
0	false
1	false
2	true
3	true
4	false
5	true
323	false
337	true
6737626471	true
117342557809	false
 */

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeChecker
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a value for n: ");
        long n = long.Parse(Console.ReadLine());

        // print
        Console.WriteLine("\n{0, -16}{1, -6}", "n", "IsPrime(n)");
        Console.WriteLine("{0, -16}{1, -6}\n", n, IsPrime(n));
    }

    private static bool IsPrime(long number)
    {
        bool isPrime = true;

        if (number == 0 || number == 1)
        {
            isPrime = false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}

